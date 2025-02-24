namespace Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                textBoxFahrenheit.Text = fahrenheit.ToString("F2");
            }
            else
            {
                MessageBox.Show("Voer een geldige temperatuur in Celsius in.");
            }
        }

        private void textBoxCelsius_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxCelsius.Text, out _))
            {
                textBoxCelsius.BackColor = Color.LightCoral;
            }
            else
            {
                textBoxCelsius.BackColor = Color.White;
            }
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxFahrenheit.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                textBoxCelsius.Text = celsius.ToString("F2");
            }
            else
            {
                MessageBox.Show("Voer een geldige temperatuur in Fahrenheit in.");
            }
        }

        private void textBoxFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFahrenheit.Text, out _))
            {
                textBoxFahrenheit.BackColor = Color.LightCoral;
            }
            else
            {
                textBoxFahrenheit.BackColor = Color.White;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCelsius.Text = string.Empty;
            textBoxFahrenheit.Text = string.Empty;

            textBoxCelsius.BackColor = Color.White;
            textBoxFahrenheit.BackColor = Color.White;
        }

    }
}
