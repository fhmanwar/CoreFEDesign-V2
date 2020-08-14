using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class AccountVM
    {
        public int id_acc { get; set; }
        public string name { get; set; }
        public string Uname { get; set; }
        public string mail { get; set; }
        public string pass { get; set; }
        public string access { get; set; }
        public string addr { get; set; }
        public string phone { get; set; }
    }
}
