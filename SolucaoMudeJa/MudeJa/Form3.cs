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
    public partial class Form3 : Form
    {
        private Form1 _form;
        private List<DTOSolicitacaoDeMudanca> _listaMudancas;
        public Form3(Form1 form, List<DTOSolicitacaoDeMudanca> listaMudancas)
        {
            _form = form;
            _listaMudancas = listaMudancas;
            InitializeComponent();
        }

    }
}
