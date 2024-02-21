namespace Encriptador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSustitucion_Click(object sender, EventArgs e)
        {
            Sustitucion sustitucion = new Sustitucion();
            sustitucion.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransposicion_Click(object sender, EventArgs e)
        {
            Transposicion transposicion = new Transposicion();
            transposicion.Show();
        }
    }
}