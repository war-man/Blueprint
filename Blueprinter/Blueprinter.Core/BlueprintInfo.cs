﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blueprinter.Core
{
    public class BlueprintInfo
    {
        public Guid MyProperty { get; set; }
        public string Name { get; set; }
        public string Blueprint { get; set; }
        public DateTime LastModified { get; set; }

    }
}
