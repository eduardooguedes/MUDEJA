
namespace WindowsFormsApplication1
{
	 partial class FormCalculoInss2
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
				this.label3 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.textBoxSalario = new System.Windows.Forms.TextBox();
				this.buttonCancelar = new System.Windows.Forms.Button();
				this.buttonConfirmar = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.txtDataCriacao = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.label5 = new System.Windows.Forms.Label();
				this.textBoxNome = new System.Windows.Forms.TextBox();
				this.textBoxSalarioAtual = new System.Windows.Forms.TextBox();
				this.textBoxInss = new System.Windows.Forms.TextBox();
				this.textBoxTotal = new System.Windows.Forms.TextBox();
				this.label6 = new System.Windows.Forms.Label();
				this.label7 = new System.Windows.Forms.Label();
				this.labelErroSalario = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(11, 110);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(42, 13);
				this.label3.TabIndex = 24;
				this.label3.Text = "Salário:";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(13, 33);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(72, 13);
				this.label2.TabIndex = 23;
				this.label2.Text = "Responsável:";
				// 
				// textBoxSalario
				// 
				this.textBoxSalario.Location = new System.Drawing.Point(59, 107);
				this.textBoxSalario.Name = "textBoxSalario";
				this.textBoxSalario.Size = new System.Drawing.Size(251, 20);
				this.textBoxSalario.TabIndex = 22;
				this.textBoxSalario.TextChanged += new System.EventHandler(this.textBoxSalario_TextChanged);
				// 
				// buttonCancelar
				// 
				this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
				this.buttonCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
				this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.buttonCancelar.Location = new System.Drawing.Point(147, 263);
				this.buttonCancelar.Name = "buttonCancelar";
				this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
				this.buttonCancelar.TabIndex = 21;
				this.buttonCancelar.Text = "Cancelar";
				this.buttonCancelar.UseVisualStyleBackColor = false;
				// 
				// buttonConfirmar
				// 
				this.buttonConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
				this.buttonConfirmar.BackColor = System.Drawing.Color.Green;
				this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.buttonConfirmar.Location = new System.Drawing.Point(238, 263);
				this.buttonConfirmar.Name = "buttonConfirmar";
				this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
				this.buttonConfirmar.TabIndex = 20;
				this.buttonConfirmar.Text = "Calcular";
				this.buttonConfirmar.UseVisualStyleBackColor = false;
				this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(126, 76);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(84, 13);
				this.label1.TabIndex = 19;
				this.label1.Text = "CÁLCULO INSS";
				// 
				// txtDataCriacao
				// 
				this.txtDataCriacao.AutoSize = true;
				this.txtDataCriacao.Location = new System.Drawing.Point(12, 10);
				this.txtDataCriacao.Name = "txtDataCriacao";
				this.txtDataCriacao.Size = new System.Drawing.Size(88, 13);
				this.txtDataCriacao.TabIndex = 18;
				this.txtDataCriacao.Text = "Data do relatório:";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(18, 159);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(35, 13);
				this.label4.TabIndex = 25;
				this.label4.Text = "Nome";
				// 
				// label5
				// 
				this.label5.AutoSize = true;
				this.label5.Location = new System.Drawing.Point(98, 159);
				this.label5.Name = "label5";
				this.label5.Size = new System.Drawing.Size(39, 13);
				this.label5.TabIndex = 26;
				this.label5.Text = "Salario";
				// 
				// textBoxNome
				// 
				this.textBoxNome.Location = new System.Drawing.Point(17, 175);
				this.textBoxNome.Name = "textBoxNome";
				this.textBoxNome.ReadOnly = true;
				this.textBoxNome.Size = new System.Drawing.Size(78, 20);
				this.textBoxNome.TabIndex = 27;
				// 
				// textBoxSalarioAtual
				// 
				this.textBoxSalarioAtual.Location = new System.Drawing.Point(101, 175);
				this.textBoxSalarioAtual.Name = "textBoxSalarioAtual";
				this.textBoxSalarioAtual.ReadOnly = true;
				this.textBoxSalarioAtual.Size = new System.Drawing.Size(73, 20);
				this.textBoxSalarioAtual.TabIndex = 28;
				// 
				// textBoxInss
				// 
				this.textBoxInss.Location = new System.Drawing.Point(180, 175);
				this.textBoxInss.Name = "textBoxInss";
				this.textBoxInss.ReadOnly = true;
				this.textBoxInss.Size = new System.Drawing.Size(62, 20);
				this.textBoxInss.TabIndex = 29;
				// 
				// textBoxTotal
				// 
				this.textBoxTotal.Location = new System.Drawing.Point(248, 175);
				this.textBoxTotal.Name = "textBoxTotal";
				this.textBoxTotal.ReadOnly = true;
				this.textBoxTotal.Size = new System.Drawing.Size(62, 20);
				this.textBoxTotal.TabIndex = 30;
				// 
				// label6
				// 
				this.label6.AutoSize = true;
				this.label6.Location = new System.Drawing.Point(177, 159);
				this.label6.Name = "label6";
				this.label6.Size = new System.Drawing.Size(32, 13);
				this.label6.TabIndex = 31;
				this.label6.Text = "INSS";
				// 
				// label7
				// 
				this.label7.AutoSize = true;
				this.label7.Location = new System.Drawing.Point(245, 159);
				this.label7.Name = "label7";
				this.label7.Size = new System.Drawing.Size(31, 13);
				this.label7.TabIndex = 32;
				this.label7.Text = "Total";
				// 
				// labelErroSalario
				// 
				this.labelErroSalario.AutoSize = true;
				this.labelErroSalario.ForeColor = System.Drawing.Color.Red;
				this.labelErroSalario.Location = new System.Drawing.Point(65, 130);
				this.labelErroSalario.Name = "labelErroSalario";
				this.labelErroSalario.Size = new System.Drawing.Size(123, 13);
				this.labelErroSalario.TabIndex = 33;
				this.labelErroSalario.Text = "Informe apenas números";
				this.labelErroSalario.Visible = false;
				// 
				// FormCalculoInss2
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(325, 298);
				this.Controls.Add(this.labelErroSalario);
				this.Controls.Add(this.label7);
				this.Controls.Add(this.label6);
				this.Controls.Add(this.textBoxTotal);
				this.Controls.Add(this.textBoxInss);
				this.Controls.Add(this.textBoxSalarioAtual);
				this.Controls.Add(this.textBoxNome);
				this.Controls.Add(this.label5);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.textBoxSalario);
				this.Controls.Add(this.buttonCancelar);
				this.Controls.Add(this.buttonConfirmar);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.txtDataCriacao);
				this.Name = "FormCalculoInss2";
				this.Text = "FormCalculoInss2";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.TextBox textBoxSalario;
		  private System.Windows.Forms.Button buttonCancelar;
		  private System.Windows.Forms.Button buttonConfirmar;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label txtDataCriacao;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Label label5;
		  private System.Windows.Forms.TextBox textBoxNome;
		  private System.Windows.Forms.TextBox textBoxSalarioAtual;
		  private System.Windows.Forms.TextBox textBoxInss;
		  private System.Windows.Forms.TextBox textBoxTotal;
		  private System.Windows.Forms.Label label6;
		  private System.Windows.Forms.Label label7;
		  private System.Windows.Forms.Label labelErroSalario;
	 }
}