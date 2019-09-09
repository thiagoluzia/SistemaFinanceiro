using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class CategoriaDespesaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable dt = new DataTable();

        #region Procedimento Inserir
        public void InserirCategoria(CategoriaDespesaDTO dto)
        {
            string descricao = dto.Descricao;
            descricao.Trim();
            descricao.Replace("'", "''").Replace("  ", " ");

            banco.Conectar();
            banco.ExecutarComandoSql("INSERT INTO categoria_Despesa (desc_categoria_despesa) VALUES('" + descricao + "')");
        }
        #endregion

        #region Metodo Exibir
        public DataTable Exibir()
        {
            dt = new DataTable();
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT id, desc_categoria_despesa AS 'DESCRIÇÃO' FROM categoria_despesa";
            dt = banco.RetdataTable(comando);
            return dt;
            
        }
        #endregion

        #region Procedimento Atualizar
        public void AtualizarCategoria(CategoriaDespesaDTO dto)
        {
            string descricao = dto.Descricao;
            descricao.Trim();
            descricao.Replace("'", "''").Replace("  ", " ");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE categoria_despesa SET desc_categoria_despesa = '" + descricao + "' WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Procedimento Excluir
        public void Excluir(CategoriaDespesaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM categoria_despesa WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion
    }
}
