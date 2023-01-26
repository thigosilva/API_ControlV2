using API_Control.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;



namespace API_Control.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : Controller
    {
        [HttpGet]
        public string get_Empresa() {
            ConnectDB oConnect = new ConnectDB();
            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                   

                    SqlCommand command_tmp =
                    new
                    SqlCommand("SELECT * from Empresa", dbConnection);

                    command_tmp.ExecuteNonQuery();
                }
                catch (Exception) { }
                dbConnection.Close();
            }
            return "return";
        }
        [HttpPost]
        public string Empresa(int ID,
            DateTime Data_Inicio,
            DateTime Data_fechamento,
            DateTime Data_Edicao,
            string status,
            string ultima_atualizacao,
            string cnpj,
            string tipo,
            string porte,
            string nome_fantasia,
            string abertura,
            string Empresa_ID)
        {

            ConnectDB oConnect = new ConnectDB();
            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                    /// Ajusta o Insert para seu projeto
                    String CommandoInsert = $"INSERT INTO Empresa" +
                        $"(ID, " +
                        $"Data_Inicio," +
                        $"Data_Fechamento," +
                        $"Data_Edicao," +
                        $"status," +
                        $"ultima_atualizacao," +
                        $"cnpj," +
                        $"tipo," +
                        $"porte," +
                        $"nome_fantasia," +
                        $"abertura," +
                        $"Empresa_ID) " +
                        $" VALUES " +
                        $"({ID}, " +
                        $"{Data_Inicio}," +
                        $"{Data_fechamento}," +
                        $"{Data_Edicao}," +
                        $"{status}'" +
                        $"{ultima_atualizacao}" +
                        $"{cnpj}" +
                        $"{tipo}" +
                        $"{porte}" +
                        $"{nome_fantasia}" +
                        $"{abertura}" +
                        $"{Empresa_ID})";
                    /////////////////////////////////////

                    SqlCommand command_tmp =
                    new
                    SqlCommand(CommandoInsert, dbConnection);

                    command_tmp.ExecuteNonQuery();
                }
                catch (Exception) { }
                dbConnection.Close();
            }

            return "Retorno";
        }

    }


}
