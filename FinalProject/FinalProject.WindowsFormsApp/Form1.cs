using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Domain.Model;
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
            dataGridView1.DataSource = GetOperations();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            lblStatus.ForeColor = Color.Black;
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

        private void SetOperation(string name, double executionTime)
        {
            string postData = $"name={name}&ExecutionTime={executionTime}";
         

            var dat = new Operation() { Name = name, ExecutionTime = executionTime };
            var test = CreateProductAsync(dat);

            var a = test;
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

        static async Task<Uri> CreateProductAsync(Operation operation)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                baseUrl, operation);
             //   "/api/opertion", operation);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SetOperation("Method A", 1.3);
        }
    }
}
