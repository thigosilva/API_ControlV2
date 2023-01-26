using API_Control.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Control.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AluguelController : Controller
    {
        public string get_Aluguel()
        {
            ConnectDB oConnect = new ConnectDB();

            string oRetorno = string.Empty;
            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {


                    SqlCommand command_tmp =
                    new
                    SqlCommand("SELECT * from Aluguel", dbConnection);

                    command_tmp.ExecuteNonQuery();
                }
                catch (Exception) { }
                dbConnection.Close();
            }
            return "return";
        }
        [HttpPost]
        public string Aluguel(int ID,
            DateTime Data_Inicio,
            DateTime Data_fechamento,
            DateTime Data_Edicao,
            int Empresa_ID,
            int Equipamento_ID)
        {

            ConnectDB oConnect = new ConnectDB();
            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                    /// Ajusta o Insert para seu projeto
                    String CommandoInsert = $"INSERT INTO Aluguel" +
                        $"(ID, " +
                        $"Data_Inicio," +
                        $"Data_Fechamento," +
                        $"Data_Edicao," +
                        $"Empresa_ID," +
                        $"Equipamento_ID) " +
                        $" VALUES " +
                        $"({ID}, " +
                        $"{Data_Inicio}," +
                        $"{Data_fechamento}," +
                        $"{Data_Edicao}," +
                        $"{Empresa_ID}" +
                        $"{Equipamento_ID})";
                    /////////////////////////////////////

                    SqlCommand command_tmp =
                    new
                    SqlCommand(CommandoInsert, dbConnection);

                    command_tmp.ExecuteNonQuery();
                }
                catch (Exception) { }
                dbConnection.Close();
            }
            return "retorno";

        }
    }
}
