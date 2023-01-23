using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Control.POCO
{
    public class Equipamento
    {
        public int ID { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fechamento { get; set; }
        public DateTime Data_Edicao { get; set; }
        public string device { get; set; }
        public string manufacturer { get; set; }
        public string deviceName { get; set; }
        public string version { get; set; }
        public string platform { get; set; }
        public string idiom { get; set; }
        public string deviceType { get; set; }
        public string Imei { get; set; }

        
    }
}
