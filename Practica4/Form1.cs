namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, nsue;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 400000.00) nsue = sueldo * 1.15;
            else nsue = sueldo * 1.08;
           
        }
    }
}
