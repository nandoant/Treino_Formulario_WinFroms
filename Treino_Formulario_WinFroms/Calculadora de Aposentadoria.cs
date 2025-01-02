using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino_Formulario_WinFroms
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

     //===== HEADER =====
        //Tamanho texto
        private void LinkLabel_aPlus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control crtl in form_Formulario.Controls)
                crtl.Font = new Font(crtl.Font.FontFamily, crtl.Font.Size + 1, crtl.Font.Style);
        }
        private void LinkLabel_aMinus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control crtl in form_Formulario.Controls)
                crtl.Font = new Font(crtl.Font.FontFamily, crtl.Font.Size - 1, crtl.Font.Style);
        }

        //Estilo da Fonte
        private void checkBox_Italico_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control crtl in form_Formulario.Controls)
            {
                if(checkBox_Italico.Checked)
                    crtl.Font = new Font(crtl.Font.FontFamily, crtl.Font.Size, crtl.Font.Style | FontStyle.Italic);
                else
                    crtl.Font = new Font(crtl.Font.FontFamily, crtl.Font.Size, crtl.Font.Style & ~FontStyle.Italic);
            }
                
        }

        private void checkBox_Negrito_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control crtl in form_Formulario.Controls)
            {
                if (checkBox_Negrito.Checked)
                    crtl.Font = new Font(crtl.Font.FontFamily, crtl.Font.Size, crtl.Font.Style | FontStyle.Bold);
                else
                    crtl.Font = new Font(crtl.Font.FontFamily, crtl.Font.Size, crtl.Font.Style & ~FontStyle.Bold);
            }
        }

        //===== FORM =====

        //Nome
        private void label_nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        //Data de nascimento
        private void label_DataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void mTxtBox_DataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        //CPF

        private void label_CPF_Click(object sender, EventArgs e)
        {

        }

        private void mTxtBox_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Sexo
        private void label_Sexo_Click(object sender, EventArgs e)
        {

        }

        private void radioBtn_Masc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Fem_CheckedChanged(object sender, EventArgs e)
        {

        }


        //Confirmação
        private void btn_Confirmed_Click_1(object sender, EventArgs e)
        {

        }

        //Outros

        private void form_Formulario_Enter(object sender, EventArgs e)
        {

        }


    }
}
