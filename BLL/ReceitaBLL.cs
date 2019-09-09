using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class ReceitaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable data = new DataTable();

        #region Inserir
        public void Inserir(ReceitaDTO dto)
        {
            dto.Descricao.Trim();
            string descricao = dto.Descricao.Replace("'", "''");

            dto.Observacao.Trim();
            string observacao = dto.Observacao.Replace("'", "''");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO receita(desc_receita, valor, id_categoria_receita, id_conta, data_vencimento, observacao) VALUES('" + descricao + "','" + dto.Valor + "','" + dto.CategoriaReceita + "', '" + dto.Conta + "', '" + dto.DataVencimento + "', '" + observacao + "')";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Exibir trazendo dados de 3 tabelas com o uso de INNER JOIN
        public DataTable Exibir()
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT receita.id, receita.desc_receita as 'RECEITA', receita.valor as 'VALOR', categoria_receita.Id as 'ID CATEGORIA', categoria_receita.des_categoria_receita as 'CATEGORIA', conta.id as 'CONTA ID', conta.desc_conta as 'CONTA', receita.data_vencimento as 'VENCIMENTO', receita.observacao as 'OBSERVAÇÃO' " +
                "FROM receita " +
                "INNER JOIN categoria_receita ON categoria_receita.Id = receita.id_categoria_receita " +
                "INNER JOIN conta ON conta.id = receita.id_conta " +
                "ORDER BY receita.id DESC";
            data = new DataTable();
            data = banco.RetdataTable(comando);
            return data;
        }
        #endregion

        #region Atualizar
        public void Atualizar(ReceitaDTO dto)
        {
            dto.Descricao.Trim();
            string descricao = dto.Descricao.Replace("'", "''");

            dto.Observacao.Trim();
            string observacao = dto.Observacao.Replace("'", "''");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE receita SET desc_receita = '" + descricao + "'" +
                ", valor = '" + dto.Valor + "', id_categoria_receita = '" + dto.CategoriaReceita + "'" +
                ", id_conta = '" + dto.Conta + "', data_vencimento = '" + dto.DataVencimento + "'" +
                ", observacao = '" + observacao + "' WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Excluir
        public void Excluir(ReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM receita WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Buscar por nome
        public DataTable Buscar(string descricao)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT receita.id, receita.desc_receita as 'RECEITA', receita.valor as 'VALOR', categoria_receita.Id as 'ID CATEGORIA', categoria_receita.des_categoria_receita as 'CATEGORIA', conta.id as 'CONTA ID', conta.desc_conta as 'CONTA', receita.data_vencimento as 'VENCIMENTO', receita.observacao as 'OBSERVAÇÃO' " +
                "FROM receita " +
                "INNER JOIN categoria_receita ON categoria_receita.Id = receita.id_categoria_receita " +
                "INNER JOIN conta ON conta.id = receita.id_conta " +
                "WHERE receita.desc_receita LIKE '%" + descricao + "%'" +
                "ORDER BY receita.id DESC";
            data = new DataTable();
            data = banco.RetdataTable(comando);
            return data;
        }
        #endregion
    }
}
