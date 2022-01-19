using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PVP_Arena
{
    class axe : item
    {


        public axe(int demage, int range, int delay)
        {
            Demage = demage;
            Range = range;
            DelayMs = delay;
            color = Color.Orange;
        }
    }
    class sword : item
    {
        public sword(int demage, int range, int delay)
        {
            Demage = demage;
            Range = range;
            DelayMs = delay;
            color = Color.Red;
        }
    }
    class bow : item
    {
        public bow(int demage, int range, int delay)
        {
            Demage = demage;
            Range = range;
            DelayMs = delay;
            color = Color.Yellow;
        }
    }
}
