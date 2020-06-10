using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Besker
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
        public void EmptyBox()
        {
           //    if (textSenha.Text == "")
            //{
              //  textSenha.Text = "Email";
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // EmptyBox();
        }

        private void textBox_Click1(object sender, EventArgs e)
        {
            if(textEmail.Text == "Email")
            {
                textEmail.Clear();
                
            }
            if (textSenha.Text == "")
            {
                textSenha.Text = "Senha";
            }
            

        }
        private void textBox_Click2(object sender, EventArgs e)
        {
            if (textSenha.Text == "Senha")
            {
                textSenha.Clear();
            }
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email";
            }
        }

        private void Click_Cadastro(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }
    }
}
