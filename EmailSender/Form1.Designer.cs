namespace EmailSender
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.emailText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(3, 21);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(197, 20);
            this.emailText.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sendBtn.Location = new System.Drawing.Point(109, 416);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send Email";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Location = new System.Drawing.Point(72, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 59);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subjectText);
            this.panel2.Location = new System.Drawing.Point(72, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 59);
            this.panel2.TabIndex = 4;
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(3, 21);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(197, 20);
            this.subjectText.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.messageText);
            this.panel3.Location = new System.Drawing.Point(75, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 179);
            this.panel3.TabIndex = 5;
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(3, 3);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(270, 173);
            this.messageText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(260, 416);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Send Email in C#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label4;
    }
}

