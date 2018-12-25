namespace Epam.Task05.BackupSystem
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MonitoringRadioButton = new System.Windows.Forms.RadioButton();
            this.RollbackRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose mode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MonitoringRadioButton
            // 
            this.MonitoringRadioButton.AutoSize = true;
            this.MonitoringRadioButton.Location = new System.Drawing.Point(92, 54);
            this.MonitoringRadioButton.Name = "MonitoringRadioButton";
            this.MonitoringRadioButton.Size = new System.Drawing.Size(74, 17);
            this.MonitoringRadioButton.TabIndex = 6;
            this.MonitoringRadioButton.TabStop = true;
            this.MonitoringRadioButton.Text = "Monitoring";
            this.MonitoringRadioButton.UseVisualStyleBackColor = true;
            this.MonitoringRadioButton.UseWaitCursor = true;
            this.MonitoringRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // RollbackRadioButton
            // 
            this.RollbackRadioButton.AutoSize = true;
            this.RollbackRadioButton.Location = new System.Drawing.Point(92, 78);
            this.RollbackRadioButton.Name = "RollbackRadioButton";
            this.RollbackRadioButton.Size = new System.Drawing.Size(67, 17);
            this.RollbackRadioButton.TabIndex = 7;
            this.RollbackRadioButton.TabStop = true;
            this.RollbackRadioButton.Text = "Rollback";
            this.RollbackRadioButton.UseVisualStyleBackColor = true;
            this.RollbackRadioButton.CheckedChanged += new System.EventHandler(this.RollbackRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 150);
            this.Controls.Add(this.RollbackRadioButton);
            this.Controls.Add(this.MonitoringRadioButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Backup System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton MonitoringRadioButton;
        private System.Windows.Forms.RadioButton RollbackRadioButton;
    }
}

