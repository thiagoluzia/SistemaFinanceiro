using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class ContaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable dt = new DataTable();

        #region Inserir
        public void Inserir(ContaDTO dto)
        {
            string descricao = dto.Descricao;
            descricao.Trim();
            descricao.Replace("'", "''").Replace("  ", " ");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO conta(desc_conta) VALUES('" + descricao + "')";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Exibir
        public DataTable Exibir()
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT id, desc_conta AS 'DESCRIÇÃO' FROM conta";
            dt = new DataTable();
            dt = banco.RetdataTable(comando);
            return dt;
        }
        #endregion

        #region Atulaizar
        public void Atulaizar(ContaDTO dto)
        {
            string descricao = dto.Descricao;
            descricao.Trim();
            descricao.Replace("'", "''").Replace("  ", " ");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE conta SET desc_conta = '" + descricao + "' WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Excluir
        public void Excluir(ContaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM conta WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion
    }
}
