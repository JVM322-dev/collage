using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collage
{
   public class TablesandAtrributes
    {
        public string nametable;
        public string[] parametrs;
        public TablesandAtrributes(string namegridVIEW,params string[] str) {
            this.nametable = namegridVIEW;
            this.parametrs = str;
        }

    }
}
