using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    public enum StatusDecisao{ ABERTO, APROVADO, REJEITADO, ADIADO }

    public class DTOSolicitacaoDeMudanca
    {
        public string ID { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Produto { get; set; }
        public string Relato { get; set; }
        public string CPFSolicitante { get; set; }
        public string EmailFuncionarioQueRecebeu { get; set; }
        public StatusDecisao StatusDecisao { get; set; }
    }
}
