

using System;
using System.Collections.Generic;

namespace ChamadaWeb.Model
{
    public class Aprovacao
    {
        public string numeroDocumento { get; set; }
        public string valorTotal { get; set; }
        public string dataEmissao { get; set; }
        public string Image { get; set; }
        public string dataLiberacao{ get; set; }
        public string fornecedor { get; set; }
        public List<ItemAprovacao> itens { get; set; }


    }
}
