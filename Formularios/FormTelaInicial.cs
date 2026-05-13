namespace Biblioteca
{
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
