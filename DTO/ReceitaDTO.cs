using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReceitaDTO
    {
        #region Atributos
        private int id;
        private string descricao;
        private double valor;
        private List<CategoriaReceitaDTO> categoriaReceita;
        private List<ContaDTO> listConta;
        private DateTime dataVencimento;
        private string observacao;
        #endregion

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public List<CategoriaReceitaDTO> CategoriaReceita { get => categoriaReceita; set => categoriaReceita = value; }
        public List<ContaDTO> ListConta { get => listConta; set => listConta = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        #endregion
    }
}
