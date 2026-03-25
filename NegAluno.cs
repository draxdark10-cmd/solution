using AcessoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class NegAluno
    {
        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        public bool InserirAluno(Aluno aluno)
        {
            try
            {


                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new Microsoft.Data.SqlClient.SqlParameter("@Nome", aluno.Nome));

                string comandoSql = "exec uspInserirAluno";
                object resultado = sqlServer.ExecutarScalar(comandoSql, CommandType.StoredProcedure);
                if (resultado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir aluno: " + ex.Message);
            }
        }
        public bool AtualizarAluno(Aluno aluno)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new Microsoft.Data.SqlClient.SqlParameter("@ID", aluno.ID));
                sqlServer.AdicionarParametro(new Microsoft.Data.SqlClient.SqlParameter("@Nome", aluno.Nome));

                string comandoSql = "exec uspAtualizarAluno";
                object resultado = sqlServer.ExecutarScalar(comandoSql, CommandType.StoredProcedure);
                if (resultado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar aluno: " + ex.Message);
            }
        }



        public bool ExluirAluno(int id)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new Microsoft.Data.SqlClient.SqlParameter("@ID", id));

                string comandoSql = "exec uspExcluirAluno";
                object resultado = sqlServer.ExecutarScalar(comandoSql, CommandType.StoredProcedure);
                if (resultado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir aluno: " + ex.Message);
            }
        }
        public List<Aluno> BuscarAluno(string nome)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new Microsoft.Data.SqlClient.SqlParameter("@nomeABuscar", nome));
                
                string comandoSql = "uspBuscarAlunoPorNome";
                
                DataTable data = sqlServer.ExecutarConsulta(comandoSql, CommandType.StoredProcedure);
                
                List<Aluno> alunos = new List<Aluno>();
                Aluno aluno = new Aluno();

                foreach (DataRow linha in data.Rows)
                {
                    aluno = new Aluno();
                    aluno.ID = Convert.ToInt32(linha["ID"]);
                    aluno.Nome = Convert.ToString(linha["Nome"]);
                    alunos.Add(aluno);
                }
                return alunos ?? new List<Aluno>();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar aluno por nome: " + ex.Message);
            }
        }
    }
}
