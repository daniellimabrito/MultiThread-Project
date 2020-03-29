using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Domain.Model;
using FinalProject.Services;
using Newtonsoft.Json;

namespace FinalProject.WindowsFormsApp
{
    public partial class FormMain : Form
    {
        private readonly BackgroundWorker _worker = null;
        static HttpClient client = new HttpClient();

        const string baseUrl = "http://localhost:54503/api/operation";

        public FormMain()
        {
            InitializeComponent();
            _worker = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
            _worker.DoWork += worker_DoWork;
            _worker.ProgressChanged += worker_ProgressChanged;
            _worker.RunWorkerCompleted += worker_RunWorkerCompleted;
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

        private List<Operation> GetOperations()
        {
            string URL = baseUrl;

            var data = webGetMethod(URL);

            return JsonConvert.DeserializeObject<List<Operation>>(data); ;
        }

        private void SetOperation(string name, TimeSpan executionTime)
        {
            var sw = Stopwatch.StartNew(); // time the operation
            string postData = $"name={name}&ExecutionTime={executionTime}";
         
            var dat = new Operation() { Name = name, ExecutionTime = executionTime };
            var ret =  CreateProductAsync(dat);
  
            textBoxDatabaseResult.Text = Convert.ToString(sw.Elapsed);
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



        private void ParallelFor(int numThreads, int loops)
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
            SetOperation(labelMethod.Text, span );

            search();
        }

        private void buttonCPUBoundFor_Click(object sender, EventArgs e)
        {
            labelMethod.Text = "CPU Bound - For";
            //  executeProgressBar();
            var valThreads = Convert.ToInt32(comboBoxNumThreads.Text);
            var valLoops = Convert.ToInt32(comboBoxLoops.Text);
            ParallelFor(valThreads, valLoops);
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
            search();
        }

        private void search()
        {
            dataGridView1.DataSource = GetOperations();
            formatGrid();
        }

        private void formatGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 162;
            dataGridView1.Columns[3].Width = 162;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _pi.Clear();
            dataGridView1.DataSource = null;
            labelMethod.Text = "-";
            progressBarStatus.Value = 0;
            textBoxDatabaseResult.Text = "";
            textBoxPerformance.Text = "";

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxNumThreads.SelectedText = "8";
            comboBoxLoops.SelectedText = "4";

        }
    }
}
