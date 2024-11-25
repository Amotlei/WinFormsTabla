namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVer_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            string tabla = "";
            for (int i = 0; i < 10; i++)
            {
                tabla = tabla + n + "x" + i + " =" + (n * i) + "\n";
            }
            this.richTextBoxResultados.AppendText(tabla);
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
