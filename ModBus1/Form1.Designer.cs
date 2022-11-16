namespace ModBus1
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
            this.buttonConect = new System.Windows.Forms.Button();
            this.buttonUpdatePorts = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.MySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConect
            // 
            this.buttonConect.Location = new System.Drawing.Point(642, 12);
            this.buttonConect.Name = "buttonConect";
            this.buttonConect.Size = new System.Drawing.Size(146, 42);
            this.buttonConect.TabIndex = 0;
            this.buttonConect.Text = "Подключиться";
            this.buttonConect.UseVisualStyleBackColor = true;
            this.buttonConect.Click += new System.EventHandler(this.buttonConect_Click);
            // 
            // buttonUpdatePorts
            // 
            this.buttonUpdatePorts.Location = new System.Drawing.Point(642, 82);
            this.buttonUpdatePorts.Name = "buttonUpdatePorts";
            this.buttonUpdatePorts.Size = new System.Drawing.Size(146, 44);
            this.buttonUpdatePorts.TabIndex = 1;
            this.buttonUpdatePorts.Text = "Обновить список доступных портов";
            this.buttonUpdatePorts.UseVisualStyleBackColor = true;
            this.buttonUpdatePorts.Click += new System.EventHandler(this.buttonUpdatePorts_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Location = new System.Drawing.Point(508, 29);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(112, 21);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // MySerialPort
            // 
            this.MySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MySerialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тут будет какой-то текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonUpdatePorts);
            this.Controls.Add(this.buttonConect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConect;
        private System.Windows.Forms.Button buttonUpdatePorts;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.IO.Ports.SerialPort MySerialPort;
        private System.Windows.Forms.Label label1;
    }
}

