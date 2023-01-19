using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calcular_Energia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void Btcalcular_Click(object sender, EventArgs e)
        {
            Total.Text = (int.Parse(Atual.Text) - int.Parse(Antigo.Text)).ToString();
            Regular.Text =
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Antigo.Text = string.Empty;
            Atual.Text = string.Empty;
            Total.Text = String.Empty;
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
         
        }
    }
}