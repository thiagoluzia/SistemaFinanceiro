using DAL;
using DTO;
using System.Data;

namespace BLL
{
    class UsuarioBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable data = new DataTable();

        #region Inserir
        public void Inserir(UsuarioDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO usuario(nome, sobrenome) VALUES('" + dto.Nome + "', '" + dto.Sobrenome + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Exibir
        public DataTable Exibir()
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT * FROM usuario";
            data = new DataTable();
            data = banco.RetdataTable(comando);
            return data;
        }
        #endregion

        #region Atualizar
        public void Atualizar(UsuarioDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE usuario SET nome = '" + dto.Nome + "', sobrenome = '" + dto.Sobrenome + "' WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Excluir
        public void Excluir(UsuarioDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM usuario WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion
    }
}
