using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinalProject.WindowsFormsApp
{
    public partial class FormMain : Form
    {
        private readonly BackgroundWorker _worker = null;

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
          //  dataGridView1.DataSource = GetOperations();
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
            string URL = "http://localhost:54503/api/operation";

            var data = webGetMethod(URL);

            return JsonConvert.DeserializeObject<List<Operation>>(data); ;
        }

        private void callWebServices()
        {
            string postData = "user_id=25689&passwd=123456";
            string URL = "http://localhost:54503/api/operation";
            var data = webPostMethod(postData, URL);
            Console.WriteLine(data);

            var getData = webGetMethod(URL);
            Console.WriteLine(getData);
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

        public string webPostMethod(string postData, string URL)
        {
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent =
                              "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }


    }
}
