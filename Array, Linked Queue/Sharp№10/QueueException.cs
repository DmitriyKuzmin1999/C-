﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    public class QueueException:Exception
    {
        public QueueException() { }
        public QueueException(string message) : base(message) { }
    }
}
