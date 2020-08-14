using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class ReserveVM
    {
        public int id_reserve { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string status { get; set; }
        public int total { get; set; }
        public string tgl_bayar { get; set; }
        public int carID { get; set; }
        public String carName { get; set; }
        public String carTransmition { get; set; }
        public String carYear { get; set; }
        public String carMerk { get; set; }
        public int accountID { get; set; }
        public String accountName { get; set; }
        public String accountAlamat { get; set; }
        public String accountPhone { get; set; }
    }
}
