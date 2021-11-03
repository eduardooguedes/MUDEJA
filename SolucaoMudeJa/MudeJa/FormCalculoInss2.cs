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

				calculoInss(texto);
				
		  }

		  private void calculoInss(string texto)
		  {
				if (double.TryParse(texto, out double salario))
				{
					 double acumulado = salario > 0.0 ? calcularInss(salario) : 0.0;
					 double total = salario - acumulado;

					 textBoxSalario.Text = salario.ToString("F2", CultureInfo.InvariantCulture);
					 textBoxNome.Text = "Junior";
					 textBoxInss.Text = acumulado.ToString("F2", CultureInfo.InvariantCulture);
					 textBoxTotal.Text = total.ToString("F2", CultureInfo.InvariantCulture);
				}
				else
				{
					 labelErroSalario.Visible = true;
				}
		  }

		  private double calcularInss(double salario)
		  {
				double acumulado = 0.0;

				if (salario < 1100)
					 return acumulado += salario * 0.075;
				else
					 acumulado += 1100 * 0.075;

				if (salario < 2203.48)
					 return acumulado += (salario - 1100) * 0.09;
				else
					 acumulado += (2203.48 - 1100.01) * 0.09;

				if (salario < 3305.22)
					 return acumulado += (salario - 2203.48) * 0.075;
				else
					 acumulado += (3305.22 - 2203.49) * 0.12;

				if (salario < 6433.57)
					 return acumulado += (salario - 3305.23) * 0.14;
				else
					return acumulado += (6433.57 - 3305.23) * 0.14;
		  }

		  private void buttonConfirmar_Click(object sender, EventArgs e)
		  {
			  
		  }
	 }
}
