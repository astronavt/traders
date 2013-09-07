namespace TradeExchangeMonitor
{
    partial class SettingsConnection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAPIUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxUserId);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAPIUserId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 204);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения к ActiveTick";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "(введите API UserId в формате {123-abc-123-abc})";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(22, 108);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(145, 20);
            this.textBoxUserId.TabIndex = 5;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(116, 173);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(144, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Проверить подключение";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(22, 147);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(145, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(22, 173);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Сохранить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ActiveTick пароль (Password)";
            // 
            // textBoxAPIUserId
            // 
            this.textBoxAPIUserId.Location = new System.Drawing.Point(22, 42);
            this.textBoxAPIUserId.Name = "textBoxAPIUserId";
            this.textBoxAPIUserId.Size = new System.Drawing.Size(238, 20);
            this.textBoxAPIUserId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ActiveTick логин (User ID)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ActiveTick логин к API (API UserId)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.Location = new System.Drawing.Point(31, 219);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(181, 23);
            this.lblinfo.TabIndex = 11;
            this.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 247);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsConnection";
            this.Text = "Настройки подключения";
            this.Shown += new System.EventHandler(this.SettingsConnection_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxAPIUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblinfo;
    }
}