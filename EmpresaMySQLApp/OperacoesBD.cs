using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace EmpresaMySQLApp
{
    class OperacoesBD
    {
        private string stringLigacao;
        public DataSet dsListaDeFuncionarios;

        /// <summary>;
        /// Método construtor padrão
        /// </summary>
        public OperacoesBD()
        {

            // Localizar o nome da definição da string de ligação  
            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["EmpresaMySQLApp.Properties.Settings.connString"];

            stringLigacao = settings.ConnectionString;

        }

        /// <summary>
        /// Método para realizar o teste de ligação a uma base de dados
        /// </summary>
        /// <returns></returns>
        public bool TestarLigacao()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringLigacao))
                {
                    conn.Open();
                }
            }
            catch (MySqlException)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Métdo que faz a consulta à tabela Departamentos na base de dados
        /// </summary>
        /// <returns>Devolve uma lista (classe List) com os departamentos (classe Departamento)</returns>
        public List<Departamento> ListaDeDepartamentos()
        {
            List<Departamento> lista = new List<Departamento>();
            string sql = "SELECT * FROM departamento ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringLigacao))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Departamento(reader.GetString("Id"), reader.GetString("Nome")));
                            }
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                return lista;
            }

            return lista;
        }

        /// <summary>
        /// Método responsável por colocar num DataSet (dados em memória) dados de funcionários que 
        /// constam nas tabelas da base de dados.
        /// </summary>
        /// <returns></returns>
        public bool CriaListaDeFuncionarios()
        {

           /* string sql = "SELECT funcionario.id AS Id, funcionario.nome, departamento.nome AS Departamento  " +
                         "FROM funcionario " +
                         "JOIN departamento ON funcionario.iddepartamento = departamento.id " +
                         "ORDER BY funcionario.id";*/

                                 // ou 

            string sql = "SELECT funcionario.id AS Id, funcionario.nome AS Nome, departamento.nome AS Departamento  " +
                         "FROM funcionario, departamento " +
                         "WHERE funcionario.iddepartamento = departamento.id " +
                         "ORDER BY funcionario.id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringLigacao))
                {
                    conn.Open();
                    using (MySqlDataAdapter daListaDeFuncionarios = new MySqlDataAdapter(sql, conn))
                    {
                        using(MySqlCommandBuilder cb = new MySqlCommandBuilder(daListaDeFuncionarios))
                        {
                            dsListaDeFuncionarios = new DataSet();
                            daListaDeFuncionarios.Fill(dsListaDeFuncionarios);
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                return false;
            }

            return true;
        }


  
        /// <summary>
        /// Método responsável pela inserção de um registo de funcionário na base de dados
        /// </summary>
        /// <param name="novoFuncionario">Novo funcionário</param>
        /// <returns>String um id do funcionário inserido ou erro na consulta à base de dados</returns>
        public string InsereFuncionario (Funcionario novoFuncionario)
        {
            string resultado = "";
            string sql = "INSERT INTO funcionario (iddepartamento, nome) VALUES (@iddepartamento, @nome)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringLigacao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@iddepartamento", novoFuncionario.IdDepartamento);
                        cmd.Parameters.AddWithValue("@nome", novoFuncionario.Nome);
                        cmd.ExecuteNonQuery();
                        resultado = cmd.LastInsertedId.ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Erro na consulta: " + ex.Message ;
            }
            return resultado; 
        }


        /// <summary>
        /// Método responsável pela atualização de um registo de funcionário na base de dados
        /// </summary>
        /// <param name="novoFuncionario">Novo funcionário</param>
        /// <returns>String com id do funcionário atualizado ou erro na consulta à base de dados</returns>
        public string AtualizaFuncionario(Funcionario novoFuncionario)
        {
            string resultado = " ";
            string sql = "UPDATE funcionario SET iddepartamento = @iddepartamento , nome =  @nome WHERE id = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringLigacao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@iddepartamento", novoFuncionario.IdDepartamento);
                        cmd.Parameters.AddWithValue("@nome", novoFuncionario.Nome);
                        cmd.Parameters.AddWithValue("@id", novoFuncionario.ID);
                        int resul = cmd.ExecuteNonQuery();

                        if (resul > 0)
                        {
                            resultado = "Funcionario com id " + novoFuncionario.ID.ToString() + " foi atualizado.";
                        }
                        else
                        {
                            resultado = "Funcionario com id " + novoFuncionario.ID.ToString() + " não foi atualizado.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Erro na consulta: " + ex.Message;
            }
            return resultado;
        }



        /// <summary>
        /// Método responsável por apagar um registo de funcionário da base de dados
        /// </summary>
        /// <param name="novoFuncionario">Novo funcionário</param>
        /// <returns>String o id do funcionário eliminado ou erro na consulta à base de dados</returns>
        public string ApagaFuncionario(Funcionario novoFuncionario)
        {
            string resultado = " ";
            string sql = "DELETE FROM funcionario WHERE id = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(stringLigacao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", novoFuncionario.ID);
                        int resul = cmd.ExecuteNonQuery();

                        if (resul > 0)
                        {
                            resultado = "Funcionario com id " + novoFuncionario.ID.ToString() + " foi eliminado.";
                        }
                        else
                        {
                            resultado = "Funcionario com id " + novoFuncionario.ID.ToString() + " não foi eliminado.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                return "Erro na consulta: " + ex.Message;
            }
            return resultado;
        }

    }
}


