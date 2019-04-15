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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExportToExcel = new System.Windows.Forms.Button();
            this.buttonOpenPhoneDirectory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalledNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTimeToStartAConversation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationOfMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOpenPhoneDirectory);
            this.panel1.Controls.Add(this.buttonExportToExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 22);
            this.panel1.TabIndex = 2;
            // 
            // buttonExportToExcel
            // 
            this.buttonExportToExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExportToExcel.Location = new System.Drawing.Point(1109, 0);
            this.buttonExportToExcel.Name = "buttonExportToExcel";
            this.buttonExportToExcel.Size = new System.Drawing.Size(217, 22);
            this.buttonExportToExcel.TabIndex = 2;
            this.buttonExportToExcel.Text = "Экспорт в Excel";
            this.buttonExportToExcel.UseVisualStyleBackColor = true;
            // 
            // buttonOpenPhoneDirectory
            // 
            this.buttonOpenPhoneDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOpenPhoneDirectory.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenPhoneDirectory.Name = "buttonOpenPhoneDirectory";
            this.buttonOpenPhoneDirectory.Size = new System.Drawing.Size(221, 22);
            this.buttonOpenPhoneDirectory.TabIndex = 3;
            this.buttonOpenPhoneDirectory.Text = "Открыть телефонный справочник";
            this.buttonOpenPhoneDirectory.UseVisualStyleBackColor = true;
            this.buttonOpenPhoneDirectory.Click += new System.EventHandler(this.ButtonOpenPhoneDirectory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNumber,
            this.NameOfService,
            this.Direction,
            this.CalledNumber,
            this.DateAndTimeToStartAConversation,
            this.DurationOfMinutes,
            this.Cost});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1326, 604);
            this.dataGridView1.TabIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Телефонный номер";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // NameOfService
            // 
            this.NameOfService.HeaderText = "Наименование услуги";
            this.NameOfService.Name = "NameOfService";
            // 
            // Direction
            // 
            this.Direction.HeaderText = "Направление";
            this.Direction.Name = "Direction";
            // 
            // CalledNumber
            // 
            this.CalledNumber.HeaderText = "Номер вызываемого/вызывающего абонента";
            this.CalledNumber.Name = "CalledNumber";
            // 
            // DateAndTimeToStartAConversation
            // 
            this.DateAndTimeToStartAConversation.HeaderText = "Дата,Время начала";
            this.DateAndTimeToStartAConversation.Name = "DateAndTimeToStartAConversation";
            // 
            // DurationOfMinutes
            // 
            this.DurationOfMinutes.HeaderText = "Прод.(мин)/Кол.услуг";
            this.DurationOfMinutes.Name = "DurationOfMinutes";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость(руб.)";
            this.Cost.Name = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpenPhoneDirectory;
        private System.Windows.Forms.Button buttonExportToExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalledNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTimeToStartAConversation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationOfMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}

