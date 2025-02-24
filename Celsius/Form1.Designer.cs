namespace Celsius
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
            buttonCtoF = new Button();
            buttonFtoC = new Button();
            textBoxCelsius = new TextBox();
            textBoxFahrenheit = new TextBox();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // buttonCtoF
            // 
            buttonCtoF.Location = new Point(357, 249);
            buttonCtoF.Name = "buttonCtoF";
            buttonCtoF.Size = new Size(129, 23);
            buttonCtoF.TabIndex = 0;
            buttonCtoF.Text = "Convert C to F";
            buttonCtoF.UseVisualStyleBackColor = true;
            buttonCtoF.Click += buttonCtoF_Click;
            // 
            // buttonFtoC
            // 
            buttonFtoC.Location = new Point(532, 249);
            buttonFtoC.Name = "buttonFtoC";
            buttonFtoC.Size = new Size(129, 23);
            buttonFtoC.TabIndex = 1;
            buttonFtoC.Text = "Convert F to C";
            buttonFtoC.UseVisualStyleBackColor = true;
            buttonFtoC.Click += buttonFtoC_Click;
            // 
            // textBoxCelsius
            // 
            textBoxCelsius.Location = new Point(357, 195);
            textBoxCelsius.Name = "textBoxCelsius";
            textBoxCelsius.PlaceholderText = "Celsius";
            textBoxCelsius.Size = new Size(129, 23);
            textBoxCelsius.TabIndex = 2;
            textBoxCelsius.TextChanged += textBoxCelsius_TextChanged;
            // 
            // textBoxFahrenheit
            // 
            textBoxFahrenheit.Location = new Point(532, 195);
            textBoxFahrenheit.Name = "textBoxFahrenheit";
            textBoxFahrenheit.PlaceholderText = "Fahrenheit";
            textBoxFahrenheit.Size = new Size(129, 23);
            textBoxFahrenheit.TabIndex = 3;
            textBoxFahrenheit.TextChanged += textBoxFahrenheit_TextChanged;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(473, 322);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 685);
            Controls.Add(buttonClear);
            Controls.Add(textBoxFahrenheit);
            Controls.Add(textBoxCelsius);
            Controls.Add(buttonFtoC);
            Controls.Add(buttonCtoF);
            Name = "Form1";
            Text = "Temperature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCtoF;
        private Button buttonFtoC;
        private TextBox textBoxCelsius;
        private TextBox textBoxFahrenheit;
        private Button buttonClear;
    }
}
