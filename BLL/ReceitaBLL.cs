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

        public void Inserir(ReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "INSERT INTO receita(desc_receita, valor, id_categoria_receita, id_conta, data_vencimento, observacao) VALUES('"+dto.Descricao+"','"+dto.Valor+"','"+dto.CategoriaReceita+"', '"+dto.Conta+"', '"+dto.DataVencimento+"', '"+dto.Observacao+"')";
            banco.ExecutarComandoSql(comando);
        }
        public DataTable Exibir()
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT * FROM receita";
            data = new DataTable();
            data=banco.RetdataTable(comando);
            return data;
        }
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
        public void Excluir(ReceitaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "DELETE FROM receita WHERE id = '" + dto.Id + "'";
            banco.ExecutarComandoSql(comando);
        }
    }
}
