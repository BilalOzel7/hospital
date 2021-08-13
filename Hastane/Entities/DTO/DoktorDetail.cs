using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
   public class DoktorDetail
    {
        public int DoktorId { get; set; }
        public int TibbiBirimId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirimAd { get; set; }
        public string Ozgecmis { get; set; }
        public string Unvan { get; set; }
        public List<DoktorImage> DoktorImage { get; set; }
    }
}
