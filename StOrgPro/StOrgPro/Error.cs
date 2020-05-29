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
                Message.Invalidate();
                Message.Update();
            }
        }

        private void Error_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
