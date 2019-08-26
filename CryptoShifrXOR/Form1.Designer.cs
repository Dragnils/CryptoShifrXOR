namespace CryptoShifrXOR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnPusk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbEncrypt = new System.Windows.Forms.RadioButton();
            this.rdbDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(39, 55);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFileOpen.TabIndex = 0;
            this.btnFileOpen.Text = "Файл...";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(729, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(120, 55);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(648, 20);
            this.txtSource.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль";
            // 
            // btnPusk
            // 
            this.btnPusk.Location = new System.Drawing.Point(538, 240);
            this.btnPusk.Name = "btnPusk";
            this.btnPusk.Size = new System.Drawing.Size(75, 23);
            this.btnPusk.TabIndex = 7;
            this.btnPusk.Text = "Пуск";
            this.btnPusk.UseVisualStyleBackColor = true;
            this.btnPusk.Click += new System.EventHandler(this.btnPusk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(631, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdbEncrypt
            // 
            this.rdbEncrypt.AutoSize = true;
            this.rdbEncrypt.Location = new System.Drawing.Point(423, 136);
            this.rdbEncrypt.Name = "rdbEncrypt";
            this.rdbEncrypt.Size = new System.Drawing.Size(95, 17);
            this.rdbEncrypt.TabIndex = 9;
            this.rdbEncrypt.TabStop = true;
            this.rdbEncrypt.Text = "Зашифровать";
            this.rdbEncrypt.UseVisualStyleBackColor = true;
            
            // 
            // rdbDecrypt
            // 
            this.rdbDecrypt.AutoSize = true;
            this.rdbDecrypt.Location = new System.Drawing.Point(571, 136);
            this.rdbDecrypt.Name = "rdbDecrypt";
            this.rdbDecrypt.Size = new System.Drawing.Size(101, 17);
            this.rdbDecrypt.TabIndex = 10;
            this.rdbDecrypt.TabStop = true;
            this.rdbDecrypt.Text = "Расшифровать";
            this.rdbDecrypt.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 283);
            this.Controls.Add(this.rdbDecrypt);
            this.Controls.Add(this.rdbEncrypt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPusk);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnFileOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnPusk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbEncrypt;
        private System.Windows.Forms.RadioButton rdbDecrypt;
    }
}

