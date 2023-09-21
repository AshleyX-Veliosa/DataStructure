﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class LinkedSet : LinkHeaderCollections, Set
    {
        public new void add(object e)
        {
            if (!base.contains(e))
            {
                base.add(e);
            }
        }
    }
}