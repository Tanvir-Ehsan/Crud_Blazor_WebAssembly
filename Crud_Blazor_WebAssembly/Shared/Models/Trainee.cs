using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Blazor_WebAssembly.Shared.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactAddress { get; set; }
        public string CellPhoneNo { get; set; }
        public string EmailAddress { get; set; }
    }
}
