using System.Globalization;

namespace calculadora
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


        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        bool bool1 = false;
        bool porcent = false;
        bool maisMenos = false;

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResult.Text += "0";
            bool1 = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResult.Text += "1";
            bool1 = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResult.Text += "2";
            bool1 = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResult.Text += "3";
            bool1 = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResult.Text += "4";
            bool1 = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResult.Text += "5";
            bool1 = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResult.Text += "6";
            bool1 = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResult.Text += "7";
            bool1 = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResult.Text += "8";
            bool1 = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResult.Text += "9";
            bool1 = true;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txbResult.Text += ".";
            bool1 = true;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            bool1 = false;
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            operacao = "mais";
            lblOperacao.Text = valor1 + " +";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            operacao = "menos";
            lblOperacao.Text = valor1 + " -";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            operacao = "vezes";
            lblOperacao.Text = valor1 + " *";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
 
            valor2 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            if (operacao == "mais")
            {
                if (porcent)
                {
                    decimal porcentagem = valor1 * (valor2 / 100);
                    txbResult.Text = Convert.ToString(valor1 + porcentagem);
                    lblOperacao.Text = valor1 + " + " + porcentagem + " =";
                }
                else
                {
                    txbResult.Text = Convert.ToString(valor1 + valor2);
                    lblOperacao.Text = valor1 + " + " + valor2 + " =";
                }

            } else if (operacao == "menos"){

                if (porcent)
                {
                    decimal porcentagem = valor1 * (valor2 / 100);
                    txbResult.Text = Convert.ToString(valor1 - porcentagem);
                    lblOperacao.Text = valor1 + " - " + porcentagem +  " =";
                } else {
                    txbResult.Text = Convert.ToString(valor1 - valor2);
                    lblOperacao.Text = valor1 + " - " + valor2 + " =";
                }

            } else if (operacao == "vezes"){
                txbResult.Text = Convert.ToString(valor1 * valor2);
                lblOperacao.Text = valor1 + " x " + valor2 + " =";
            } else if (operacao == "div"){
                txbResult.Text = Convert.ToString(valor1 / valor2);
                lblOperacao.Text = valor1 + " / " + valor2 + " =";
            } 
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (bool1) { 
            var numero = txbResult.Text;
            var lenght = txbResult.TextLength;
            for (int i = 0; i < lenght; i++) { 
              
                txbResult.Text = numero.Remove(numero.Length - 1);
             }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txbResult.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbResult.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void btnElevado_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            operacao = "elevado";
            lblOperacao.Text = valor1 + "² =";
            txbResult.Text = Convert.ToString(valor1 * valor1);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            lblOperacao.Text = "²√" + valor1;
            txbResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(valor1)));
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            porcent = true;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            txbResult.Text = Convert.ToString( 1 / valor1);
            lblOperacao.Text =  " 1 / (" + valor1 + ")";
        }

        private void txbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            var numeroInvertido1 = Convert.ToDecimal(txbResult.Text);
            numeroInvertido1 = numeroInvertido1 * -1;
            txbResult.Text = numeroInvertido1.ToString();
        }


        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txbResult.Text, CultureInfo.InvariantCulture);
            txbResult.Text = "";
            operacao = "div";
            lblOperacao.Text = valor1 + " /";
        }
    }
}