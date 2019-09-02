using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DespesaDTO
    {
        #region Atributos
        private int id;
        private string descricao;
        private List<CategoriaDespesaDTO> listCategoria;
        private List<ContaDTO> listConta;
        private DateTime dataVencimanto;
        private string observacao;
        #endregion

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public List<CategoriaDespesaDTO> ListCategoria { get => listCategoria; set => listCategoria = value; }
        public List<ContaDTO> ListConta { get => listConta; set => listConta = value; }
        public DateTime DataVencimanto { get => dataVencimanto; set => dataVencimanto = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        #endregion
    }
}
