namespace homework
{
    partial class MyCountry
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
            btnAdd = new Button();
            cbCountries = new ComboBox();
            textBoxCountry = new TextBox();
            textBox1 = new TextBox();
            pbImage = new PictureBox();
            myTextInput = new RichTextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(232, 129);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 39);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbCountries
            // 
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(11, 85);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(315, 23);
            cbCountries.TabIndex = 1;
            cbCountries.SelectedIndexChanged += cbCountries_SelectedIndexChanged;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxCountry.ForeColor = Color.Blue;
            textBoxCountry.Location = new Point(11, 13);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(315, 29);
            textBoxCountry.TabIndex = 2;
            textBoxCountry.Text = "назва країни";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(11, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 29);
            textBox1.TabIndex = 2;
            textBox1.Text = "Шлях до файлу прапора";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(11, 164);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(167, 96);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // myTextInput
            // 
            myTextInput.Location = new Point(11, 48);
            myTextInput.Name = "myTextInput";
            myTextInput.Size = new Size(315, 31);
            myTextInput.TabIndex = 4;
            myTextInput.Text = "";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnExit.Location = new Point(232, 194);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 5;
            btnExit.Text = "Вийти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MyCountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 275);
            Controls.Add(btnExit);
            Controls.Add(myTextInput);
            Controls.Add(pbImage);
            Controls.Add(textBox1);
            Controls.Add(textBoxCountry);
            Controls.Add(cbCountries);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MyCountry";
            Text = "Країни";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox cbCountries;
        private TextBox textBoxCountry;
        private TextBox textBox1;
        private PictureBox pbImage;
        private RichTextBox myTextInput;
        private Button btnExit;
    }
}
