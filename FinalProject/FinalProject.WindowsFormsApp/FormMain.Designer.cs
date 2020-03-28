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
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this._pi = new System.Windows.Forms.TextBox();
            this._calcButtom = new System.Windows.Forms.Button();
            this._digits = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCpuAPM = new System.Windows.Forms.Button();
            this.buttonCpuNPTask = new System.Windows.Forms.Button();
            this.buttonCPUBoundFor = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBoxPerformance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDatabaseResult = new System.Windows.Forms.Label();
            this.textBoxDatabaseResult = new System.Windows.Forms.TextBox();
            this.panelCPU = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).BeginInit();
            this.panelCPU.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(708, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 36);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(552, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digits of Pi";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 18);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Working...(0%)";
            this.lblStatus.Visible = false;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarStatus.Location = new System.Drawing.Point(0, 413);
            this.progressBarStatus.MarqueeAnimationSpeed = 1000000;
            this.progressBarStatus.Maximum = 1000;
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(1036, 23);
            this.progressBarStatus.Step = 1000;
            this.progressBarStatus.TabIndex = 9;
            // 
            // _pi
            // 
            this._pi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pi.Location = new System.Drawing.Point(23, 177);
            this._pi.Multiline = true;
            this._pi.Name = "_pi";
            this._pi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._pi.Size = new System.Drawing.Size(380, 221);
            this._pi.TabIndex = 8;
            // 
            // _calcButtom
            // 
            this._calcButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._calcButtom.Location = new System.Drawing.Point(127, 126);
            this._calcButtom.Name = "_calcButtom";
            this._calcButtom.Size = new System.Drawing.Size(74, 36);
            this._calcButtom.TabIndex = 7;
            this._calcButtom.Text = "BW";
            this._calcButtom.UseVisualStyleBackColor = true;
            this._calcButtom.Click += new System.EventHandler(this._calcButtom_Click);
            // 
            // _digits
            // 
            this._digits.Location = new System.Drawing.Point(83, 84);
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
            // buttonCpuAPM
            // 
            this.buttonCpuAPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCpuAPM.Location = new System.Drawing.Point(23, 126);
            this.buttonCpuAPM.Name = "buttonCpuAPM";
            this.buttonCpuAPM.Size = new System.Drawing.Size(75, 36);
            this.buttonCpuAPM.TabIndex = 12;
            this.buttonCpuAPM.Text = "APM";
            this.buttonCpuAPM.UseVisualStyleBackColor = true;
            this.buttonCpuAPM.Click += new System.EventHandler(this.buttonCpuAPM_Click);
            // 
            // buttonCpuNPTask
            // 
            this.buttonCpuNPTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCpuNPTask.Location = new System.Drawing.Point(221, 126);
            this.buttonCpuNPTask.Name = "buttonCpuNPTask";
            this.buttonCpuNPTask.Size = new System.Drawing.Size(75, 36);
            this.buttonCpuNPTask.TabIndex = 14;
            this.buttonCpuNPTask.Text = "NP Task";
            this.buttonCpuNPTask.UseVisualStyleBackColor = true;
            this.buttonCpuNPTask.Click += new System.EventHandler(this.buttonCpuNPTask_Click);
            // 
            // buttonCPUBoundFor
            // 
            this.buttonCPUBoundFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCPUBoundFor.Location = new System.Drawing.Point(328, 126);
            this.buttonCPUBoundFor.Name = "buttonCPUBoundFor";
            this.buttonCPUBoundFor.Size = new System.Drawing.Size(75, 36);
            this.buttonCPUBoundFor.TabIndex = 15;
            this.buttonCPUBoundFor.Text = "For";
            this.buttonCPUBoundFor.UseVisualStyleBackColor = true;
            this.buttonCPUBoundFor.Click += new System.EventHandler(this.buttonCPUBoundFor_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(714, 100);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "00:00";
            this.lblTime.Visible = false;
            // 
            // textBoxPerformance
            // 
            this.textBoxPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPerformance.Location = new System.Drawing.Point(558, 131);
            this.textBoxPerformance.Name = "textBoxPerformance";
            this.textBoxPerformance.ReadOnly = true;
            this.textBoxPerformance.Size = new System.Drawing.Size(110, 20);
            this.textBoxPerformance.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Performance: ";
            // 
            // labelMethod
            // 
            this.labelMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethod.ForeColor = System.Drawing.Color.Navy;
            this.labelMethod.Location = new System.Drawing.Point(119, 14);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(63, 20);
            this.labelMethod.TabIndex = 19;
            this.labelMethod.Text = "Method";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(803, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelDatabaseResult
            // 
            this.labelDatabaseResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseResult.AutoSize = true;
            this.labelDatabaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseResult.Location = new System.Drawing.Point(617, 220);
            this.labelDatabaseResult.Name = "labelDatabaseResult";
            this.labelDatabaseResult.Size = new System.Drawing.Size(182, 20);
            this.labelDatabaseResult.TabIndex = 22;
            this.labelDatabaseResult.Text = "Database Performance: ";
            // 
            // textBoxDatabaseResult
            // 
            this.textBoxDatabaseResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDatabaseResult.Location = new System.Drawing.Point(805, 220);
            this.textBoxDatabaseResult.Name = "textBoxDatabaseResult";
            this.textBoxDatabaseResult.Size = new System.Drawing.Size(138, 20);
            this.textBoxDatabaseResult.TabIndex = 21;
            // 
            // panelCPU
            // 
            this.panelCPU.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCPU.Controls.Add(this.label3);
            this.panelCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCPU.Location = new System.Drawing.Point(0, 0);
            this.panelCPU.Name = "panelCPU";
            this.panelCPU.Size = new System.Drawing.Size(1036, 53);
            this.panelCPU.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU BOUND";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(432, 206);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 36);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelMethod);
            this.panel1.Location = new System.Drawing.Point(435, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 110);
            this.panel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Method: ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 600);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelCPU);
            this.Controls.Add(this.labelDatabaseResult);
            this.Controls.Add(this.textBoxDatabaseResult);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPerformance);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.buttonCPUBoundFor);
            this.Controls.Add(this.buttonCpuNPTask);
            this.Controls.Add(this.buttonCpuAPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this._pi);
            this.Controls.Add(this._calcButtom);
            this.Controls.Add(this._digits);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Final Project - COMP3618";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).EndInit();
            this.panelCPU.ResumeLayout(false);
            this.panelCPU.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.TextBox _pi;
        private System.Windows.Forms.Button _calcButtom;
        private System.Windows.Forms.NumericUpDown _digits;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCpuAPM;
        private System.Windows.Forms.Button buttonCpuNPTask;
        private System.Windows.Forms.Button buttonCPUBoundFor;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBoxPerformance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDatabaseResult;
        private System.Windows.Forms.TextBox textBoxDatabaseResult;
        private System.Windows.Forms.Panel panelCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

