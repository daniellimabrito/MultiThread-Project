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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewCPU = new System.Windows.Forms.DataGridView();
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNumThreads = new System.Windows.Forms.ComboBox();
            this.comboBoxLoops = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fswCheckForNewFiles = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonNPTaskIO = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonApmIO = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonForIO = new System.Windows.Forms.Button();
            this.buttonResultsIO = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDatabaseResultIO = new System.Windows.Forms.TextBox();
            this.buttonCancelIO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPerformanceIO = new System.Windows.Forms.TextBox();
            this.dataGridViewIO = new System.Windows.Forms.DataGridView();
            this.buttonSaveIO = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMethodIO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonThreadPool = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelSelectedFolder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).BeginInit();
            this.panelCPU.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckForNewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIO)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(897, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 36);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewCPU
            // 
            this.dataGridViewCPU.AllowUserToAddRows = false;
            this.dataGridViewCPU.AllowUserToDeleteRows = false;
            this.dataGridViewCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCPU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCPU.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCPU.Location = new System.Drawing.Point(621, 248);
            this.dataGridViewCPU.Name = "dataGridViewCPU";
            this.dataGridViewCPU.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCPU.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCPU.Size = new System.Drawing.Size(552, 141);
            this.dataGridViewCPU.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digits of Pi";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 60);
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
            this.progressBarStatus.Location = new System.Drawing.Point(0, 405);
            this.progressBarStatus.MarqueeAnimationSpeed = 1000000;
            this.progressBarStatus.Maximum = 1000;
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(1225, 23);
            this.progressBarStatus.Step = 1000;
            this.progressBarStatus.TabIndex = 9;
            // 
            // _pi
            // 
            this._pi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pi.Location = new System.Drawing.Point(22, 224);
            this._pi.Multiline = true;
            this._pi.Name = "_pi";
            this._pi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._pi.Size = new System.Drawing.Size(380, 165);
            this._pi.TabIndex = 8;
            // 
            // _calcButtom
            // 
            this._calcButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._calcButtom.Location = new System.Drawing.Point(126, 159);
            this._calcButtom.Name = "_calcButtom";
            this._calcButtom.Size = new System.Drawing.Size(74, 36);
            this._calcButtom.TabIndex = 7;
            this._calcButtom.Text = "BW";
            this._calcButtom.UseVisualStyleBackColor = true;
            this._calcButtom.Click += new System.EventHandler(this._calcButtom_Click);
            // 
            // _digits
            // 
            this._digits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._digits.Location = new System.Drawing.Point(83, 88);
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
            this.buttonCpuAPM.Location = new System.Drawing.Point(22, 159);
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
            this.buttonCpuNPTask.Location = new System.Drawing.Point(220, 159);
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
            this.buttonCPUBoundFor.Location = new System.Drawing.Point(327, 159);
            this.buttonCPUBoundFor.Name = "buttonCPUBoundFor";
            this.buttonCPUBoundFor.Size = new System.Drawing.Size(75, 36);
            this.buttonCPUBoundFor.TabIndex = 15;
            this.buttonCPUBoundFor.Text = "For";
            this.buttonCPUBoundFor.UseVisualStyleBackColor = true;
            this.buttonCPUBoundFor.Click += new System.EventHandler(this.buttonCPUBoundFor_Click);
            // 
            // textBoxPerformance
            // 
            this.textBoxPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPerformance.Location = new System.Drawing.Point(747, 131);
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
            this.label2.Location = new System.Drawing.Point(633, 129);
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
            this.labelMethod.Location = new System.Drawing.Point(115, 14);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(63, 20);
            this.labelMethod.TabIndex = 19;
            this.labelMethod.Text = "Method";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(992, 126);
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
            this.labelDatabaseResult.Location = new System.Drawing.Point(806, 220);
            this.labelDatabaseResult.Name = "labelDatabaseResult";
            this.labelDatabaseResult.Size = new System.Drawing.Size(182, 20);
            this.labelDatabaseResult.TabIndex = 22;
            this.labelDatabaseResult.Text = "Database Performance: ";
            // 
            // textBoxDatabaseResult
            // 
            this.textBoxDatabaseResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDatabaseResult.Location = new System.Drawing.Point(994, 220);
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
            this.panelCPU.Size = new System.Drawing.Size(1225, 53);
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
            this.buttonSearch.Location = new System.Drawing.Point(621, 206);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 36);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Results";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelMethod);
            this.panel1.Location = new System.Drawing.Point(624, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 110);
            this.panel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Method: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Threads:";
            // 
            // comboBoxNumThreads
            // 
            this.comboBoxNumThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNumThreads.FormattingEnabled = true;
            this.comboBoxNumThreads.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16"});
            this.comboBoxNumThreads.Location = new System.Drawing.Point(273, 85);
            this.comboBoxNumThreads.Name = "comboBoxNumThreads";
            this.comboBoxNumThreads.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumThreads.TabIndex = 27;
            // 
            // comboBoxLoops
            // 
            this.comboBoxLoops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLoops.FormattingEnabled = true;
            this.comboBoxLoops.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxLoops.Location = new System.Drawing.Point(273, 112);
            this.comboBoxLoops.Name = "comboBoxLoops";
            this.comboBoxLoops.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoops.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Loops:";
            // 
            // fswCheckForNewFiles
            // 
            this.fswCheckForNewFiles.EnableRaisingEvents = true;
            this.fswCheckForNewFiles.NotifyFilter = System.IO.NotifyFilters.LastAccess;
            this.fswCheckForNewFiles.Path = "D:\\MARSCOMMANDS\\INPUT";
            this.fswCheckForNewFiles.SynchronizingObject = this;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // buttonNPTaskIO
            // 
            this.buttonNPTaskIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNPTaskIO.Location = new System.Drawing.Point(307, 59);
            this.buttonNPTaskIO.Name = "buttonNPTaskIO";
            this.buttonNPTaskIO.Size = new System.Drawing.Size(75, 36);
            this.buttonNPTaskIO.TabIndex = 35;
            this.buttonNPTaskIO.Text = "NP Task";
            this.buttonNPTaskIO.UseVisualStyleBackColor = true;
            this.buttonNPTaskIO.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(111, 526);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(16, 13);
            this.labelFilePath.TabIndex = 36;
            this.labelFilePath.Text = "...";
            // 
            // buttonApmIO
            // 
            this.buttonApmIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApmIO.Location = new System.Drawing.Point(208, 59);
            this.buttonApmIO.Name = "buttonApmIO";
            this.buttonApmIO.Size = new System.Drawing.Size(75, 36);
            this.buttonApmIO.TabIndex = 37;
            this.buttonApmIO.Text = "APM";
            this.buttonApmIO.UseVisualStyleBackColor = true;
            this.buttonApmIO.Click += new System.EventHandler(this.buttonApmIO_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOpenFile.Location = new System.Drawing.Point(23, 516);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 32);
            this.buttonOpenFile.TabIndex = 38;
            this.buttonOpenFile.Text = "Select File...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonForIO
            // 
            this.buttonForIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForIO.Location = new System.Drawing.Point(11, 57);
            this.buttonForIO.Name = "buttonForIO";
            this.buttonForIO.Size = new System.Drawing.Size(75, 36);
            this.buttonForIO.TabIndex = 39;
            this.buttonForIO.Text = "For";
            this.buttonForIO.UseVisualStyleBackColor = true;
            this.buttonForIO.Click += new System.EventHandler(this.buttonForIO_Click);
            // 
            // buttonResultsIO
            // 
            this.buttonResultsIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResultsIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultsIO.Location = new System.Drawing.Point(621, 638);
            this.buttonResultsIO.Name = "buttonResultsIO";
            this.buttonResultsIO.Size = new System.Drawing.Size(75, 36);
            this.buttonResultsIO.TabIndex = 48;
            this.buttonResultsIO.Text = "Results";
            this.buttonResultsIO.UseVisualStyleBackColor = true;
            this.buttonResultsIO.Click += new System.EventHandler(this.buttonResultsIO_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(806, 654);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Database Performance: ";
            // 
            // textBoxDatabaseResultIO
            // 
            this.textBoxDatabaseResultIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDatabaseResultIO.Location = new System.Drawing.Point(994, 654);
            this.textBoxDatabaseResultIO.Name = "textBoxDatabaseResultIO";
            this.textBoxDatabaseResultIO.Size = new System.Drawing.Size(138, 20);
            this.textBoxDatabaseResultIO.TabIndex = 46;
            // 
            // buttonCancelIO
            // 
            this.buttonCancelIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelIO.Location = new System.Drawing.Point(992, 548);
            this.buttonCancelIO.Name = "buttonCancelIO";
            this.buttonCancelIO.Size = new System.Drawing.Size(75, 36);
            this.buttonCancelIO.TabIndex = 45;
            this.buttonCancelIO.Text = "Cancel";
            this.buttonCancelIO.UseVisualStyleBackColor = true;
            this.buttonCancelIO.Click += new System.EventHandler(this.buttonCancelIO_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Performance: ";
            // 
            // textBoxPerformanceIO
            // 
            this.textBoxPerformanceIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPerformanceIO.Location = new System.Drawing.Point(747, 553);
            this.textBoxPerformanceIO.Name = "textBoxPerformanceIO";
            this.textBoxPerformanceIO.ReadOnly = true;
            this.textBoxPerformanceIO.Size = new System.Drawing.Size(110, 20);
            this.textBoxPerformanceIO.TabIndex = 43;
            // 
            // dataGridViewIO
            // 
            this.dataGridViewIO.AllowUserToAddRows = false;
            this.dataGridViewIO.AllowUserToDeleteRows = false;
            this.dataGridViewIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIO.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewIO.Location = new System.Drawing.Point(621, 680);
            this.dataGridViewIO.Name = "dataGridViewIO";
            this.dataGridViewIO.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIO.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewIO.Size = new System.Drawing.Size(552, 232);
            this.dataGridViewIO.TabIndex = 42;
            // 
            // buttonSaveIO
            // 
            this.buttonSaveIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveIO.Location = new System.Drawing.Point(897, 548);
            this.buttonSaveIO.Name = "buttonSaveIO";
            this.buttonSaveIO.Size = new System.Drawing.Size(75, 36);
            this.buttonSaveIO.TabIndex = 41;
            this.buttonSaveIO.Text = "Save";
            this.buttonSaveIO.UseVisualStyleBackColor = true;
            this.buttonSaveIO.Click += new System.EventHandler(this.buttonSaveIO_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Method: ";
            // 
            // labelMethodIO
            // 
            this.labelMethodIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMethodIO.AutoSize = true;
            this.labelMethodIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethodIO.ForeColor = System.Drawing.Color.Navy;
            this.labelMethodIO.Location = new System.Drawing.Point(115, 14);
            this.labelMethodIO.Name = "labelMethodIO";
            this.labelMethodIO.Size = new System.Drawing.Size(63, 20);
            this.labelMethodIO.TabIndex = 19;
            this.labelMethodIO.Text = "Method";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelMethodIO);
            this.panel2.Location = new System.Drawing.Point(624, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 110);
            this.panel2.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(102, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 50;
            this.button3.Text = "NP Task For";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(23, 726);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(380, 186);
            this.textBox1.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(114, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 52;
            this.button4.Text = "BW";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(16, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 36);
            this.label10.TabIndex = 0;
            this.label10.Text = "IO BOUND";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 53);
            this.panel3.TabIndex = 53;
            // 
            // buttonThreadPool
            // 
            this.buttonThreadPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThreadPool.Location = new System.Drawing.Point(10, 59);
            this.buttonThreadPool.Name = "buttonThreadPool";
            this.buttonThreadPool.Size = new System.Drawing.Size(75, 36);
            this.buttonThreadPool.TabIndex = 54;
            this.buttonThreadPool.Text = "Thread Pool";
            this.buttonThreadPool.UseVisualStyleBackColor = true;
            this.buttonThreadPool.Click += new System.EventHandler(this.buttonThreadPool_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFolder.Location = new System.Drawing.Point(11, 19);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(81, 32);
            this.buttonFolder.TabIndex = 55;
            this.buttonFolder.Text = "Select Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // labelSelectedFolder
            // 
            this.labelSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedFolder.AutoSize = true;
            this.labelSelectedFolder.Location = new System.Drawing.Point(99, 29);
            this.labelSelectedFolder.Name = "labelSelectedFolder";
            this.labelSelectedFolder.Size = new System.Drawing.Size(16, 13);
            this.labelSelectedFolder.TabIndex = 56;
            this.labelSelectedFolder.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonThreadPool);
            this.groupBox1.Controls.Add(this.buttonApmIO);
            this.groupBox1.Controls.Add(this.buttonNPTaskIO);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 104);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read File Content";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelSelectedFolder);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonFolder);
            this.groupBox2.Controls.Add(this.buttonForIO);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 604);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 105);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Files in Folder";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 940);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonResultsIO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDatabaseResultIO);
            this.Controls.Add(this.buttonCancelIO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPerformanceIO);
            this.Controls.Add(this.dataGridViewIO);
            this.Controls.Add(this.buttonSaveIO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.comboBoxLoops);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxNumThreads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelCPU);
            this.Controls.Add(this.labelDatabaseResult);
            this.Controls.Add(this.textBoxDatabaseResult);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPerformance);
            this.Controls.Add(this.buttonCPUBoundFor);
            this.Controls.Add(this.buttonCpuNPTask);
            this.Controls.Add(this.buttonCpuAPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this._pi);
            this.Controls.Add(this._calcButtom);
            this.Controls.Add(this._digits);
            this.Controls.Add(this.dataGridViewCPU);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Project - COMP3618";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).EndInit();
            this.panelCPU.ResumeLayout(false);
            this.panelCPU.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckForNewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIO)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewCPU;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNumThreads;
        private System.Windows.Forms.ComboBox comboBoxLoops;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fswCheckForNewFiles;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonNPTaskIO;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonApmIO;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonForIO;
        private System.Windows.Forms.Button buttonResultsIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDatabaseResultIO;
        private System.Windows.Forms.Button buttonCancelIO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPerformanceIO;
        private System.Windows.Forms.DataGridView dataGridViewIO;
        private System.Windows.Forms.Button buttonSaveIO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMethodIO;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonThreadPool;
        private System.Windows.Forms.Label labelSelectedFolder;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

