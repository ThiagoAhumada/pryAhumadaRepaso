namespace pryAhumadaRepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El codigo ingresado es este " + txtCodigo.Text + "" + txtNombre.Text+ "" + "" + cmbGrupo.Text);

        }
    }
}
