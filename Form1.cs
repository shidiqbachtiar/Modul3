namespace Modul3_103022400044
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            double nilai;

            if (!double.TryParse(textBox1.Text, out nilai))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string dari = comboBox1.SelectedItem.ToString();
            string ke = comboBox2.SelectedItem.ToString();

            double celcius = nilai;

            if (dari == "Fahrenheit")
                celcius = (nilai - 32) * 5 / 9;
            else if (dari == "kelvin")
                celcius = nilai - 273.15;
            else if (dari == "Reamur")
                celcius = nilai * 5 / 4;

            double hasil = celcius;

            if (ke == "Fahrenheit")
                hasil = (celcius * 9 / 5) + 32;
            else if (ke == "Kelvin")
                hasil = celcius + 273.15;
            else if (ke == "Reamur")
                hasil = celcius * 4 / 5;

            textBox2.Text = hasil.ToString();
        }
    }
}
