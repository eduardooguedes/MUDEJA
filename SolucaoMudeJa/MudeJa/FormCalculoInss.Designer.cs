using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	 partial class Form2 : Form
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
				this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
				this.txtBoxRelato = new System.Windows.Forms.RichTextBox();
				this.textBoxCPF = new System.Windows.Forms.TextBox();
				this.txtBoxEmail = new System.Windows.Forms.TextBox();
				this.label4 = new System.Windows.Forms.Label();
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
				// txtBoxRelato
				// 
				this.txtBoxRelato.Location = new System.Drawing.Point(77, 94);
				this.txtBoxRelato.Name = "txtBoxRelato";
				this.txtBoxRelato.Size = new System.Drawing.Size(251, 96);
				this.txtBoxRelato.TabIndex = 5;
				this.txtBoxRelato.Text = "";
				// 
				// textBoxCPF
				// 
				this.textBoxCPF.Location = new System.Drawing.Point(77, 229);
				this.textBoxCPF.Name = "textBoxCPF";
				this.textBoxCPF.Size = new System.Drawing.Size(251, 20);
				this.textBoxCPF.TabIndex = 7;
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
				this.Controls.Add(this.label4);
				this.Controls.Add(this.txtBoxEmail);
				this.Controls.Add(this.textBoxCPF);
				this.Controls.Add(this.txtBoxRelato);
				this.Controls.Add(this.comboBoxProdutos);
				this.Controls.Add(this.txtID);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
				this.Name = "Form2";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label txtID;
		  private System.Windows.Forms.ComboBox comboBoxProdutos;
		  private System.Windows.Forms.RichTextBox txtBoxRelato;
		  private System.Windows.Forms.TextBox textBoxCPF;
		  private System.Windows.Forms.TextBox txtBoxEmail;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Label labelErroCPF;
	 }
}