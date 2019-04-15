namespace PhoneDirectoryParser
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.buttonOpenPhoneDirectory = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenPhoneDirectory
            // 
            this.buttonOpenPhoneDirectory.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenPhoneDirectory.Name = "buttonOpenPhoneDirectory";
            this.buttonOpenPhoneDirectory.Size = new System.Drawing.Size(298, 23);
            this.buttonOpenPhoneDirectory.TabIndex = 0;
            this.buttonOpenPhoneDirectory.Text = "Открыть телефонный справочник";
            this.buttonOpenPhoneDirectory.UseVisualStyleBackColor = true;
            this.buttonOpenPhoneDirectory.Click += new System.EventHandler(this.ButtonOpenPhoneDirectory_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.Location = new System.Drawing.Point(51, 92);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(203, 23);
            this.buttonExportToExcel.TabIndex = 1;
            this.buttonExportToExcel.Text = "Экспорт в Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = true;
            this.buttonExportToExcel.Click += new System.EventHandler(this.ButtonExportToExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 138);
            this.Controls.Add(this.buttonExportToExcel);
            this.Controls.Add(this.buttonOpenPhoneDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPhoneDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonExportToExcel;
    }
}

