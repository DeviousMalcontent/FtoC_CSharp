namespace FtoC_CS
{
    partial class MainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_temperature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(74, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(6, 90);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(62, 30);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(12, 67);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(40, 13);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "Result:";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.Location = new System.Drawing.Point(12, 18);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(70, 13);
            this.lbl_temperature.TabIndex = 8;
            this.lbl_temperature.Text = "Temperature:";
            // 
            // radCelsius
            // 
            this.radCelsius.AutoSize = true;
            this.radCelsius.Checked = true;
            this.radCelsius.Location = new System.Drawing.Point(15, 41);
            this.radCelsius.Name = "radCelsius";
            this.radCelsius.Size = new System.Drawing.Size(74, 17);
            this.radCelsius.TabIndex = 5;
            this.radCelsius.TabStop = true;
            this.radCelsius.Text = "To Celsius";
            this.radCelsius.UseVisualStyleBackColor = true;
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Location = new System.Drawing.Point(106, 41);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(91, 17);
            this.radFahrenheit.TabIndex = 6;
            this.radFahrenheit.TabStop = true;
            this.radFahrenheit.Text = "To Fahrenheit";
            this.radFahrenheit.UseVisualStyleBackColor = true;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(58, 64);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(154, 20);
            this.txt_result.TabIndex = 3;
            // 
            // txt_temperature
            // 
            this.txt_temperature.Location = new System.Drawing.Point(88, 15);
            this.txt_temperature.Name = "txt_temperature";
            this.txt_temperature.Size = new System.Drawing.Size(124, 20);
            this.txt_temperature.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 132);
            this.Controls.Add(this.txt_temperature);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.radFahrenheit);
            this.Controls.Add(this.radCelsius);
            this.Controls.Add(this.lbl_temperature);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Fahrenheit to Celsius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_temperature;
        private System.Windows.Forms.RadioButton radCelsius;
        private System.Windows.Forms.RadioButton radFahrenheit;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_temperature;
    }
}

