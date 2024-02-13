using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToSQL
{
    public partial class artist
    {
        public override string ToString()
        {
            return $" {Id,3} {Name,-20} ";
        }
    }
}
