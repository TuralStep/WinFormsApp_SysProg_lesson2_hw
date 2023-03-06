namespace WinFormsApp_SysProg_lesson2_hw
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_fileOpen = new System.Windows.Forms.Button();
            this.txt_fileSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.rBtn_decrypt = new System.Windows.Forms.RadioButton();
            this.rBtn_encrypt = new System.Windows.Forms.RadioButton();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_fileOpen
            // 
            this.btn_fileOpen.Location = new System.Drawing.Point(12, 12);
            this.btn_fileOpen.Name = "btn_fileOpen";
            this.btn_fileOpen.Size = new System.Drawing.Size(75, 23);
            this.btn_fileOpen.TabIndex = 0;
            this.btn_fileOpen.Text = "File";
            this.btn_fileOpen.UseVisualStyleBackColor = true;
            this.btn_fileOpen.Click += new System.EventHandler(this.btn_fileOpen_Click);
            // 
            // txt_fileSource
            // 
            this.txt_fileSource.Location = new System.Drawing.Point(93, 12);
            this.txt_fileSource.Name = "txt_fileSource";
            this.txt_fileSource.Size = new System.Drawing.Size(378, 23);
            this.txt_fileSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(93, 45);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(235, 23);
            this.txt_password.TabIndex = 3;
            // 
            // rBtn_decrypt
            // 
            this.rBtn_decrypt.AutoSize = true;
            this.rBtn_decrypt.Location = new System.Drawing.Point(405, 49);
            this.rBtn_decrypt.Name = "rBtn_decrypt";
            this.rBtn_decrypt.Size = new System.Drawing.Size(66, 19);
            this.rBtn_decrypt.TabIndex = 4;
            this.rBtn_decrypt.Text = "Decrypt";
            this.rBtn_decrypt.UseVisualStyleBackColor = true;
            // 
            // rBtn_encrypt
            // 
            this.rBtn_encrypt.AutoSize = true;
            this.rBtn_encrypt.Checked = true;
            this.rBtn_encrypt.Location = new System.Drawing.Point(334, 49);
            this.rBtn_encrypt.Name = "rBtn_encrypt";
            this.rBtn_encrypt.Size = new System.Drawing.Size(65, 19);
            this.rBtn_encrypt.TabIndex = 5;
            this.rBtn_encrypt.TabStop = true;
            this.rBtn_encrypt.Text = "Encrypt";
            this.rBtn_encrypt.UseVisualStyleBackColor = true;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 74);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(459, 23);
            this.progBar.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(396, 103);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(315, 103);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 137);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.rBtn_encrypt);
            this.Controls.Add(this.rBtn_decrypt);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fileSource);
            this.Controls.Add(this.btn_fileOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btn_fileOpen;
        private TextBox txt_fileSource;
        private Label label2;
        private TextBox txt_password;
        private RadioButton rBtn_decrypt;
        private RadioButton rBtn_encrypt;
        private ProgressBar progBar;
        private Button btn_cancel;
        private Button btn_start;
    }
}