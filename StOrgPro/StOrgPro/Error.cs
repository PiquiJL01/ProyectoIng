using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StOrgPro
{
    public partial class Error : Form
    {
        public Error(dynamic error)
        {
            InitializeComponent();
            if (error is FailedLogin)
            {
                Message.Text = "Usuario o Password Invalido";
            }
            else if (error is NoDBConnection)
            {
                Message.Text = "No se pude establecer conexion";
            }
            else if (error is FailedToRemove)
            {
                Message.Text = "Movimiento Invalido";
            }
            else if (error is WrongUserType)
            {
                Message.Text = "Usuario Invalido";
            }
            else
            {
                Message.Text = "Error Desconocido";
            }
            Message.Refresh();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
