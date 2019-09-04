using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class ReceitaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable data = new DataTable();

        #region Inserir
        public void Inserir(ReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO receita(desc_receita, valor, id_categoria_receita, id_conta, data_vencimento, observacao) VALUES('"+dto.Descricao+"','"+dto.Valor+"','"+dto.CategoriaReceita+"', '"+dto.Conta+"', '"+dto.DataVencimento+"', '"+dto.Observacao+"')";
            banco.ExecutarComandoSql(comando);
        }
        #endregion

        #region Exibir trazendo dados de 3 tabelas com o uso de INNER JOIN
        public DataTable Exibir()
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT receita.id, receita.desc_receita as 'RECEITA', receita.valor as 'VALOR', categoria_receita.des_categoria_receita as 'CATEGORIA', conta.desc_conta as 'CONTA', receita.data_vencimento as 'VENCIMENTO', receita.observacao as 'OBSERVAÇÃO' " +
                "FROM receita " +
                "INNER JOIN categoria_receita ON categoria_receita.Id = receita.id_categoria_receita " +
                "INNER JOIN conta ON conta.id = receita.id_conta";
            data = new DataTable();
            data=banco.RetdataTable(comando);
            return data;
        }
        #endregion 
     
        #region Atualizar
        public void Atualizar(ReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE receita SET desc_receita = '" + dto.Descricao + "'" +
                ", valor = '" + dto.Valor + "', id_categoria_receita = '" + dto.CategoriaReceita + "'" +
                ", id_conta = '" + dto.Conta + "', data_vencimento = '" + dto.DataVencimento + "'" +
                ", obeservacao = '" + dto.Observacao + "' WHERE id = '"+dto.Id+"'";
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
    }
}
