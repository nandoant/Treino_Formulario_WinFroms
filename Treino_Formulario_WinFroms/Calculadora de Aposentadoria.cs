using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino_Formulario_WinFroms
{
    public partial class Form1 : Form
    {
        String nome;
        String dataNascimento;
        String cpf;
        String dataAtual = DateTime.Now.ToString().Split(' ')[0];

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

    //Anos de Contribuição
        private void label_TempContrib_Click(object sender, EventArgs e)
        {

        }

        private void mTxtBox_AnosContrib_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        //Confirmação
        private void btn_Confirmed_Click_1(object sender, EventArgs e)
        {

            if (validateInputNome() && validateInputData() && validateInputTempContrib() && validadeInputSex())
            {
                int idadeRestante;
                int contribRestante = (35 - int.Parse(mTxtBox_AnosContrib.Text)) < 0 ? 0 : (35 - int.Parse(mTxtBox_AnosContrib.Text));
                int dif = 0;

                if (radioBtn_Masc.Checked)
                {
                    dif = 65 - getInputIdade();
                }

                if (radioButton_Fem.Checked)
                {
                    dif = 60 - getInputIdade();
                    
                }
                idadeRestante = dif < 0 ? 0 : dif;

                MessageBox.Show($"Caro(a) {textBox_Nome.Text}, faltam {idadeRestante} anos para sua aposentadoria por idade e {contribRestante} anos de contribuição");

            }
        }

        private bool validadeInputSex()
        {
            label_Sexo.Text = "Sexo";
            if(!radioBtn_Masc.Checked && !radioButton_Fem.Checked)
            {
                label_Sexo.Text += " (Selecione uma opção)";
                return false;
            }
            return true;
        }

        private bool validateInputTempContrib()
        {
            try
            {
                label_TempContrib.Text = "Anos de Contribuição";
                if (int.TryParse(mTxtBox_AnosContrib.Text, out int anosContrib))
                {
                    if (anosContrib > 0 && anosContrib < getInputIdade() - 16)
                    {
                        return true;
                    }
                }
                label_TempContrib.Text += " (Invalido)";
                return false;
            } catch
            {
                return false;
            }
        }

        private int getInputIdade()
        {
            try
            {
                int anoAtual = getAnoAtual();
                int anoInput = int.Parse(getInputData().Split('/')[2]);
                return anoAtual - anoInput;
            } catch
            {
                throw new Exception("");
            }
        }

        private bool validateInputNome()
        {
            label_nome.Text = "Nome";

            String nome = textBox_Nome.Text.Trim();
            nome = Regex.Replace(nome, "[^A-Za-zÀ-ÖØ-öø-ÿ]+", "");

            if (nome.Length <= 0)
            {
                label_nome.Text += " (Invalido)";
                return false;
            }
            return true;
        }

        //aux
        private int getAnoAtual()
        {
            int ano = int.Parse(dataAtual.Split('/')[2]);
            return ano;
        }

        private String getInputData()
        {
            return mTxtBox_DataNascimento.Text;
        }

        private Boolean validateInputData()
        {
            label_DataNascimento.Text = "Data de Nascimento";
            if(validateInputDia() && validateInputMes() && validateInputAno())
            {
                return true;
            }
            return false;

        }

        private Boolean validateInputDia()
        {
            if (int.TryParse(mTxtBox_DataNascimento.Text.Split('/')[0], out int dia))
            {
                if (dia > 0 && dia < 31)
                {
                    return true;
                }
            }
            label_DataNascimento.Text += " (Dia Invalido)";
            return false;
        }

        private Boolean validateInputMes()
        {
            if (int.TryParse(mTxtBox_DataNascimento.Text.Split('/')[1], out int mes))
            {
                if (mes > 0 && mes < 13)
                {
                    return true;
                }
            }
            label_DataNascimento.Text += " (Mes Invalido)";
            return false;
        }

        private Boolean validateInputAno()
        {
            if (int.TryParse(mTxtBox_DataNascimento.Text.Split('/')[2], out int ano))
            {
                if (ano > 0 && ano < getAnoAtual())
                {
                    return true;
                }
            }
            label_DataNascimento.Text += " (Ano Invalido)";
            return false;
        }

        /*private int difInputDataEAnoAtual()
        {
            if()

            return 0;
        }
        */
        //Outros

        private void form_Formulario_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
