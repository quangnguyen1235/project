﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    public interface IProducerRepository
    {
        IEnumerable<Producer> Gets();
    }
}