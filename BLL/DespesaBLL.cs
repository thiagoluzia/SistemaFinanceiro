using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DespesaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable data = new DataTable();


        #region Inserir
        public void Inserir(DespesaDTO dto)
        {
            dto.Descricao.Trim();
            string descricao = dto.Descricao.Replace("'", "''");

            string valor = dto.Valor.Replace(",", ".");

            dto.Observacao.Trim();
            string observacao = dto.Observacao.Replace("'", "''");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO despesa(desc_despesa, valor, id_categoria_despesa, id_conta, data_vencimento, observacao) VALUES('" + descricao + "', '" + valor + "', '" + dto.CategoriaDespesa + "', '" + dto.Conta + "', '" + dto.DataVencimanto.ToString("yyyy-MM-dd") + "', '" + observacao + "')";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Exibir trazendo dados de 3 tabelas com o uso de INNER JOIN
        public DataTable Exibir()
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT despesa.id, despesa.desc_despesa as 'DESPESA', despesa.valor as 'VALOR', categoria_despesa.id as 'ID CATEGORIA', categoria_despesa.desc_categoria_despesa as 'CATEGORIA', conta.id as 'CONTA ID', conta.desc_conta as 'CONTA', despesa.data_vencimento as 'VENCIMENTO', despesa.observacao as 'OBSERVAÇÃO' " +
                "FROM despesa " +
                "INNER JOIN categoria_despesa ON categoria_despesa.id = despesa.id_categoria_despesa " +
                "INNER JOIN conta ON conta.id = despesa.id_conta " +
                "ORDER BY despesa.id DESC";

            data = new DataTable();
            data = banco.RetdataTable(comando);
            return data;
        }

        public DataTable ExibirMes(string data)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT despesa.id, despesa.desc_despesa as 'DESPESA', despesa.valor as 'VALOR', " +
                "categoria_despesa.id as 'ID CATEGORIA', categoria_despesa.desc_categoria_despesa as 'CATEGORIA', " +
                "conta.id as 'CONTA ID', conta.desc_conta as 'CONTA', despesa.data_vencimento as 'VENCIMENTO', " +
                "despesa.observacao as 'OBSERVAÇÃO' " +
                "FROM despesa " +
                "INNER JOIN categoria_despesa ON categoria_despesa.id = despesa.id_categoria_despesa " +
                "INNER JOIN conta ON conta.id = despesa.id_conta " +
                "WHERE convert(char(2),month(data_vencimento)) = '" + data + "'" +
                "ORDER BY despesa.id ASC";
            DataTable datat = new DataTable();
            datat = banco.RetdataTable(comando);
            return datat;
        }
        #endregion

        #region Atualizar
        public void Atualizar(DespesaDTO dto)
        {
            dto.Descricao.Trim();
            string descricao = dto.Descricao.Replace("'", "''");

            string valor = dto.Valor.Replace(",", ".");

            dto.Observacao.Trim();
            string observacao = dto.Observacao.Replace("'", "''");

            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE despesa SET desc_despesa = '" + dto.Descricao + "', valor = '" + valor + "', id_categoria_despesa = '" + dto.CategoriaDespesa + "', id_conta = '" + dto.Conta + "', data_vencimento = '" + dto.DataVencimanto.ToString("yyyy-MM-dd") + "', observacao = '" + observacao + "' WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Excluir
        public void Exluir(DespesaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM despesa WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Buscar por nome
        public DataTable Buscar(string descricao)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT despesa.id, despesa.desc_despesa as 'DESPESA', despesa.valor as 'VALOR', categoria_despesa.id as 'ID CATEGORIA', categoria_despesa.desc_categoria_despesa as 'CATEGORIA', conta.id as 'CONTA ID', conta.desc_conta as 'CONTA', despesa.data_vencimento as 'VENCIMENTO', despesa.observacao as 'OBSERVAÇÃO' " +
                "FROM despesa " +
                "INNER JOIN categoria_despesa ON categoria_despesa.id = despesa.id_categoria_despesa " +
                "INNER JOIN conta ON conta.id = despesa.id_conta " +
                "WHERE despesa.desc_despesa LIKE '%" + descricao + "%'" +
                "ORDER BY despesa.id DESC";
            data = banco.RetdataTable(comando);
            return data;
        }
        #endregion
    }
}
