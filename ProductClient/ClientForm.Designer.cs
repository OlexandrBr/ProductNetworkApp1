namespace ProductClient
{
    partial class ClientForm
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
            txtServerAddress = new TextBox();
            label2 = new Label();
            txtPort = new TextBox();
            label3 = new Label();
            txtProducts = new TextBox();
            label4 = new Label();
            btnSendRequest = new Button();
            label5 = new Label();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 38);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Адреса сервера";
            // 
            // txtServerAddress
            // 
            txtServerAddress.Location = new Point(181, 73);
            txtServerAddress.Name = "txtServerAddress";
            txtServerAddress.Size = new Size(200, 39);
            txtServerAddress.TabIndex = 1;
            txtServerAddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 2;
            label2.Text = "Порт";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(420, 73);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(94, 39);
            txtPort.TabIndex = 3;
            txtPort.Text = "5000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 194);
            label3.Name = "label3";
            label3.Size = new Size(267, 32);
            label3.TabIndex = 4;
            label3.Text = "Найменування товарів";
            // 
            // txtProducts
            // 
            txtProducts.Location = new Point(233, 250);
            txtProducts.Multiline = true;
            txtProducts.Name = "txtProducts";
            txtProducts.Size = new Size(268, 192);
            txtProducts.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 467);
            label4.Name = "label4";
            label4.Size = new Size(541, 32);
            label4.TabIndex = 6;
            label4.Text = "Вводьте товари через кому або з нового рядка";
            // 
            // btnSendRequest
            // 
            btnSendRequest.Location = new Point(631, 66);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(264, 46);
            btnSendRequest.TabIndex = 7;
            btnSendRequest.Text = "Надіслати запит";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(706, 194);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 8;
            label5.Text = "Результат";
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(631, 250);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(256, 192);
            rtbResult.TabIndex = 9;
            rtbResult.Text = "";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 601);
            Controls.Add(rtbResult);
            Controls.Add(label5);
            Controls.Add(btnSendRequest);
            Controls.Add(label4);
            Controls.Add(txtProducts);
            Controls.Add(label3);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtServerAddress);
            Controls.Add(label1);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клієнт товарів";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServerAddress;
        private Label label2;
        private TextBox txtPort;
        private Label label3;
        private TextBox txtProducts;
        private Label label4;
        private Button btnSendRequest;
        private Label label5;
        private RichTextBox rtbResult;
    }
}
