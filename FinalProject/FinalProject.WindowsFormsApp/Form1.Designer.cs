namespace FinalProject.WindowsFormsApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this._pi = new System.Windows.Forms.TextBox();
            this._calcButtom = new System.Windows.Forms.Button();
            this._digits = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digits of Pi";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(19, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 18);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Working...(0%)";
            this.lblStatus.Visible = false;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarStatus.Location = new System.Drawing.Point(0, 577);
            this.progressBarStatus.MarqueeAnimationSpeed = 1000000;
            this.progressBarStatus.Maximum = 1000;
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(1036, 23);
            this.progressBarStatus.Step = 1000;
            this.progressBarStatus.TabIndex = 9;
            // 
            // _pi
            // 
            this._pi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pi.Location = new System.Drawing.Point(22, 130);
            this._pi.Multiline = true;
            this._pi.Name = "_pi";
            this._pi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._pi.Size = new System.Drawing.Size(380, 221);
            this._pi.TabIndex = 8;
            // 
            // _calcButtom
            // 
            this._calcButtom.Location = new System.Drawing.Point(126, 75);
            this._calcButtom.Name = "_calcButtom";
            this._calcButtom.Size = new System.Drawing.Size(74, 36);
            this._calcButtom.TabIndex = 7;
            this._calcButtom.Text = "BW";
            this._calcButtom.UseVisualStyleBackColor = true;
            this._calcButtom.Click += new System.EventHandler(this._calcButtom_Click);
            // 
            // _digits
            // 
            this._digits.Location = new System.Drawing.Point(82, 33);
            this._digits.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._digits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._digits.Name = "_digits";
            this._digits.Size = new System.Drawing.Size(86, 20);
            this._digits.TabIndex = 6;
            this._digits.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "APM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "BW";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "NP Task";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 15;
            this.button5.Text = "For";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 600);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this._pi);
            this.Controls.Add(this._calcButtom);
            this.Controls.Add(this._digits);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Final Project - COMP3618";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.TextBox _pi;
        private System.Windows.Forms.Button _calcButtom;
        private System.Windows.Forms.NumericUpDown _digits;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

