using Controllers;
namespace View
{
    //inyeccion de dependencias
    public partial class LoginDb : Form
    {
        private readonly ILogic _logic;
        public LoginDb(ILogic logic)
        {
            _logic = logic;
            InitializeComponent();
        }

        //se arma la cadena con los valores de los txt y se la enviamos a la capa logica, esta nos retorna una tupla donde verificamos el valor booleano para saber si abrimos el siguiente formulario o no
        //tambien podemos verificar con el menssage cual es el posible error 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var (message, valor) = _logic.Conectar("Host=" + txtHost.Text + ";Port=" + txtPuerto.Text + ";Database=" + txtNameBd.Text + ";User Id=" + txtuser.Text + ";Password=" + txtPass.Text + ";");
                MessageBox.Show(message);
                if (valor)
                {
                    new AdministradorSeries(_logic).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error:" + message);
                }
            }
            catch (Exception es) { MessageBox.Show("error" + es); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
