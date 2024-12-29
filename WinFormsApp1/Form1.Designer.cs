namespace WinFormsApp1
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
            CityComboBox = new ComboBox();
            GetWeatherButton = new Button();
            ResulttextBox = new TextBox();
            SuspendLayout();
            // 
            // CityComboBox
            // 
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(624, 289);
            CityComboBox.Margin = new Padding(4, 3, 4, 3);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(151, 23);
            CityComboBox.TabIndex = 0;
            // 
            // GetWeatherButton
            // 
            GetWeatherButton.Location = new Point(646, 400);
            GetWeatherButton.Margin = new Padding(4, 3, 4, 3);
            GetWeatherButton.Name = "GetWeatherButton";
            GetWeatherButton.Size = new Size(111, 24);
            GetWeatherButton.TabIndex = 1;
            GetWeatherButton.Text = "Get Weather";
            GetWeatherButton.UseVisualStyleBackColor = true;
            GetWeatherButton.Click += GetWeatherButton_Click;
            // 
            // ResulttextBox
            // 
            ResulttextBox.Location = new Point(539, 125);
            ResulttextBox.Margin = new Padding(4, 3, 4, 3);
            ResulttextBox.Multiline = true;
            ResulttextBox.Name = "ResulttextBox";
            ResulttextBox.Size = new Size(331, 127);
            ResulttextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 556);
            Controls.Add(ResulttextBox);
            Controls.Add(GetWeatherButton);
            Controls.Add(CityComboBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CityComboBox;
        private Button GetWeatherButton;
        private TextBox ResulttextBox;
    }
}