using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "000.000.000-00";

            estadonascimento.Items.Add ("Ceará(CE)");
            estadonascimento.Items.Add ("Distrito Federal(DF)");
            estadonascimento.Items.Add ("São Paulo(SP)");
                }

        private string obterestadocivl()
        {
            if (solteiro.Checked)
            {
                return "solteiro";
            }else if (casado.Checked)
            {
                return "casado";
            }
            else if (divorciado.Checked)
            {
                return "divorciado";
            }
            else if (viuvo.Checked)
            {
                return "viuvo";
            }else
            {
                return "não especificado";
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estadocivil_CheckedChanged(object sender, EventArgs e)
        { 


        }

        private void idade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Enabled = true;
            maskedTextBox1.ReadOnly = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBox1.Text;
                string cpf = maskedTextBox1.Text;
                string estadonasc = estadonascimento.SelectedItem.ToString();
                string estdocivil = obterestadocivl();
                int idade = (int)numericUpDown1.Value;

                label1.Text = $"Nome : {nome}\nCPF: : {cpf}\nEstado Nascimento : {estadonascimento}\nEstado Civil : {estdocivil}\nIdade : {idade}\n" ;
            }catch(Exception ex)
            {
                MessageBox.Show($"ocorreu um erro: {ex.Message}", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
