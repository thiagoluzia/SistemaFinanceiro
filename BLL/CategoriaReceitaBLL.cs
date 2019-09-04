using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class CategoriaReceitaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable dt = new DataTable();

        #region Inserir
        public void Inserir(CategoriaReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO categoria_receita(des_categoria_receita) VALUES('" + dto.Descricao + "')";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Exibir
        public DataTable Exibir()
        {
            dt = new DataTable();
            banco.Conectar();
            string comando = "SELECT * FROM categoria_receita ";
            dt = banco.RetdataTable(comando);
            return dt;
        }
        #endregion

        #region Atualizar
        public void Atualizar(CategoriaReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE categoria_receita SET des_categoria_receita = '" + dto.Descricao + "' WHERE Id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Excluir
        public void Excluir(CategoriaReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM categoria_receita WHERE Id = '"+dto.Id+"'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion
    }
}
