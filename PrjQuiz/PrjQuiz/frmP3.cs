using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjQuiz
{
    public partial class frmP3 : Form
    {
        public frmP3()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta", "QUIZ");
                //somar na variável global acertos
                VariaveisGlobais.Acertos += 1;
                frmFinal Final = new frmFinal();
                Final.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "QUIZ");
                //somar na variável global erros
                VariaveisGlobais.Erros += 1;
                frmFinal Final = new frmFinal();
                Final.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
