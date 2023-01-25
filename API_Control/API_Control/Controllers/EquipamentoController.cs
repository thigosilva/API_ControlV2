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
    public class EquipamentoController : Controller
    {
        [HttpPost]
        public string Equipamento(int ID,
             DateTime Data_Inicio,
             DateTime Data_fechamento,
             DateTime Data_Edicao,
             string device,
             string manufacturer,
             string deviceName,
             string Version,
             string platform,
             string idiom,
             string deviceType,
             string Imei)
        {

            ConnectDB oConnect = new ConnectDB();
            

            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                    /// Ajusta o Insert para seu projeto
                    String CommandoInsert = $"INSERT INTO Equipamento" +
                        $"(ID, " +
                        $"Data_Inicio," +
                        $"Data_Fechamento," +
                        $"Data_Edicao," +
                        $"device," +
                        $"manufacturer," +
                        $"deviceName," +
                        $"version," +
                        $"platform," +
                        $"idiom," +
                        $"deviceType," +
                        $"Imei) " +
                        $" VALUES " +
                        $"({ID}, " +
                        $"{Data_Inicio}," +
                        $"{Data_fechamento}," +
                        $"{Data_Edicao}," +
                        $"{device}" +
                        $"{manufacturer}" +
                        $"{deviceName}" +
                        $"{Version}" +
                        $"{platform}" +
                        $"{idiom}" +
                        $"{deviceType}" +
                        $"{Imei})";
                    /////////////////////////////////////

                    SqlCommand command_tmp =
                    new
                    SqlCommand(CommandoInsert, dbConnection);

                    command_tmp.ExecuteNonQuery();
                }
                catch (Exception) { }
                dbConnection.Close();
            }
            return "Retorn";

        }
    }
}
