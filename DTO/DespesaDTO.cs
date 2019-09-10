using System;

namespace DTO
{
    public class DespesaDTO
    {
        #region Atributos
        private int id;
        private string descricao;
        private string valor;
        private string descCategoria;
        private int categoriaDespesa;
        private string descConta;
        private int conta;
        private DateTime dataVencimanto;
        private string observacao;
        #endregion

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Valor { get => valor; set => valor = value; }
        public string DescCategoria { get => descCategoria; set => descCategoria = value; }
        public int CategoriaDespesa { get => categoriaDespesa; set => categoriaDespesa = value; }
        public string DescConta { get => descConta; set => descConta = value; }
        public int Conta { get => conta; set => conta = value; }
        public DateTime DataVencimanto { get => dataVencimanto; set => dataVencimanto = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        #endregion
    }
}
