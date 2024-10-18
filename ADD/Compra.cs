using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD
{
    public class Compra
    {
        public int id {  get; set; }
        [DisplayName("ID do Produto")] public int idProduto { get; set; }
        [DisplayName("ID do Fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de Desconto")] public float desconto { get; set; }
        [DisplayName("Preço Unitario")] public float precoUt { get; set; }
        [DisplayName("Preço Total ")] public float precpTL { get; set; }
        [DisplayName("Total do Desconto")] public float totalD { get; set; }

    }
}
