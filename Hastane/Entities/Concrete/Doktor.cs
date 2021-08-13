using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Doktor:IEntity
    {
        public int DoktorId { get; set; }
        public int TibbiBirimId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Unvan { get; set; }
        public string Ozgecmis { get; set; }
    }
}
