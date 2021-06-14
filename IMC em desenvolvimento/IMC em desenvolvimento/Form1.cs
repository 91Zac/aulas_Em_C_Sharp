using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_em_desenvolvimento
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Botao Calcular foi clicado

            try
            {
                //tentar

                //if para verificar se foi digitado  a altura
                if (txtAltura.Text == string.Empty)//verificado se txtAltura esta vazia
                {
                    MessageBox.Show("Digite a Altura");
                    return;
                }//if para verificar a Altura


                //if para verificar se foi digitado a altura
                if (txtPeso.Text == string.Empty)
                {

                    MessageBox.Show("Digite o Peso");
                }//if para verificar a Altura



                else
                {


                    double Peso; //declaração da Variavel que receberá o Peso
                    double Altura;//declaração da Variavel que receberá a Altura
                    double IMC;//declaração da váriavel que ira recer o claculo

                    Peso = Convert.ToDouble(txtPeso.Text);//Convertemos string digitada em double
                    Altura = Convert.ToDouble(txtAltura.Text);//Convertemos string digitada em double


                    IMC = Peso / (Altura * Altura); //Calculando o IMC

                    txtResultado.Text = Convert.ToString(Math.Round(IMC, 2));//convertendo IMC para texto
                    //Match. Roud  usado para aredondar o numero a 2 casas demiciais


                    if (IMC < 18.5)
                    {
                        //Vericando se o IMC é menor que 18,5
                         lblSituacao.Text = ("O Seu IMC aponta MAGREZA");
                         return;
                    }

                    if ((IMC >= 18.5) & (IMC < 25))
                    {
                        //Verificando se o IMC esta entre 18,5 e 24,9
                        lblSituacao.Text = ("Parabéns ... Seu IMC Aponta Peso NORMAL");
                        return;
                    }

                    if ((IMC >= 25) & (IMC <= 30))
                    {
                        //Verificando se o IMC esta entre 25 e 30

                        lblSituacao.Text = ("Atenção ... Seu IMC aponta SOBREPESO");
                        return;
                    }

                    else {

                        lblSituacao.Text = ("Muita Atenção ... Seu IMC aponta OBESIDADE");
                        return;
                          }



                }//else

            }//try
            catch 
            {

                MessageBox.Show("Erro nos Valores Digitados");

                txtAltura.Clear();//Limpar a textbox Altura
                txtPeso.Clear();//Limpar a textbox Peso
                return;

            
            }//catch
            

        }

        private void lblSituacao_Click(object sender, EventArgs e)
        {

        }
    }
}
