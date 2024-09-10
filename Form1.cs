using System.Text;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassGenerator(6);
            }
            else if (checkBox2.Checked)
            {
                PassGenerator(10);
            }
            else if (checkBox3.Checked)
            {
                PassGenerator(12);
            }
            else
            {
                PassGenerator(8);
            }
            
        }

        public void PassGenerator(int len)
        {
            
            const string ValidChar = "abcdefghijklmnopqrstABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);


            }
            textBox1.Text = result.ToString();
        }
    }
}
