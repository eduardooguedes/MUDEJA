using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	 public partial class Form2 : Form
	 {
		  private Form _form1;
		  private List<DTOSolicitacaoDeMudanca> _listaSolicitacoes;
		  private int idAtual = 15660;

		  public Form2(Form form1, List<DTOSolicitacaoDeMudanca> listaSolicitacoes)
		  {
				_form1 = form1;
				_listaSolicitacoes = listaSolicitacoes;
				InitializeComponent();
				txtID.Text = "ID: " + idAtual.ToString();
				//txtDataCriacao.Text = "Data de criação: " + DateTime.Now.ToString("d");
				labelErroCPF.Visible = false;
		  }

		  private void buttonCancelar_Click(object sender, EventArgs e)
		  {
				_form1.Show();
				this.Close();
		  }

		  private void buttonConfirmar_Click(object sender, EventArgs e)
		  {
				idAtual++;

				if (CrossCuttingValidadores.ValidadorDeCPF.CPFValido(textBoxCPF.Text))
				{
					 _listaSolicitacoes.Add(new DTOSolicitacaoDeMudanca()
					 {
						  ID = idAtual.ToString(),
						  DataSolicitacao = DateTime.Now,
						  Produto = comboBoxProdutos.Text,
						  Relato = txtBoxRelato.Text,
						  CPFSolicitante = textBoxCPF.Text,
						  EmailFuncionarioQueRecebeu = txtBoxEmail.Text,
						  StatusDecisao = StatusDecisao.ABERTO
					 });
					 _form1.Show();
					 this.Hide();
				}
				else
				{
					 labelErroCPF.Visible = true;
				}
		  }

		  private void textBoxCPF_TextChanged(object sender, EventArgs e)
		  {
				labelErroCPF.Visible = false;
		  }
	 }
}
