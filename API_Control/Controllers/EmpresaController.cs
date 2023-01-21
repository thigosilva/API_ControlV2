using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Control.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : Controller
    {
        [HttpPost]
        public string Empresa()
        {
            try {
                using ()
                {
                    using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
                    {
                        dbConnection.Open();
                        try
                        {
                            /// Ajusta o Insert para seu projeto
                            String CommandoInsert = $"INSERT INTO cat_image(id, url,width,height,category_id) " +
                              $" VALUES ('{oStru_Images[y].id}', '{oStru_Images[y].url}',{oStru_Images[y].width},{oStru_Images[y].height},'{oCategory[i]}');"
                                /////////////////////////////////////

                                SqlCommand command_tmp =
                                new
                                SqlCommand(CommandoInsert, dbConnection);

                            command_tmp.ExecuteNonQuery();
                        }
                        catch (Exception) { }
                        dbConnection.Close();
                    }
                }
            catch {
                Exception();
            }
            return "oi";
        }
        
    }

    
}
