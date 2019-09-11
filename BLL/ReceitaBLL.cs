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

            string valor = dto.Valor.Replace(",", ".");

            dto.Observacao.Trim();
            string observacao = dto.Observacao.Replace("'", "''");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO receita(desc_receita, valor, id_categoria_receita, id_conta, data_vencimento, observacao) " +
                "VALUES('" + descricao + "','" + valor + "','" + dto.CategoriaReceita + "', '" + dto.Conta + "', '" + dto.DataVencimento.ToString("yyyy-MM-dd") + "', '" + observacao + "')";
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
        public DataTable ExibirMes(string data)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT receita.id, receita.desc_receita  as 'RECEITA', receita.valor as 'VALOR', categoria_receita.Id as 'ID CATEGORIA', categoria_receita.des_categoria_receita as 'CATEGORIA', conta.id as 'CONTA ID', conta.desc_conta as 'CONTA', receita.data_vencimento as 'VENCIMENTO', receita.observacao as 'OBSERVAÇÃO' " +
                "FROM receita " +
                "INNER JOIN categoria_receita ON categoria_receita.Id = receita.id_categoria_receita " +
                "INNER JOIN conta ON conta.id = receita.id_conta " +
                "WHERE convert(char(2),month(data_vencimento)) = '" + data + "'" +
                "ORDER BY receita.data_vencimento ASC";
            DataTable datat = new DataTable();
            datat = banco.RetdataTable(comando);
            return datat;


           

        }
        #endregion

        #region Atualizar
        public void Atualizar(ReceitaDTO dto)
        {
            dto.Descricao.Trim();
            string descricao = dto.Descricao.Replace("'", "''");

            string valor = dto.Valor.Replace(",", ".");

            dto.Observacao.Trim();
            string observacao = dto.Observacao.Replace("'", "''");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE receita SET desc_receita = '" + descricao + "'" +
                ", valor = '" + valor + "', id_categoria_receita = '" + dto.CategoriaReceita + "'" +
                ", id_conta = '" + dto.Conta + "', data_vencimento = '" + dto.DataVencimento.ToString("yyyy-MM-dd") + "'" +
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
