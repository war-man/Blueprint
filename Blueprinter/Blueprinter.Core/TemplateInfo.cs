using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blueprinter.Core
{
    class TemplateInfo
    {
        public Guid MyProperty { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public string Content { get; set; }
        public DateTime LastModified { get; set; }
    }
}
