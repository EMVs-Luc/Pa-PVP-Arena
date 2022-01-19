using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PVP_Arena
{
    class item
    {
        public int Demage { get; protected set; }
        public int Range { get; protected set; }
        public int DelayMs { get; protected set; }
        public Color color { get; set; }
    }
}
