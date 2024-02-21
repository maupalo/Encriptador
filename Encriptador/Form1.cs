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

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Optionally, you can specify the type of buttons and icon to display
            MessageBox.Show("Copyright 2024 Mauricio P. Herrera.\n" +
                "This program is released under the MIT License.",
                            "Acerca de",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}