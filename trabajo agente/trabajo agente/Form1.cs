using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_agente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(.Text == "juancho")
            {
                if (textBox2.Text == "123tamarindo")
                {
                    MessageBox.Show("la contraseña es correcta agente juancho");
                }
                else
                {
                    MessageBox.Show("contraseña incorrecta");
                }
            }
        }
    }
}
