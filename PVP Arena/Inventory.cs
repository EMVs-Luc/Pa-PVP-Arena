using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PVP_Arena
{
    class Inventory
    {
        int i;
        List<Panel> ItemPanels = new List<Panel>();
        List<item> Items = new List<item>();
        public int Selector = 0;
        Panel Select;
        public void updateInventory()
        {
            for (i = 0; i < ItemPanels.Count; i++)
            {
                if (Items[i] != null)
                {
                    ItemPanels[i].BackColor = Items[i].color;
                }
                else { ItemPanels[i].BackColor = Color.Black; }
            }
        }
        public Inventory(List<Panel> itemPanels, Panel select)
        {
            this.ItemPanels = itemPanels;
            this.Select = select;
        }
        public void upSlot()
        {
            i = Selector + 1;
            if (i <= ItemPanels.Count)
            {
                Selector = i;
            }
        }
        public void downSlot()
        {
            i = Selector - 1;
            if (i >= 0)
            {
                Selector = i;
            }
        }
        public item SelectItem()
        {
            return Items[Selector];
        }

    }
}
}
