using System;

namespace DTO
{
    public class ReceitaDTO
    {
        #region Atributos
        private int id;
        private string descricao;
        private string valor;
        private string descCategoria;
        private int categoriaReceita;
        private string descConta;
        private int conta;
        private DateTime dataVencimento;
        private string observacao;
        #endregion

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Valor { get => valor; set => valor = value; }
        public int CategoriaReceita { get => categoriaReceita; set => categoriaReceita = value; }
        public int Conta { get => conta; set => conta = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string DescCategoria { get => descCategoria; set => descCategoria = value; }
        public string DescConta { get => descConta; set => descConta = value; }
        #endregion
    }
}
