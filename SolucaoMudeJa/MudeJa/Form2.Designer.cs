namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
				this.txtID = new System.Windows.Forms.Label();
				this.txtDataCriacao = new System.Windows.Forms.Label();
				this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
				this.label1 = new System.Windows.Forms.Label();
				this.txtBoxRelato = new System.Windows.Forms.RichTextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.textBoxCPF = new System.Windows.Forms.TextBox();
				this.label3 = new System.Windows.Forms.Label();
				this.txtBoxEmail = new System.Windows.Forms.TextBox();
				this.label4 = new System.Windows.Forms.Label();
				this.txtStatusDecisao = new System.Windows.Forms.Label();
				this.buttonConfirmar = new System.Windows.Forms.Button();
				this.buttonCancelar = new System.Windows.Forms.Button();
				this.labelErroCPF = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// txtID
				// 
				this.txtID.AutoSize = true;
				this.txtID.Location = new System.Drawing.Point(12, 9);
				this.txtID.Name = "txtID";
				this.txtID.Size = new System.Drawing.Size(21, 13);
				this.txtID.TabIndex = 0;
				this.txtID.Text = "ID:";
				// 
				// txtDataCriacao
				// 
				this.txtDataCriacao.AutoSize = true;
				this.txtDataCriacao.Location = new System.Drawing.Point(13, 31);
				this.txtDataCriacao.Name = "txtDataCriacao";
				this.txtDataCriacao.Size = new System.Drawing.Size(86, 13);
				this.txtDataCriacao.TabIndex = 1;
				this.txtDataCriacao.Text = "Data de criação:";
				// 
				// comboBoxProdutos
				// 
				this.comboBoxProdutos.FormattingEnabled = true;
				this.comboBoxProdutos.Items.AddRange(new object[] {
            "",
            "Instagram",
            "Facebook"});
				this.comboBoxProdutos.Location = new System.Drawing.Point(77, 54);
				this.comboBoxProdutos.Name = "comboBoxProdutos";
				this.comboBoxProdutos.Size = new System.Drawing.Size(251, 21);
				this.comboBoxProdutos.TabIndex = 2;
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(13, 54);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(44, 13);
				this.label1.TabIndex = 3;
				this.label1.Text = "Produto";
				// 
				// txtBoxRelato
				// 
				this.txtBoxRelato.Location = new System.Drawing.Point(77, 94);
				this.txtBoxRelato.Name = "txtBoxRelato";
				this.txtBoxRelato.Size = new System.Drawing.Size(251, 96);
				this.txtBoxRelato.TabIndex = 5;
				this.txtBoxRelato.Text = "";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(13, 97);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(38, 13);
				this.label2.TabIndex = 6;
				this.label2.Text = "Relato";
				// 
				// textBoxCPF
				// 
				this.textBoxCPF.Location = new System.Drawing.Point(77, 229);
				this.textBoxCPF.Name = "textBoxCPF";
				this.textBoxCPF.Size = new System.Drawing.Size(251, 20);
				this.textBoxCPF.TabIndex = 7;
				this.textBoxCPF.TextChanged += new System.EventHandler(this.textBoxCPF_TextChanged);
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(12, 204);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(79, 13);
				this.label3.TabIndex = 8;
				this.label3.Text = "CPF Solicitante";
				// 
				// txtBoxEmail
				// 
				this.txtBoxEmail.Location = new System.Drawing.Point(77, 273);
				this.txtBoxEmail.Name = "txtBoxEmail";
				this.txtBoxEmail.Size = new System.Drawing.Size(251, 20);
				this.txtBoxEmail.TabIndex = 9;
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(12, 257);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(86, 13);
				this.label4.TabIndex = 10;
				this.label4.Text = "Email recebedor:";
				// 
				// txtStatusDecisao
				// 
				this.txtStatusDecisao.AutoSize = true;
				this.txtStatusDecisao.Location = new System.Drawing.Point(217, 9);
				this.txtStatusDecisao.Name = "txtStatusDecisao";
				this.txtStatusDecisao.Size = new System.Drawing.Size(49, 13);
				this.txtStatusDecisao.TabIndex = 11;
				this.txtStatusDecisao.Text = "Decisao:";
				// 
				// buttonConfirmar
				// 
				this.buttonConfirmar.BackColor = System.Drawing.Color.Green;
				this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.buttonConfirmar.Location = new System.Drawing.Point(253, 309);
				this.buttonConfirmar.Name = "buttonConfirmar";
				this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
				this.buttonConfirmar.TabIndex = 12;
				this.buttonConfirmar.Text = "Confirmar";
				this.buttonConfirmar.UseVisualStyleBackColor = false;
				this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
				// 
				// buttonCancelar
				// 
				this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
				this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.buttonCancelar.Location = new System.Drawing.Point(155, 309);
				this.buttonCancelar.Name = "buttonCancelar";
				this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
				this.buttonCancelar.TabIndex = 13;
				this.buttonCancelar.Text = "Cancelar";
				this.buttonCancelar.UseVisualStyleBackColor = false;
				this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
				// 
				// labelErroCPF
				// 
				this.labelErroCPF.AutoSize = true;
				this.labelErroCPF.ForeColor = System.Drawing.Color.Red;
				this.labelErroCPF.Location = new System.Drawing.Point(255, 213);
				this.labelErroCPF.Name = "labelErroCPF";
				this.labelErroCPF.Size = new System.Drawing.Size(73, 13);
				this.labelErroCPF.TabIndex = 14;
				this.labelErroCPF.Text = "* CPF inválido";
				this.labelErroCPF.Visible = false;
				// 
				// Form2
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(340, 344);
				this.Controls.Add(this.labelErroCPF);
				this.Controls.Add(this.buttonCancelar);
				this.Controls.Add(this.buttonConfirmar);
				this.Controls.Add(this.txtStatusDecisao);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.txtBoxEmail);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.textBoxCPF);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.txtBoxRelato);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.comboBoxProdutos);
				this.Controls.Add(this.txtDataCriacao);
				this.Controls.Add(this.txtID);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
				this.Name = "Form2";
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtDataCriacao;
        private System.Windows.Forms.ComboBox comboBoxProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtBoxRelato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtStatusDecisao;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
		  private System.Windows.Forms.Label labelErroCPF;
	 }
}