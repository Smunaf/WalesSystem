using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class clsCustomer
    {
        public string AnCustomer { get; internal set; }
        public int CustomerNo { get; internal set; }
        public DateTime DOB { get; internal set; }
        public string Email { get; internal set; }
        public string FirstName { get; internal set; }
        public string SureName { get; internal set; }
        public int Telephone { get; internal set; }
    }
}
