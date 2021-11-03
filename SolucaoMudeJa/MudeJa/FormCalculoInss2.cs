using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	 public partial class FormCalculoInss2 : Form
	 {
		  public FormCalculoInss2()
		  {
				InitializeComponent();
		  }

		  private void textBoxSalario_TextChanged(object sender, EventArgs e)
		  {
				labelErroSalario.Visible = false;
				string texto = textBoxSalario.Text;
		  }

		  private void calculoInss(double salario)
		  {
				double acumulado = salario > 0.0 ? calcularInss(salario) : 0.0;
				double total = salario - acumulado;
				Console.Write(acumulado);

				textBoxSalarioAtual.Text = salario.ToString("F2", CultureInfo.InvariantCulture);
				textBoxNome.Text = "Junior";
				textBoxInss.Text = acumulado.ToString("F2", CultureInfo.InvariantCulture);
				textBoxTotal.Text = total.ToString("F2", CultureInfo.InvariantCulture);

		  }

		  private double calcularInss(double salario)
		  {
				double[] faixaDaBaseDeCalculo = { 1903.98, 2826.65, 3751.05, 4664.68 };
				double[] aliquotas = { 0, 7.5, 15, 22.5, 27.5 };
				double acumulado = 0.0;

				if(salario < faixaDaBaseDeCalculo[0])
				{
					 return acumulado;
				}

				if(salario < faixaDaBaseDeCalculo[1])
				{
					 var diferenca = salario - faixaDaBaseDeCalculo[0];
					 acumulado += diferenca * aliquotas[1] / 100;
					 return acumulado;
				}

				if(salario < faixaDaBaseDeCalculo[2])
				{
					 var diferenca = salario - faixaDaBaseDeCalculo[1];
					 acumulado += (diferenca * aliquotas[2] / 100);
					 acumulado += (922.67 * aliquotas[1] / 100);
					 return acumulado;
				}

				if(salario < faixaDaBaseDeCalculo[3])
				{
					 var diferenca = salario - faixaDaBaseDeCalculo[2];
					 acumulado += (diferenca * aliquotas[3] / 100);
					 acumulado += (924.40 * aliquotas[2] / 100);
					 acumulado += (922.67 * aliquotas[1] / 100);
					 return acumulado;
				}

				if(salario > faixaDaBaseDeCalculo[3])
				{
					 var diferenca = salario - faixaDaBaseDeCalculo[3];
					 acumulado += (diferenca * aliquotas[4] / 100);
					 acumulado += (913.63 * aliquotas[3] / 100);
					 acumulado += (924.40 * aliquotas[2] / 100);
					 acumulado += (922.67 * aliquotas[1] / 100);
				}

				return acumulado;
		  }

		  private void buttonConfirmar_Click(object sender, EventArgs e)
		  {
				try
				{
					 double.TryParse(textBoxSalario.Text, out double result);
					 calculoInss(result);
				}
				catch (Exception ex)
				{
					 labelErroSalario.Visible = true;
				}

		  }

		  private void textBoxSalarioAtual_TextChanged(object sender, EventArgs e)
		  {

		  }
	 }
}
