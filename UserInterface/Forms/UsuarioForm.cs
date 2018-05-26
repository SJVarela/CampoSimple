using BusinessLogic.Controller;
using BusinessLogic.Models;
using System;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class UsuarioForm : Form
    {
        private UserFormController controller = new UserFormController();
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usr = new User()
            {
                Alias = tboxAlias.Text,
                Password = tboxPassword.Text,
                Nombre = tboxNombre.Text,
                Apellido = tboxApellido.Text,
                Email = tboxEmail.Text
            };
            controller.AltaUsuario(usr);
        }
    }
}
