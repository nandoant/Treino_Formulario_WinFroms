namespace Treino_Formulario_WinFroms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.form_Formulario = new System.Windows.Forms.GroupBox();
            this.mTxtBox_AnosContrib = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Fem = new System.Windows.Forms.RadioButton();
            this.radioBtn_Masc = new System.Windows.Forms.RadioButton();
            this.label_Sexo = new System.Windows.Forms.Label();
            this.label_DataNascimento = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.btn_Confirmed = new System.Windows.Forms.Button();
            this.mTxtBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBox_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.LinkLabel_aMinus = new System.Windows.Forms.LinkLabel();
            this.LinkLabel_aPlus = new System.Windows.Forms.LinkLabel();
            this.checkBox_Negrito = new System.Windows.Forms.CheckBox();
            this.checkBox_Italico = new System.Windows.Forms.CheckBox();
            this.label_TempContrib = new System.Windows.Forms.Label();
            this.form_Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_Formulario
            // 
            this.form_Formulario.Controls.Add(this.label_TempContrib);
            this.form_Formulario.Controls.Add(this.mTxtBox_AnosContrib);
            this.form_Formulario.Controls.Add(this.label1);
            this.form_Formulario.Controls.Add(this.radioButton_Fem);
            this.form_Formulario.Controls.Add(this.radioBtn_Masc);
            this.form_Formulario.Controls.Add(this.label_Sexo);
            this.form_Formulario.Controls.Add(this.label_DataNascimento);
            this.form_Formulario.Controls.Add(this.textBox_Nome);
            this.form_Formulario.Controls.Add(this.btn_Confirmed);
            this.form_Formulario.Controls.Add(this.mTxtBox_CPF);
            this.form_Formulario.Controls.Add(this.mTxtBox_DataNascimento);
            this.form_Formulario.Controls.Add(this.label_CPF);
            this.form_Formulario.Controls.Add(this.label_nome);
            this.form_Formulario.Location = new System.Drawing.Point(12, 28);
            this.form_Formulario.Name = "form_Formulario";
            this.form_Formulario.Size = new System.Drawing.Size(272, 333);
            this.form_Formulario.TabIndex = 0;
            this.form_Formulario.TabStop = false;
            this.form_Formulario.Text = "Formulario";
            this.form_Formulario.Enter += new System.EventHandler(this.form_Formulario_Enter);
            // 
            // mTxtBox_AnosContrib
            // 
            this.mTxtBox_AnosContrib.Location = new System.Drawing.Point(10, 214);
            this.mTxtBox_AnosContrib.Mask = "00";
            this.mTxtBox_AnosContrib.Name = "mTxtBox_AnosContrib";
            this.mTxtBox_AnosContrib.Size = new System.Drawing.Size(96, 22);
            this.mTxtBox_AnosContrib.TabIndex = 20;
            this.mTxtBox_AnosContrib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxtBox_AnosContrib.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtBox_AnosContrib_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_Fem
            // 
            this.radioButton_Fem.AutoSize = true;
            this.radioButton_Fem.Location = new System.Drawing.Point(106, 267);
            this.radioButton_Fem.Name = "radioButton_Fem";
            this.radioButton_Fem.Size = new System.Drawing.Size(83, 20);
            this.radioButton_Fem.TabIndex = 17;
            this.radioButton_Fem.TabStop = true;
            this.radioButton_Fem.Text = "Feminino";
            this.radioButton_Fem.UseVisualStyleBackColor = true;
            this.radioButton_Fem.CheckedChanged += new System.EventHandler(this.radioButton_Fem_CheckedChanged);
            // 
            // radioBtn_Masc
            // 
            this.radioBtn_Masc.AutoSize = true;
            this.radioBtn_Masc.Location = new System.Drawing.Point(11, 267);
            this.radioBtn_Masc.Name = "radioBtn_Masc";
            this.radioBtn_Masc.Size = new System.Drawing.Size(89, 20);
            this.radioBtn_Masc.TabIndex = 16;
            this.radioBtn_Masc.TabStop = true;
            this.radioBtn_Masc.Text = "Masculino";
            this.radioBtn_Masc.UseVisualStyleBackColor = true;
            this.radioBtn_Masc.CheckedChanged += new System.EventHandler(this.radioBtn_Masc_CheckedChanged);
            // 
            // label_Sexo
            // 
            this.label_Sexo.AutoSize = true;
            this.label_Sexo.Location = new System.Drawing.Point(7, 248);
            this.label_Sexo.Name = "label_Sexo";
            this.label_Sexo.Size = new System.Drawing.Size(38, 16);
            this.label_Sexo.TabIndex = 15;
            this.label_Sexo.Text = "Sexo";
            this.label_Sexo.Click += new System.EventHandler(this.label_Sexo_Click);
            // 
            // label_DataNascimento
            // 
            this.label_DataNascimento.AutoSize = true;
            this.label_DataNascimento.Location = new System.Drawing.Point(7, 82);
            this.label_DataNascimento.Name = "label_DataNascimento";
            this.label_DataNascimento.Size = new System.Drawing.Size(130, 16);
            this.label_DataNascimento.TabIndex = 14;
            this.label_DataNascimento.Text = "Data de Nascimento";
            this.label_DataNascimento.Click += new System.EventHandler(this.label_DataNascimento_Click);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(10, 44);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(241, 22);
            this.textBox_Nome.TabIndex = 13;
            this.textBox_Nome.TextChanged += new System.EventHandler(this.textBox_Nome_TextChanged);
            // 
            // btn_Confirmed
            // 
            this.btn_Confirmed.Location = new System.Drawing.Point(187, 295);
            this.btn_Confirmed.Name = "btn_Confirmed";
            this.btn_Confirmed.Size = new System.Drawing.Size(79, 29);
            this.btn_Confirmed.TabIndex = 12;
            this.btn_Confirmed.Text = "Ok";
            this.btn_Confirmed.UseVisualStyleBackColor = true;
            this.btn_Confirmed.Click += new System.EventHandler(this.btn_Confirmed_Click_1);
            // 
            // mTxtBox_CPF
            // 
            this.mTxtBox_CPF.Location = new System.Drawing.Point(10, 159);
            this.mTxtBox_CPF.Mask = "000.000.000-00";
            this.mTxtBox_CPF.Name = "mTxtBox_CPF";
            this.mTxtBox_CPF.Size = new System.Drawing.Size(96, 22);
            this.mTxtBox_CPF.TabIndex = 11;
            this.mTxtBox_CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtBox_CPF_MaskInputRejected);
            // 
            // mTxtBox_DataNascimento
            // 
            this.mTxtBox_DataNascimento.Location = new System.Drawing.Point(10, 101);
            this.mTxtBox_DataNascimento.Mask = "00/00/0000";
            this.mTxtBox_DataNascimento.Name = "mTxtBox_DataNascimento";
            this.mTxtBox_DataNascimento.Size = new System.Drawing.Size(96, 22);
            this.mTxtBox_DataNascimento.TabIndex = 10;
            this.mTxtBox_DataNascimento.ValidatingType = typeof(System.DateTime);
            this.mTxtBox_DataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtBox_DataNascimento_MaskInputRejected);
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(7, 140);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(33, 16);
            this.label_CPF.TabIndex = 8;
            this.label_CPF.Text = "CPF";
            this.label_CPF.Click += new System.EventHandler(this.label_CPF_Click);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(7, 25);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(44, 16);
            this.label_nome.TabIndex = 4;
            this.label_nome.Text = "Nome";
            this.label_nome.Click += new System.EventHandler(this.label_nome_Click);
            // 
            // LinkLabel_aMinus
            // 
            this.LinkLabel_aMinus.AutoSize = true;
            this.LinkLabel_aMinus.Location = new System.Drawing.Point(258, 9);
            this.LinkLabel_aMinus.Name = "LinkLabel_aMinus";
            this.LinkLabel_aMinus.Size = new System.Drawing.Size(20, 16);
            this.LinkLabel_aMinus.TabIndex = 2;
            this.LinkLabel_aMinus.TabStop = true;
            this.LinkLabel_aMinus.Text = "A-";
            this.LinkLabel_aMinus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_aMinus_LinkClicked);
            // 
            // LinkLabel_aPlus
            // 
            this.LinkLabel_aPlus.AutoSize = true;
            this.LinkLabel_aPlus.Location = new System.Drawing.Point(229, 9);
            this.LinkLabel_aPlus.Name = "LinkLabel_aPlus";
            this.LinkLabel_aPlus.Size = new System.Drawing.Size(23, 16);
            this.LinkLabel_aPlus.TabIndex = 3;
            this.LinkLabel_aPlus.TabStop = true;
            this.LinkLabel_aPlus.Text = "A+";
            this.LinkLabel_aPlus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_aPlus_LinkClicked);
            // 
            // checkBox_Negrito
            // 
            this.checkBox_Negrito.AutoSize = true;
            this.checkBox_Negrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Negrito.Location = new System.Drawing.Point(140, 9);
            this.checkBox_Negrito.Name = "checkBox_Negrito";
            this.checkBox_Negrito.Size = new System.Drawing.Size(40, 20);
            this.checkBox_Negrito.TabIndex = 15;
            this.checkBox_Negrito.Text = "N";
            this.checkBox_Negrito.UseVisualStyleBackColor = true;
            this.checkBox_Negrito.CheckedChanged += new System.EventHandler(this.checkBox_Negrito_CheckedChanged);
            // 
            // checkBox_Italico
            // 
            this.checkBox_Italico.AutoSize = true;
            this.checkBox_Italico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Italico.Location = new System.Drawing.Point(186, 9);
            this.checkBox_Italico.Name = "checkBox_Italico";
            this.checkBox_Italico.Size = new System.Drawing.Size(33, 20);
            this.checkBox_Italico.TabIndex = 16;
            this.checkBox_Italico.Text = "/";
            this.checkBox_Italico.UseVisualStyleBackColor = true;
            this.checkBox_Italico.CheckedChanged += new System.EventHandler(this.checkBox_Italico_CheckedChanged);
            // 
            // label_TempContrib
            // 
            this.label_TempContrib.AutoSize = true;
            this.label_TempContrib.Location = new System.Drawing.Point(8, 195);
            this.label_TempContrib.Name = "label_TempContrib";
            this.label_TempContrib.Size = new System.Drawing.Size(135, 16);
            this.label_TempContrib.TabIndex = 21;
            this.label_TempContrib.Text = "Anos de Contribuição";
            this.label_TempContrib.Click += new System.EventHandler(this.label_TempContrib_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 371);
            this.Controls.Add(this.checkBox_Italico);
            this.Controls.Add(this.checkBox_Negrito);
            this.Controls.Add(this.LinkLabel_aPlus);
            this.Controls.Add(this.LinkLabel_aMinus);
            this.Controls.Add(this.form_Formulario);
            this.Name = "Form1";
            this.Text = "Calculadora de Aposentadoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form_Formulario.ResumeLayout(false);
            this.form_Formulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox form_Formulario;
        private System.Windows.Forms.LinkLabel LinkLabel_aMinus;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.MaskedTextBox mTxtBox_CPF;
        private System.Windows.Forms.MaskedTextBox mTxtBox_DataNascimento;
        private System.Windows.Forms.Button btn_Confirmed;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.LinkLabel LinkLabel_aPlus;
        private System.Windows.Forms.Label label_DataNascimento;
        private System.Windows.Forms.CheckBox checkBox_Negrito;
        private System.Windows.Forms.CheckBox checkBox_Italico;
        private System.Windows.Forms.RadioButton radioButton_Fem;
        private System.Windows.Forms.RadioButton radioBtn_Masc;
        private System.Windows.Forms.Label label_Sexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTxtBox_AnosContrib;
        private System.Windows.Forms.Label label_TempContrib;
    }
}

