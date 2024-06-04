namespace WinForm_1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            double peso, altura, IMC;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            string classific;

            //Cálculo do IMC
            //Fórmula: Peso / altura elevado a 2    
            IMC = peso / Math.Pow(altura, 2);

            if (IMC < 18.5)
            {
                classific = "Baixo peso";
            }
            else if (IMC < 24.9)
            {
                classific = "Peso adequado";
            }
            else if (IMC < 29.9)
            {
                classific = "Sobrepeso";
            }
            else if (IMC < 34.9)
            {
                classific = "Obesidade grau 1";
            }
            else if (IMC < 39.9)
            {
                classific = "Obesidade grau 2";
            }
            else
            {
                classific = "Obesidade extrema.";
            }
           lbClassificacao.Text = classific;
           lbClassificacao.Visible = true;
           lbIMC.Text = IMC.ToString();
           lbIMC.Visible = true;
        }
    }
}
