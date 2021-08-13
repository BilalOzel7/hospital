﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class DoktorImage:IEntity
    {
        public int Id { get; set; }
        public int DoktorId { get; set; }
        public string ImagePath { get; set; }
    }
}
