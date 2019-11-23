using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AcessoBancoDados
    {
        DataTable data;
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        SqlConnection conn;


        #region Procedimento de conexao com o banco
        public void Conectar()
        {
            if (conn != null)
                conn.Close();
            string stringConexao = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projetos\SistemaFinanceiro\SistemaFinanceiro\Banco\Financeiro.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                conn = new SqlConnection(stringConexao);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecatr ao banco de dados: " + ex.Message);
            }

        }
        #endregion

        #region Procedimento de execucao de comandos sql no banco
        public void ExecutarComandoSql(string comandoSql)
        {
            try
            {
                SqlCommand comando = new SqlCommand(comandoSql, conn);
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao executar uma intrução Sql " + ex.Message);
            }
        }
        #endregion

        #region Metodo que retorna uma tabela de dados do banco
        public DataTable RetdataTable(string comandoSql)
        {
            try
            {
                data = new DataTable();
                da = new SqlDataAdapter(comandoSql, conn);
                cb = new SqlCommandBuilder(da);
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao retornar os dados de uma tabela " + ex.Message);
            }   
        }
        #endregion

        #region Metodo que retorna dados do banco para leitura
        public SqlDataReader RetDataReader(string comandoSql)
        {
            try
            {
                SqlCommand comando = new SqlCommand(comandoSql, conn);
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                return dr;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao efetuar uma leitura o banco de dados" + ex.Message);
            }
           
        }
        #endregion
    }
}
