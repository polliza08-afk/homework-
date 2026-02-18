using System.Windows.Forms;

namespace homework
{
    public partial class MyCountry : Form
    {
        public MyCountry()
        {
            InitializeComponent();

            string filePath = @"C:\Users\STUDENT\Downloads\ukraine.jpg";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var text = myTextInput.Text;
            pbImage.Image = Image.FromFile(myTextInput.Text);
            //MessageBox.Show("Натиснути кнопку " + text);
            cbCountries.Items.Add(text);
            myTextInput.Text = string.Empty;
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = pbImage.ToString();
            string[] parts = data.Split('|');
            string path = parts[1];
            pbImage.Image = Image.FromFile(path);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно хочете вийти?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
