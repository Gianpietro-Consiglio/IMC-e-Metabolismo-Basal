using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace novo_teste
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.botaoNumerico);
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string nome, converter, converter2;
            int idade;
            float  peso, altura, altura2, total;
            double total2;
                           
                
            

            nome = textBox1.Text;
            idade = int.Parse(textBox2.Text);
            peso = float.Parse(textBox3.Text);
            altura = float.Parse(textBox4.Text);
            total =  peso / (altura * altura);
            textBox5.Text = Math.Round(total, 1).ToString();
            

            // IMC
            if (total < 18.5)
            {
                pictureBox1.Image = Properties.Resources.magro;
                textBox7.Text = "Abaixo do Peso";
                richTextBox1.Text = nome + ", crie o hábito de fazer musculação para ganhar mais massa magra!";

            }

            else if (total > 18.4 && total < 24.9)
            {
                pictureBox1.Image = Properties.Resources.normal;
                textBox7.Text = "Peso normal";
                richTextBox1.Text = nome + ", parabéns, continue assim!";

            }

            else if (total > 24.9 && total < 29.9)
            {
                pictureBox1.Image = Properties.Resources.sobrepeso;
                textBox7.Text = "Sobrepeso";
                richTextBox1.Text = nome + ", não está tão ruim, tente fazer mais atividade física!";

            }

            else if (total > 29.9 && total < 34.9)
            {
                pictureBox1.Image = Properties.Resources.obesidade_;
                textBox7.Text = "Obesidade 1";
                richTextBox1.Text = nome + ", tente fazer um pouco mais de atividade física!";

            }

            else if (total > 34.9 && total < 39.9)
            {
                pictureBox1.Image = Properties.Resources.obesidade_;
                textBox7.Text = "Obesidade 2";
                richTextBox1.Text = nome + ", cuidado, tente se alimentar melhor e fazer atividades físicas!";

            }

            else
            {
                pictureBox1.Image = Properties.Resources.obesidade_;
                textBox7.Text = "Obesidade 3";
                richTextBox1.Text = nome + ", tome cuidado, é necessário fazer atividade física e se alimentar melhor!";
            }

            converter = altura.ToString();
            converter2 = peso.ToString();
            if (converter.Contains(","))
            {
                

            }

            else
            {
                MessageBox.Show("Utilize a altura com vírgula!");
                textBox4.Clear();
                return;
            }

            if (converter2.Contains(","))
            {

            }

            else
            {
                MessageBox.Show("Utilize o peso com vírgula!");
                textBox3.Clear();
                return;
            }

            





            // TAXA BASAL
            altura2 = altura * 100;
            if (radioButton7.Checked)
            {
                total2 = 66 + (13.7 * peso) + (5 * altura2) - (6.8 * idade);
                textBox6.Text = Math.Round(total2, 1).ToString();
            }

           
            else
            {
                total2 = 665 + (9.6 * peso) + (1.8 * altura2) - (4.7 * idade);
                textBox6.Text = Math.Round(total2, 1).ToString();
            }

            audio.Play();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }
    }
}
