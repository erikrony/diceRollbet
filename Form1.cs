using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSimples1
{
    public partial class Form1 : Form
    {
        int apostaValue;
        int apostaResultado;
        int saldoBanca = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int betIntValueDouble = Convert.ToInt32(betValue.Text);
            betIntValueDouble = betIntValueDouble * 2;
            betValue.Text = betIntValueDouble.ToString();
            
        }

        private void saldoValue_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void resultado_Click(object sender, EventArgs e)
        {
            resultado.Text = saldoBanca.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saldoBanca > 1) {
                int betIntValue = Convert.ToInt32(betValue.Text);
                saldoBanca = saldoBanca - betIntValue;
                resultValue.Text = ("Oops! Você perdeu $ " + betIntValue + "seu saldo é: $" + saldoBanca.ToString());
                resultado.Text = saldoBanca.ToString();

            }
            else
            {
                resultValue.Text = "Não há saldo suficiente!";
            }
           

        }

    }
}
