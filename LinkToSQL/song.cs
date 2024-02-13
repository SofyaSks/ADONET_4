using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToSQL
{
    public partial class song
    {

        public override string ToString()
        {
            return $" {Id,3} {title, -20} {rating,-20} {weight,-20} {duration,-20}";
        }
    }
}
