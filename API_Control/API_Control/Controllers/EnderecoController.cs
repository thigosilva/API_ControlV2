using API_Control.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_Control.POCO
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : Controller
    {
        public string get_Endereco()
        {
            ConnectDB oConnect = new ConnectDB();
            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {


                    SqlCommand command_tmp =
                    new
                    SqlCommand("SELECT * from Endereco", dbConnection);

                    command_tmp.ExecuteNonQuery();
                }
                catch (Exception) { }
                dbConnection.Close();
            }
            return "return";
        }


        [HttpPost]
        public string Equipamento(int ID,
             DateTime Data_Inicio,
             DateTime Data_fechamento,
             DateTime Data_Edicao,
             string Logradouro,
             string Numero,
             string Complemento,
             string CEP,
             string Bairro,
             string Municipio,
             string UF,
             string Email,
             string telefone,
             string EFR,
             int Empresa_ID)
        {
            ConnectDB oConnect = new ConnectDB();

            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                    /// Ajusta o Insert para seu projeto
                    String CommandoInsert = $"INSERT INTO Endereco" +
                        $"(ID, " +
                        $"Data_Inicio," +
                        $"Data_Fechamento," +
                        $"Data_Edicao," +
                        $"Logradouro," +
                        $"Numero," +
                        $"Complemento," +
                        $"CEP," +
                        $"Bairro," +
                        $"Municipio," +
                        $"UF," +
                        $"Email," +
                        $"telefone," +
                        $"EFR," +
                        $"Empresa_ID) " +
                        $" VALUES " +
                        $"({ID}, " +
                        $"{Data_Inicio}," +
                        $"{Data_fechamento}," +
                        $"{Data_Edicao}," +
                        $"{Logradouro}" +
                        $"{Numero}" +
                        $"{Complemento}" +
                        $"{CEP}" +
                        $"{Bairro}" +
                        $"{Municipio}" +
                        $"{UF}" +
                        $"{Email}" +
                        $"{telefone}" +
                        $"{EFR}" +
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
            return "retorno";

        }
    }
}
