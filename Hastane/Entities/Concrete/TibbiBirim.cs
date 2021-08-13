using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class TibbiBirim:IEntity
    {
        public int TibbiBirimId { get; set; }
        public string BirimAd { get; set; }
    }
}
