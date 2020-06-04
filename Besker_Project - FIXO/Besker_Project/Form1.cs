using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Besker_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Limpar_Box1(object sender, EventArgs e)
        {
            if (emailText.Text == "Email") {
                emailText.Clear();
            }
            
        }
        private void Limpar_Box2(object sender, EventArgs e)
        {
            if (senhaText.Text == "Senha") {
                senhaText.Clear();
            }
        }

        private void senhaText_TextChanged(object sender, EventArgs e)
        {
            senhaText.PasswordChar = '*' ;
        }

        private void Recuperar_Senha(object sender, EventArgs e)
        {

        }
    }
}
