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
    public class CategoriaDespesaBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        DataTable dt = new DataTable();
        #region Procedimento Inserir
        public void InserirCategoria(CategoriaDespesaDTO dto)
        {
            banco.Conectar();
            banco.ExecutarComandoSql("INSERT INTO categoria_Despesa (desc_categoria_despesa) VALUES('" + dto.Descricao + "')");
        }
        #endregion

        #region Metodo Exibir
        public DataTable SelecionarCategoria()
        {
            dt = new DataTable();
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "SELECT * FROM categoria_despesa";
            dt = banco.RetdataTable(comando);
            return dt;
            
        }
        #endregion

        #region Procedimento Atualizar
        public void AtualizarCategoria(CategoriaDespesaDTO dto)
        {
            banco = new AcessoBancoDados();
            banco.Conectar();
            string comando = "UPDATE categoria_despesa SET desc_categoria_despesa = '" + dto.Descricao + "' WHERE id = '" + dto.Id + "'";
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
