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
    public partial class Form1 : Form
    {
        private List<DTOSolicitacaoDeMudanca> _listaSolicitacoes = new List<DTOSolicitacaoDeMudanca>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forms = new Form2(this, _listaSolicitacoes);
            forms.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this, _listaSolicitacoes);
            form3.Show();
            this.Hide();
        }
    }
}
