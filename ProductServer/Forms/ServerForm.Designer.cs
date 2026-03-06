namespace ProductServer
{
    partial class ServerForm
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
            label1 = new Label();
            txtFilePath = new TextBox();
            btnBrowseFile = new Button();
            btnLoadData = new Button();
            label2 = new Label();
            btnStartServer = new Button();
            btnStopServer = new Button();
            label3 = new Label();
            rtbLogs = new RichTextBox();
            txtPort = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 28);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Шлях до Excel-файлу";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(124, 76);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(200, 39);
            txtFilePath.TabIndex = 1;
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Location = new Point(355, 22);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(245, 44);
            btnBrowseFile.TabIndex = 2;
            btnBrowseFile.Text = "Обрати файл";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(355, 72);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(245, 46);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Завантажити дані";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 208);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 4;
            label2.Text = "Порт";
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(737, 22);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(258, 44);
            btnStartServer.TabIndex = 5;
            btnStartServer.Text = "Запустити сервер";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStopServer
            // 
            btnStopServer.Location = new Point(737, 72);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(258, 43);
            btnStopServer.TabIndex = 6;
            btnStopServer.Text = "Зупинити сервер";
            btnStopServer.UseVisualStyleBackColor = true;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 155);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 7;
            label3.Text = "Логи сервера";
            // 
            // rtbLogs
            // 
            rtbLogs.Location = new Point(559, 205);
            rtbLogs.Name = "rtbLogs";
            rtbLogs.ReadOnly = true;
            rtbLogs.Size = new Size(235, 217);
            rtbLogs.TabIndex = 8;
            rtbLogs.Text = "";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(124, 243);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(200, 39);
            txtPort.TabIndex = 9;
            txtPort.Text = "5000";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 434);
            Controls.Add(txtPort);
            Controls.Add(rtbLogs);
            Controls.Add(label3);
            Controls.Add(btnStopServer);
            Controls.Add(btnStartServer);
            Controls.Add(label2);
            Controls.Add(btnLoadData);
            Controls.Add(btnBrowseFile);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Name = "ServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сервер Товарів";
            Load += ServerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilePath;
        private Button btnBrowseFile;
        private Button btnLoadData;
        private Label label2;
        private Button btnStartServer;
        private Button btnStopServer;
        private Label label3;
        private RichTextBox rtbLogs;
        private TextBox txtPort;
    }
}
