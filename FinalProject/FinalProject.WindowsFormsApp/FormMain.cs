using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Domain.Model;
using FinalProject.Services;
using System.Configuration;
using Newtonsoft.Json;

namespace FinalProject.WindowsFormsApp
{
    public partial class FormMain : Form
    {
        private readonly BackgroundWorker _worker = null;
        private readonly BackgroundWorker _workerIO = null;
        static HttpClient client = new HttpClient();
        const string baseUrl = "http://localhost:54503/api/operation";

        private static string fileSelected = "";
        private static string folderSelected = "";
        public static StringBuilder textMethod = new StringBuilder();
        public static TextBox textTime = new TextBox();



        public FormMain()
        {
            InitializeComponent();
            _worker = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
            _worker.DoWork += worker_DoWork;
            _worker.ProgressChanged += worker_ProgressChanged;
            _worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            _workerIO = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
            _workerIO.DoWork += workerIO_DoWork;
            _workerIO.ProgressChanged += workerIO_ProgressChanged;
            _workerIO.RunWorkerCompleted += workerIO_RunWorkerCompleted;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxNumThreads.SelectedText = "8";
            comboBoxLoops.SelectedText = "2";
        }

        private void _calcButtom_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
         
            if (_digits.Value >= 100)
            {
                progressBarStatus.MarqueeAnimationSpeed = Convert.ToInt32(_digits.Value);
                progressBarStatus.Maximum = Convert.ToInt32(_digits.Value);
            }
            else
            {
                progressBarStatus.MarqueeAnimationSpeed = 100;
                progressBarStatus.Maximum = 100;
                progressBarStatus.Step = 100;
                progressBarStatus.Value = 100;
            }

            if (_calcButtom.Text == "Calculate")
            {
                _pi.Clear();
                _worker.RunWorkerAsync();
            }
            else
            {
                _worker.CancelAsync();
                _pi.AppendText("<<Cancelled>>");
            }

           
            _calcButtom.Text = _calcButtom.Text == "Calculate" ? "Cancel" : "Calculate";
           
        }

   

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            lblStatus.ForeColor = Color.Black;
            labelMethod.Text = "CPU Bound - BW";

            var sw = Stopwatch.StartNew(); // time the operation

            var digits = Convert.ToInt32(_digits.Value);
            StringBuilder pi = new StringBuilder("3", digits + 2);

            if (_worker.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }

            if (digits > 0)
            {
                pi.Append(".");
                for (int j = 0; j < digits; j += 9)
                {
                    int nineDigits = NineDigitsOfPi.StartingAt(j + 1);
                    int digitCount = Math.Min(digits - j, 9);
                    string ds = string.Format("{0:D9}", nineDigits);
                    pi.Append(ds.Substring(0, digitCount));
                    _pi.Text = pi.ToString();

                    if (_worker.CancellationPending == true)
                    {
                        _pi.AppendText("<<Cancelled>>");
                        e.Cancel = true;
                        return;
                    }
                    _worker.ReportProgress(j);
                }
            }
         
            textBoxPerformance.Text = Convert.ToString(sw.Elapsed);
            e.Result = 100;
        }



        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var percent = (int)Math.Round((double)(100 * e.ProgressPercentage) / Convert.ToInt32(_digits.Value));
            lblStatus.Text = "Working...(" + percent + "%)";

            if (_digits.Value >= 100)
            {
                progressBarStatus.Value = e.ProgressPercentage;
                progressBarStatus.Step = e.ProgressPercentage;
            }
            else if (_digits.Value < 10)
            {
                progressBarStatus.Value = 0;
                Thread.Sleep(50);
                progressBarStatus.Value = 50;
                Thread.Sleep(150);
                progressBarStatus.Value = 100;
            }
            else
            {
                progressBarStatus.Value = 0;
                Thread.Sleep(50);
                progressBarStatus.Value = percent;
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Text = "Cancelled by user - " + lblStatus.Text;
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Done... Calc result: " + e.Result + "%";
            }

            _calcButtom.Text = "Calculate";
        }

        private List<Operation> GetOperations(string boundType)
        {
            string URL = baseUrl;

            var data = webGetMethod(URL);

            return JsonConvert.DeserializeObject<List<Operation>>(data).FindAll(x => x.Name.StartsWith(boundType)); 
        }

        private string SetOperation(string name, TimeSpan executionTime)
        {
            var sw = Stopwatch.StartNew(); // time the operation
            string postData = $"name={name}&ExecutionTime={executionTime}";
         
            var dat = new Operation() { Name = name, ExecutionTime = executionTime };
            var ret =  CreateProductAsync(dat);
  
            return Convert.ToString(sw.Elapsed);
        }



        public string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }

/*
        static async Task<Operation> GetOperationAllAsync(string path)
        {
            Operation operation = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                operation = await response.Content.ReadAsAsync<Operation>();
            }
            return operation;
        }
*/
        static async Task<Uri> CreateProductAsync(Operation operation)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                baseUrl, operation);
           
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Operation> GetProductAsync(string path)
        {
            Operation operation = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                operation = await response.Content.ReadAsAsync<Operation>();
            }
            return operation;
        }



        private void ParallelFor1(int numThreads, int loops)
        {
            int numProcs = numThreads, height =loops;
            Task.Factory.StartNew(() =>
            {
                int nextId = -1; // assign each thread a unique id
                var threadId = new ThreadLocal<int>(() => Interlocked.Increment(ref nextId));
          
                    var sw = Stopwatch.StartNew(); // time the operation
              
                        Parallel.For(0, height, new ParallelOptions { MaxDegreeOfParallelism = numProcs }, i =>
                        {
                            int id = threadId.Value;
                      var content =    DoWork(_digits.Value);
                           _pi.AppendText(content);
                           
                            _pi.AppendText($" == Executed by Thread {id} == ");
                           
                        });
                    
                    // Return the total time from the task
                    return sw.Elapsed;

                // When the work completes, run the following on the UI thread
            }).ContinueWith(t =>
            {

                textBoxPerformance.Text = t.Result.ToString();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>Does an amount of work relative to the amount requested.</summary>
        /// <param name="workAmount">The amount of work to perform.</param>
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private static string DoWork(decimal workAmount)
        {
          //  int value = 1;

          
            var digits = Convert.ToInt32(workAmount);
            StringBuilder pi = new StringBuilder("3", digits + 2);


            if (digits > 0)
            {
                pi.Append(".");
                for (int j = 0; j < digits; j += 9)
                {
                    int nineDigits = NineDigitsOfPi.StartingAt(j + 1);
                    int digitCount = Math.Min(digits - j, 9);
                    string ds = string.Format("{0:D9}", nineDigits);
                    pi.Append(ds.Substring(0, digitCount));
                  
                }
            }

            return pi.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TimeSpan span = TimeSpan.Parse( textBoxPerformance.Text);
            textBoxDatabaseResult.Text = SetOperation(labelMethod.Text, span );

            search("CPU");
        }

        private void buttonCPUBoundFor_Click(object sender, EventArgs e)
        {
            labelMethod.Text = "CPU Bound - For";
            //  executeProgressBar();
            var valThreads = Convert.ToInt32(comboBoxNumThreads.Text);
            var valLoops = Convert.ToInt32(comboBoxLoops.Text);
            ParallelFor1(valThreads, valLoops);

         //   ParallelFor.ExcecParallelForPi(valThreads, valLoops, _digits.Value, true); 
         //   _pi.Text = ParallelFor.textboxGeneralPi.Text;
         //   textBoxPerformance.Text = ParallelFor.textTimeGeneralPi.Text;

        }

        private void buttonCpuAPM_Click(object sender, EventArgs e)
        {
            labelMethod.Text = "CPU APM";
           // executeProgressBar();
            CpuAPMExcution();
        }

        private void CpuAPMExcution()
        {
            var sw = Stopwatch.StartNew(); // time the operation
            // The asynchronous method puts the thread id here.
            int threadId;

            // Create an instance of the test class.
            AsyncPiBlocking ad = new AsyncPiBlocking();

            // Create the delegate.
            AsyncMethodCaller caller = new AsyncMethodCaller(ad.TestMethod);

            // Initiate the asychronous call.
            IAsyncResult result = caller.BeginInvoke(0,
                out threadId, null, null);

           Thread.Sleep(0);

            var test = DoWork(_digits.Value);
            _pi.AppendText(test);

            // Wait for the WaitHandle to become signaled.
            result.AsyncWaitHandle.WaitOne();

            // Perform additional processing here.
            // Call EndInvoke to retrieve the results.
            string returnValue = caller.EndInvoke(out threadId, result);

            // Close the wait handle.
            result.AsyncWaitHandle.Close();
         
            textBoxPerformance.Text = Convert.ToString(sw.Elapsed);
            _pi.AppendText($" (The call executed on thread {threadId}). ");
        }

        private void buttonCpuNPTask_Click(object sender, EventArgs e)
        {
            labelMethod.Text = "CPU NP Task";

            var sw = Stopwatch.StartNew(); // time the operation

            var test = DoWork(_digits.Value);
            _pi.AppendText(test);
         
            textBoxPerformance.Text = Convert.ToString(sw.Elapsed);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search("CPU");
        }

        private void search(string boundType)
        {
            if (boundType == "CPU")
            {
                dataGridViewCPU.DataSource = GetOperations(boundType);
                dataGridViewCPU.Columns[0].Visible = false;
                dataGridViewCPU.Columns[1].Width = 160;
                dataGridViewCPU.Columns[2].Width = 162;
                dataGridViewCPU.Columns[3].Width = 162;
            }
            else
            {
                dataGridViewIO.DataSource = GetOperations(boundType);
                dataGridViewIO.Columns[0].Visible = false;
                dataGridViewIO.Columns[1].Width = 160;
                dataGridViewIO.Columns[2].Width = 162;
                dataGridViewIO.Columns[3].Width = 162;
            }

            
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _pi.Clear();
            dataGridViewCPU.DataSource = null;
            labelMethod.Text = "-";
            progressBarStatus.Value = 0;
            textBoxDatabaseResult.Text = "";
            textBoxPerformance.Text = "";
        }


        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValidPath(labelFilePath.Text))
            {
                textBox1.Clear();
                ExecuteNPTaskIO();
            }
            else
            {
                MessageBox.Show("Select File.", "COMP3618");
            }
        }

        private void ExecuteNPTaskIO()
        {
            labelMethodIO.Text = "IO NP Task";
            StringBuilder contents = new StringBuilder();
            string nextLine;
            int lineCounter = 1;

            int size = -1;

            try
            {
                var sw = Stopwatch.StartNew(); // time the operation

                string text = File.ReadAllText(fileSelected);
                size = text.Length;

                using (StreamReader reader = new StreamReader(fileSelected))
                {
                    while ((nextLine = reader.ReadLine()) != null)
                    {
                        contents.AppendFormat("{0}. ", lineCounter);
                        contents.Append(nextLine);
                        contents.AppendLine();
                        lineCounter++;
                        //if (lineCounter > 3)
                        //{
                        //    contents.AppendLine("Only first 3 lines shown.");
                        //    break;
                        //}

                        textBox1.AppendText(nextLine);
                        textBox1.AppendText("");
                    }
                }
                textBoxPerformanceIO.Text = Convert.ToString(sw.Elapsed);
            }
            catch (IOException)
            { }
        }

        private const FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;
        private const int DefaultBufferSize = 4096;

        private  void buttonApmIO_Click(object sender, EventArgs e)
        {
            if (IsValidPath(labelFilePath.Text))
            {
                textBox1.Clear();
                ExecuteAPMIO();
            }
            else
            {
                MessageBox.Show("Select File.", "COMP3618");
            }
        }

        private async void ExecuteAPMIO()
        {
            labelMethodIO.Text = "IO APM";
            textBox1.AppendText("Starting APM I/O...");
            textBox1.AppendText(Environment.NewLine);
            StringBuilder contents = new StringBuilder();
            string nextLine;
            int lineCounter = 1;

            int size = -1;
            //   string file = @"D:\MARSCOMMANDS\enwik8";
            //  string file = "D:\\MARSCOMMANDS\\INPUT\\Rover1.txt";

            var sw = Stopwatch.StartNew(); // time the operation

            using (var stream = new FileStream(fileSelected, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            { 
                using (var reader = new StreamReader(fileSelected))
                {

                    while ((nextLine = await reader.ReadLineAsync()) != null)
                    {
                        contents.AppendFormat("{0}. ", lineCounter);
                        contents.Append(nextLine);
                        contents.AppendLine();
                        lineCounter++;

                        textBox1.AppendText(nextLine);
                        textBox1.AppendText(Environment.NewLine);

                    }

                }
            }

            textBoxPerformanceIO.Text = Convert.ToString(sw.Elapsed);
            textBox1.AppendText("Ending APM I/O...");

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                 fileSelected = openFileDialog1.FileName;
                labelFilePath.Text = fileSelected;
                buttonApmIO.Enabled = true;
                buttonNPTaskIO.Enabled = true;
            }

        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath)) // Test result.
            {
                folderSelected = folderBrowserDialog1.SelectedPath;
                labelSelectedFolder.Text = folderSelected;
              //  buttonApmIO.Enabled = true;
              //  buttonNPTaskIO.Enabled = true;
            }
        }


        private void buttonForIO_Click(object sender, EventArgs e)
        {
           
            if (IsValidPath(labelSelectedFolder.Text))
            {
                textBox1.Clear();
                labelMethodIO.Text = "IO For";
                //   var path = @"C:\Program Files";
                var path = folderSelected;
                ExecuteForIOAsync(path);
            }
            else
            {
                MessageBox.Show("Select Folder.", "COMP3618");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (IsValidPath(labelSelectedFolder.Text))
            {
                textBox1.Clear();
                //  var path = @"C:\Program Files";
                labelMethodIO.Text = "IO NP Task For";
                var path = folderSelected;
                ExecuteForIOAsync(path, false);
            }
            else
            {
                MessageBox.Show("Select Folder.", "COMP3618");
            }
        }

        private  void ExecuteForIOAsync(string dirPath = @"C:\Program Files", bool isAsync = true)
        {
            ParallelIO.TraverseTreeParallelForEach(dirPath, (f) =>
            {
                // Exceptions are no-ops.
                try
                {
                   // var reader = new StreamReader(fileSelected);

                    // Do nothing with the data except read it.
                    byte[] data = File.ReadAllBytes(f);
                }
                catch (FileNotFoundException) { }
                catch (IOException) { }
                catch (UnauthorizedAccessException) { }
                catch (SecurityException) { }
                // Display the filename.
                textBox1.AppendText(f);
            }, true);

            textBoxPerformanceIO.Text = ParallelIO.textTimeGeneral.Text;
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(ParallelIO.textboxGeneral.Text);
        }

        private void buttonSaveIO_Click(object sender, EventArgs e)
        {
            TimeSpan span = TimeSpan.Parse(textBoxPerformanceIO.Text);
            textBoxDatabaseResultIO.Text = SetOperation(labelMethodIO.Text, span);

            search("IO");
        }

        private void buttonResultsIO_Click(object sender, EventArgs e)
        {
            search("IO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsValidPath(labelFilePath.Text))
            {
                textBox1.Clear();

                if (button4.Text == "BW")
                {
                    textBox1.Clear();
                    _workerIO.RunWorkerAsync();
                }
                else
                {
                    _workerIO.CancelAsync();
                    textBox1.AppendText("<<Cancelled>>");
                }


                button4.Text = button4.Text == "BW" ? "Cancel" : "BW";
            }
            else
            {
                MessageBox.Show("Select File.", "COMP3618");
            }
        }

        private void workerIO_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Text = "Cancelled by user - " + lblStatus.Text;
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Done... Calc result: " + e.Result + "%";
            }

            button4.Text = "BW";
        }

        private void workerIO_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void workerIO_DoWork(object sender, DoWorkEventArgs e)
        {
            StringBuilder contents = new StringBuilder();
            string nextLine;
            int lineCounter = 1;

            var sw = Stopwatch.StartNew(); // time the operation

            if (_workerIO.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }

            using (var stream = new FileStream(fileSelected, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            {
                using (var reader = new StreamReader(fileSelected))
                {
                    while ((nextLine = reader.ReadLine()) != null)
                    {
                        contents.AppendFormat("{0}. ", lineCounter);
                        contents.Append(nextLine);
                        contents.AppendLine();
                        lineCounter++;

                        textBox1.AppendText(nextLine);
                        textBox1.AppendText(Environment.NewLine);

                        if (_workerIO.CancellationPending == true)
                        {
                            textBox1.AppendText("<<Cancelled>>");
                            e.Cancel = true;
                            return;
                        }
                        _workerIO.ReportProgress(lineCounter);
                    }
                }
            }

            textBoxPerformanceIO.Text = Convert.ToString(sw.Elapsed);
            textBox1.AppendText("Ending BW I/O...");
        }

        private void buttonCancelIO_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridViewIO.DataSource = null;
            labelMethodIO.Text = "-";

            labelFilePath.Text = "...";
            labelSelectedFolder.Text = "...";
           
            textBoxDatabaseResultIO.Text = "";
            textBoxPerformanceIO.Text = "";
        }

        private void buttonThreadPool_Click(object sender, EventArgs e)
        {
            if (IsValidPath(labelFilePath.Text))
            {
                textBox1.Clear();
                labelMethodIO.Text = "IO Thread Pool";
                ExecuteThreadPool();

                textBox1.Text = textMethod.ToString();
                textBoxPerformanceIO.Text = textTime.Text;
                labelSelectedFolder.Text = "...";
            }
            else
            {
                MessageBox.Show("Select File.", "COMP3618");
            }
        }

        class ThreadParams
        {
            public string sourceFileName { get; set; }
        }

        private void ExecuteThreadPool()
        {
            //custom thread parameter object
            ThreadParams tParams = new ThreadParams();

            //get the file name from command prompt - user input
            tParams.sourceFileName = labelFilePath.Text;
          
            //queue the file copy thread for execution
            ThreadPool.QueueUserWorkItem(new WaitCallback(readFileThreadPool), tParams);
        }

        private static void readFileThreadPool(object tParams)
        {
            //read the custom thread parameter object
            ThreadParams tParamsInner = tParams as ThreadParams;
            string sourceFileName = @tParamsInner.sourceFileName;

            StringBuilder contents = new StringBuilder();
            string nextLine;
            int lineCounter = 1;

            var sw = Stopwatch.StartNew(); // time the operation

            using (var stream = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            {
                using (var reader = new StreamReader(sourceFileName))
                {

                    while ((nextLine = reader.ReadLine()) != null)
                    {
                        contents.AppendFormat("{0}. ", lineCounter);
                        contents.Append(nextLine);
                        contents.AppendLine();
                        lineCounter++;

                        textMethod.Append(nextLine);
                        textMethod.AppendLine();

                    }

                }
            }

            textTime.Text = Convert.ToString(sw.Elapsed);
            textMethod.AppendLine("Ending Tread Pool I/O...");

          
        }

        private bool IsValidPath(string path)
        {
            return path != "...";
        }


    }
}
