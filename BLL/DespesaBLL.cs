﻿using DAL;
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
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO despesa(desc_despesa, valor, id_categoria_despesa, id_conta, data_vencimento, observacao) VALUES('" + dto.Descricao + "', '" + dto.Valor + "', '" + dto.CategoriaDespesa + "', '" + dto.Conta + "', '" + dto.DataVencimanto + "', '" + dto.Observacao + "')";
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
        #endregion

        #region Atualizar
        public void Atualizar(DespesaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE despesa SET desc_despesa = '" + dto.Descricao + "', valor = '" + dto.Valor + "', id_categoria_despesa = '" + dto.CategoriaDespesa + "', id_conta = '" + dto.Conta + "', data_vencimento = '" + dto.DataVencimanto + "', observacao = '" + dto.Observacao + "' WHERE id = '" + dto.Id + "'";
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

        #region Procedimento remover espaços

        #endregion
    }
}
