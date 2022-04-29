namespace RabinsAlgorithm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.GetFileAsBytesButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.FermatsRadioButton = new System.Windows.Forms.RadioButton();
            this.MillersRabbinsRadioButton = new System.Windows.Forms.RadioButton();
            this.ModsLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.ApplyQAndPButton = new System.Windows.Forms.Button();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.QLabel = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.ApplyBButton = new System.Windows.Forms.Button();
            this.SympleCycleRadioButton = new System.Windows.Forms.RadioButton();
            this.RabinsLabel = new System.Windows.Forms.Label();
            this.StartPrimalTestButton = new System.Windows.Forms.Button();
            this.InputPQLabel = new System.Windows.Forms.Label();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.ErrorsLabel2 = new System.Windows.Forms.Label();
            this.ErrorsLabel3 = new System.Windows.Forms.Label();
            this.pError = new System.Windows.Forms.Label();
            this.qError = new System.Windows.Forms.Label();
            this.bError = new System.Windows.Forms.Label();
            this.InputBLabel = new System.Windows.Forms.Label();
            this.GetFileAsASCIIButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PrimalTestResultLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SystemLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.SaveEncryptedButton = new System.Windows.Forms.Button();
            this.SaveDecryptedButton = new System.Windows.Forms.Button();
            this.ClearFileFieldsButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SaveFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SaveFilePathLabel = new System.Windows.Forms.Label();
            this.SaveEncryptedAsTxt = new System.Windows.Forms.Button();
            this.RasdAsBytesEncryptedFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilePathLabel.Location = new System.Drawing.Point(27, 87);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(136, 41);
            this.FilePathLabel.TabIndex = 0;
            this.FilePathLabel.Text = "File Path:";
            // 
            // GetFileAsBytesButton
            // 
            this.GetFileAsBytesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetFileAsBytesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetFileAsBytesButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetFileAsBytesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetFileAsBytesButton.Location = new System.Drawing.Point(606, 92);
            this.GetFileAsBytesButton.Name = "GetFileAsBytesButton";
            this.GetFileAsBytesButton.Size = new System.Drawing.Size(266, 36);
            this.GetFileAsBytesButton.TabIndex = 3;
            this.GetFileAsBytesButton.Text = "Read As Bytes Normal File";
            this.GetFileAsBytesButton.UseVisualStyleBackColor = false;
            this.GetFileAsBytesButton.Click += new System.EventHandler(this.GetFileAsBytesButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathTextBox.Location = new System.Drawing.Point(169, 92);
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(431, 36);
            this.PathTextBox.TabIndex = 4;
            // 
            // FermatsRadioButton
            // 
            this.FermatsRadioButton.AutoSize = true;
            this.FermatsRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FermatsRadioButton.Location = new System.Drawing.Point(357, 201);
            this.FermatsRadioButton.Name = "FermatsRadioButton";
            this.FermatsRadioButton.Size = new System.Drawing.Size(201, 32);
            this.FermatsRadioButton.TabIndex = 5;
            this.FermatsRadioButton.TabStop = true;
            this.FermatsRadioButton.Text = "Fermat\'s Algorithm";
            this.FermatsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MillersRabbinsRadioButton
            // 
            this.MillersRabbinsRadioButton.AutoSize = true;
            this.MillersRabbinsRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MillersRabbinsRadioButton.Location = new System.Drawing.Point(357, 239);
            this.MillersRabbinsRadioButton.Name = "MillersRabbinsRadioButton";
            this.MillersRabbinsRadioButton.Size = new System.Drawing.Size(283, 32);
            this.MillersRabbinsRadioButton.TabIndex = 6;
            this.MillersRabbinsRadioButton.TabStop = true;
            this.MillersRabbinsRadioButton.Text = "Miller\'s - Rabbin\'s Algorithm";
            this.MillersRabbinsRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModsLabel
            // 
            this.ModsLabel.AutoSize = true;
            this.ModsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModsLabel.Location = new System.Drawing.Point(346, 167);
            this.ModsLabel.Name = "ModsLabel";
            this.ModsLabel.Size = new System.Drawing.Size(303, 31);
            this.ModsLabel.TabIndex = 7;
            this.ModsLabel.Text = "Primal p And q Check Mods:";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PLabel.Location = new System.Drawing.Point(25, 230);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(73, 41);
            this.PLabel.TabIndex = 8;
            this.PLabel.Text = "p = ";
            // 
            // PTextBox
            // 
            this.PTextBox.Enabled = false;
            this.PTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PTextBox.Location = new System.Drawing.Point(94, 235);
            this.PTextBox.Multiline = true;
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(206, 36);
            this.PTextBox.TabIndex = 9;
            // 
            // ApplyQAndPButton
            // 
            this.ApplyQAndPButton.BackColor = System.Drawing.Color.RosyBrown;
            this.ApplyQAndPButton.Enabled = false;
            this.ApplyQAndPButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyQAndPButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyQAndPButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyQAndPButton.Location = new System.Drawing.Point(130, 351);
            this.ApplyQAndPButton.Name = "ApplyQAndPButton";
            this.ApplyQAndPButton.Size = new System.Drawing.Size(132, 36);
            this.ApplyQAndPButton.TabIndex = 10;
            this.ApplyQAndPButton.Text = "Apply";
            this.ApplyQAndPButton.UseVisualStyleBackColor = false;
            this.ApplyQAndPButton.Click += new System.EventHandler(this.ApplyQAndPButton_Click);
            // 
            // QTextBox
            // 
            this.QTextBox.Enabled = false;
            this.QTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QTextBox.Location = new System.Drawing.Point(94, 299);
            this.QTextBox.Multiline = true;
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(206, 36);
            this.QTextBox.TabIndex = 12;
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QLabel.Location = new System.Drawing.Point(26, 292);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(73, 41);
            this.QLabel.TabIndex = 11;
            this.QLabel.Text = "q = ";
            // 
            // BTextBox
            // 
            this.BTextBox.Enabled = false;
            this.BTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTextBox.Location = new System.Drawing.Point(94, 467);
            this.BTextBox.Multiline = true;
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(206, 36);
            this.BTextBox.TabIndex = 14;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BLabel.Location = new System.Drawing.Point(25, 462);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(73, 41);
            this.BLabel.TabIndex = 13;
            this.BLabel.Text = "b = ";
            // 
            // ApplyBButton
            // 
            this.ApplyBButton.BackColor = System.Drawing.Color.YellowGreen;
            this.ApplyBButton.Enabled = false;
            this.ApplyBButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ApplyBButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyBButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApplyBButton.Location = new System.Drawing.Point(130, 520);
            this.ApplyBButton.Name = "ApplyBButton";
            this.ApplyBButton.Size = new System.Drawing.Size(132, 36);
            this.ApplyBButton.TabIndex = 15;
            this.ApplyBButton.Text = "Apply";
            this.ApplyBButton.UseVisualStyleBackColor = false;
            this.ApplyBButton.Click += new System.EventHandler(this.ApplyBButton_Click);
            // 
            // SympleCycleRadioButton
            // 
            this.SympleCycleRadioButton.AutoSize = true;
            this.SympleCycleRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SympleCycleRadioButton.Location = new System.Drawing.Point(357, 277);
            this.SympleCycleRadioButton.Name = "SympleCycleRadioButton";
            this.SympleCycleRadioButton.Size = new System.Drawing.Size(242, 32);
            this.SympleCycleRadioButton.TabIndex = 16;
            this.SympleCycleRadioButton.TabStop = true;
            this.SympleCycleRadioButton.Text = "Symple Cycle Algorithm";
            this.SympleCycleRadioButton.UseVisualStyleBackColor = true;
            // 
            // RabinsLabel
            // 
            this.RabinsLabel.AutoSize = true;
            this.RabinsLabel.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RabinsLabel.Location = new System.Drawing.Point(503, 21);
            this.RabinsLabel.Name = "RabinsLabel";
            this.RabinsLabel.Size = new System.Drawing.Size(327, 42);
            this.RabinsLabel.TabIndex = 17;
            this.RabinsLabel.Text = "Rabin\'s Cryptosystem";
            // 
            // StartPrimalTestButton
            // 
            this.StartPrimalTestButton.BackColor = System.Drawing.Color.Plum;
            this.StartPrimalTestButton.Enabled = false;
            this.StartPrimalTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartPrimalTestButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartPrimalTestButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartPrimalTestButton.Location = new System.Drawing.Point(367, 328);
            this.StartPrimalTestButton.Name = "StartPrimalTestButton";
            this.StartPrimalTestButton.Size = new System.Drawing.Size(222, 36);
            this.StartPrimalTestButton.TabIndex = 18;
            this.StartPrimalTestButton.Text = "Start Primal Test";
            this.StartPrimalTestButton.UseVisualStyleBackColor = false;
            this.StartPrimalTestButton.Click += new System.EventHandler(this.StartPrimalTestButton_Click);
            // 
            // InputPQLabel
            // 
            this.InputPQLabel.AutoSize = true;
            this.InputPQLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPQLabel.Location = new System.Drawing.Point(121, 167);
            this.InputPQLabel.Name = "InputPQLabel";
            this.InputPQLabel.Size = new System.Drawing.Size(156, 31);
            this.InputPQLabel.TabIndex = 19;
            this.InputPQLabel.Text = "Input p And q";
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Black;
            this.ErrorLabel1.Location = new System.Drawing.Point(94, 213);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(50, 20);
            this.ErrorLabel1.TabIndex = 20;
            this.ErrorLabel1.Text = "Errors:";
            // 
            // ErrorsLabel2
            // 
            this.ErrorsLabel2.AutoSize = true;
            this.ErrorsLabel2.Location = new System.Drawing.Point(94, 277);
            this.ErrorsLabel2.Name = "ErrorsLabel2";
            this.ErrorsLabel2.Size = new System.Drawing.Size(50, 20);
            this.ErrorsLabel2.TabIndex = 21;
            this.ErrorsLabel2.Text = "Errors:";
            // 
            // ErrorsLabel3
            // 
            this.ErrorsLabel3.AutoSize = true;
            this.ErrorsLabel3.Location = new System.Drawing.Point(94, 444);
            this.ErrorsLabel3.Name = "ErrorsLabel3";
            this.ErrorsLabel3.Size = new System.Drawing.Size(50, 20);
            this.ErrorsLabel3.TabIndex = 22;
            this.ErrorsLabel3.Text = "Errors:";
            // 
            // pError
            // 
            this.pError.AutoSize = true;
            this.pError.Location = new System.Drawing.Point(141, 212);
            this.pError.Name = "pError";
            this.pError.Size = new System.Drawing.Size(48, 20);
            this.pError.TabIndex = 23;
            this.pError.Text = "None.";
            // 
            // qError
            // 
            this.qError.AutoSize = true;
            this.qError.Location = new System.Drawing.Point(141, 277);
            this.qError.Name = "qError";
            this.qError.Size = new System.Drawing.Size(48, 20);
            this.qError.TabIndex = 24;
            this.qError.Text = "None.";
            // 
            // bError
            // 
            this.bError.AutoSize = true;
            this.bError.Location = new System.Drawing.Point(141, 444);
            this.bError.Name = "bError";
            this.bError.Size = new System.Drawing.Size(48, 20);
            this.bError.TabIndex = 25;
            this.bError.Text = "None.";
            // 
            // InputBLabel
            // 
            this.InputBLabel.AutoSize = true;
            this.InputBLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputBLabel.Location = new System.Drawing.Point(154, 403);
            this.InputBLabel.Name = "InputBLabel";
            this.InputBLabel.Size = new System.Drawing.Size(88, 31);
            this.InputBLabel.TabIndex = 26;
            this.InputBLabel.Text = "Input b";
            // 
            // GetFileAsASCIIButton
            // 
            this.GetFileAsASCIIButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GetFileAsASCIIButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetFileAsASCIIButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetFileAsASCIIButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetFileAsASCIIButton.Location = new System.Drawing.Point(1161, 92);
            this.GetFileAsASCIIButton.Name = "GetFileAsASCIIButton";
            this.GetFileAsASCIIButton.Size = new System.Drawing.Size(160, 36);
            this.GetFileAsASCIIButton.TabIndex = 27;
            this.GetFileAsASCIIButton.Text = "Read As ASCII";
            this.GetFileAsASCIIButton.UseVisualStyleBackColor = false;
            this.GetFileAsASCIIButton.Click += new System.EventHandler(this.GetFileAsASCIIButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.HotPink;
            this.ContinueButton.Enabled = false;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContinueButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContinueButton.Location = new System.Drawing.Point(367, 545);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(222, 36);
            this.ContinueButton.TabIndex = 28;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(357, 383);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(198, 31);
            this.ResultLabel.TabIndex = 29;
            this.ResultLabel.Text = "Primal Test Result:";
            // 
            // PrimalTestResultLabel
            // 
            this.PrimalTestResultLabel.AutoSize = true;
            this.PrimalTestResultLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimalTestResultLabel.Location = new System.Drawing.Point(357, 414);
            this.PrimalTestResultLabel.Name = "PrimalTestResultLabel";
            this.PrimalTestResultLabel.Size = new System.Drawing.Size(74, 31);
            this.PrimalTestResultLabel.TabIndex = 30;
            this.PrimalTestResultLabel.Text = "None.";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.Gray;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearAllButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearAllButton.Location = new System.Drawing.Point(367, 503);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(222, 36);
            this.ClearAllButton.TabIndex = 31;
            this.ClearAllButton.Text = "Clear All Input Fields";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // SystemLabel
            // 
            this.SystemLabel.AutoSize = true;
            this.SystemLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SystemLabel.Location = new System.Drawing.Point(398, 462);
            this.SystemLabel.Name = "SystemLabel";
            this.SystemLabel.Size = new System.Drawing.Size(170, 31);
            this.SystemLabel.TabIndex = 32;
            this.SystemLabel.Text = "System Buttons";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(728, 212);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextBox.Size = new System.Drawing.Size(369, 368);
            this.InputTextBox.TabIndex = 33;
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputFileLabel.Location = new System.Drawing.Point(846, 167);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(137, 31);
            this.InputFileLabel.TabIndex = 34;
            this.InputFileLabel.Text = "Input Codes";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(1103, 213);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(328, 368);
            this.OutputTextBox.TabIndex = 35;
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFileLabel.Location = new System.Drawing.Point(1186, 167);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(156, 31);
            this.OutputFileLabel.TabIndex = 36;
            this.OutputFileLabel.Text = "Output Codes";
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EncryptButton.Enabled = false;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EncryptButton.Location = new System.Drawing.Point(1455, 213);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(152, 36);
            this.EncryptButton.TabIndex = 37;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // SaveEncryptedButton
            // 
            this.SaveEncryptedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SaveEncryptedButton.Enabled = false;
            this.SaveEncryptedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveEncryptedButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEncryptedButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveEncryptedButton.Location = new System.Drawing.Point(1455, 316);
            this.SaveEncryptedButton.Name = "SaveEncryptedButton";
            this.SaveEncryptedButton.Size = new System.Drawing.Size(152, 60);
            this.SaveEncryptedButton.TabIndex = 38;
            this.SaveEncryptedButton.Text = "Save Encrypted As Stream";
            this.SaveEncryptedButton.UseVisualStyleBackColor = false;
            this.SaveEncryptedButton.Click += new System.EventHandler(this.SaveEncryptedButton_Click);
            // 
            // SaveDecryptedButton
            // 
            this.SaveDecryptedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveDecryptedButton.Enabled = false;
            this.SaveDecryptedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveDecryptedButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveDecryptedButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveDecryptedButton.Location = new System.Drawing.Point(1455, 462);
            this.SaveDecryptedButton.Name = "SaveDecryptedButton";
            this.SaveDecryptedButton.Size = new System.Drawing.Size(152, 63);
            this.SaveDecryptedButton.TabIndex = 39;
            this.SaveDecryptedButton.Text = "Save Decrypted";
            this.SaveDecryptedButton.UseVisualStyleBackColor = false;
            this.SaveDecryptedButton.Click += new System.EventHandler(this.SaveDecryptedButton_Click);
            // 
            // ClearFileFieldsButton
            // 
            this.ClearFileFieldsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClearFileFieldsButton.Enabled = false;
            this.ClearFileFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearFileFieldsButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearFileFieldsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearFileFieldsButton.Location = new System.Drawing.Point(1455, 538);
            this.ClearFileFieldsButton.Name = "ClearFileFieldsButton";
            this.ClearFileFieldsButton.Size = new System.Drawing.Size(152, 63);
            this.ClearFileFieldsButton.TabIndex = 40;
            this.ClearFileFieldsButton.Text = "Clear File Fields";
            this.ClearFileFieldsButton.UseVisualStyleBackColor = false;
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DecryptButton.Enabled = false;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecryptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DecryptButton.Location = new System.Drawing.Point(1455, 261);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(152, 36);
            this.DecryptButton.TabIndex = 41;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // SaveFilePathTextBox
            // 
            this.SaveFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveFilePathTextBox.Location = new System.Drawing.Point(959, 606);
            this.SaveFilePathTextBox.Multiline = true;
            this.SaveFilePathTextBox.Name = "SaveFilePathTextBox";
            this.SaveFilePathTextBox.Size = new System.Drawing.Size(431, 36);
            this.SaveFilePathTextBox.TabIndex = 43;
            // 
            // SaveFilePathLabel
            // 
            this.SaveFilePathLabel.AutoSize = true;
            this.SaveFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveFilePathLabel.Location = new System.Drawing.Point(757, 599);
            this.SaveFilePathLabel.Name = "SaveFilePathLabel";
            this.SaveFilePathLabel.Size = new System.Drawing.Size(205, 41);
            this.SaveFilePathLabel.TabIndex = 42;
            this.SaveFilePathLabel.Text = "Save File Path:";
            // 
            // SaveEncryptedAsTxt
            // 
            this.SaveEncryptedAsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveEncryptedAsTxt.Enabled = false;
            this.SaveEncryptedAsTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveEncryptedAsTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEncryptedAsTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveEncryptedAsTxt.Location = new System.Drawing.Point(1455, 390);
            this.SaveEncryptedAsTxt.Name = "SaveEncryptedAsTxt";
            this.SaveEncryptedAsTxt.Size = new System.Drawing.Size(152, 60);
            this.SaveEncryptedAsTxt.TabIndex = 44;
            this.SaveEncryptedAsTxt.Text = "Save Encrypted As Text";
            this.SaveEncryptedAsTxt.UseVisualStyleBackColor = false;
            this.SaveEncryptedAsTxt.Click += new System.EventHandler(this.SaveEncryptedAsTxt_Click);
            // 
            // RasdAsBytesEncryptedFile
            // 
            this.RasdAsBytesEncryptedFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RasdAsBytesEncryptedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RasdAsBytesEncryptedFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RasdAsBytesEncryptedFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RasdAsBytesEncryptedFile.Location = new System.Drawing.Point(878, 92);
            this.RasdAsBytesEncryptedFile.Name = "RasdAsBytesEncryptedFile";
            this.RasdAsBytesEncryptedFile.Size = new System.Drawing.Size(277, 36);
            this.RasdAsBytesEncryptedFile.TabIndex = 45;
            this.RasdAsBytesEncryptedFile.Text = "Read As Bytes Encrypted File";
            this.RasdAsBytesEncryptedFile.UseVisualStyleBackColor = false;
            this.RasdAsBytesEncryptedFile.Click += new System.EventHandler(this.RasdAsBytesEncryptedFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1630, 696);
            this.Controls.Add(this.RasdAsBytesEncryptedFile);
            this.Controls.Add(this.SaveEncryptedAsTxt);
            this.Controls.Add(this.SaveFilePathTextBox);
            this.Controls.Add(this.SaveFilePathLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.ClearFileFieldsButton);
            this.Controls.Add(this.SaveDecryptedButton);
            this.Controls.Add(this.SaveEncryptedButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.OutputFileLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.SystemLabel);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.PrimalTestResultLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.GetFileAsASCIIButton);
            this.Controls.Add(this.InputBLabel);
            this.Controls.Add(this.bError);
            this.Controls.Add(this.qError);
            this.Controls.Add(this.pError);
            this.Controls.Add(this.ErrorsLabel3);
            this.Controls.Add(this.ErrorsLabel2);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.InputPQLabel);
            this.Controls.Add(this.StartPrimalTestButton);
            this.Controls.Add(this.RabinsLabel);
            this.Controls.Add(this.SympleCycleRadioButton);
            this.Controls.Add(this.ApplyBButton);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.ApplyQAndPButton);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.ModsLabel);
            this.Controls.Add(this.MillersRabbinsRadioButton);
            this.Controls.Add(this.FermatsRadioButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.GetFileAsBytesButton);
            this.Controls.Add(this.FilePathLabel);
            this.Name = "MainForm";
            this.Text = "Rabins Cryptosystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FilePathLabel;
        private Button GetFileAsBytesButton;
        private TextBox PathTextBox;
        private RadioButton FermatsRadioButton;
        private RadioButton MillersRabbinsRadioButton;
        private Label ModsLabel;
        private Label PLabel;
        private TextBox PTextBox;
        private Button ApplyQAndPButton;
        private TextBox QTextBox;
        private Label QLabel;
        private TextBox BTextBox;
        private Label BLabel;
        private Button ApplyBButton;
        private RadioButton SympleCycleRadioButton;
        private Label RabinsLabel;
        private Button StartPrimalTestButton;
        private Label InputPQLabel;
        private Label ErrorLabel1;
        private Label ErrorsLabel2;
        private Label ErrorsLabel3;
        private Label pError;
        private Label qError;
        private Label bError;
        private Label InputBLabel;
        private Button GetFileAsASCIIButton;
        private Button ContinueButton;
        private Label ResultLabel;
        private Label PrimalTestResultLabel;
        private Button ClearAllButton;
        private Label SystemLabel;
        private TextBox InputTextBox;
        private Label InputFileLabel;
        private TextBox OutputTextBox;
        private Label OutputFileLabel;
        private Button EncryptButton;
        private Button SaveEncryptedButton;
        private Button SaveDecryptedButton;
        private Button ClearFileFieldsButton;
        private Button DecryptButton;
        private TextBox SaveFilePathTextBox;
        private Label SaveFilePathLabel;
        private Button SaveEncryptedAsTxt;
        private Button RasdAsBytesEncryptedFile;
    }
}