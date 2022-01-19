using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace PVP_Arena
{
    enum itemsType
    {

        sword = 0,
        axe = 1,
        bow = 2

    }

    class items
    {
        static ArrayList itemsTypes = new ArrayList();
        static ArrayList itemss = new ArrayList();

        public static void itemsSetup()
        {

            itemsTypes.Add(itemsType.sword);
            itemsTypes.Add(itemsType.axe);
            itemsTypes.Add(itemsType.bow);

            itemss[0] = new item();



            itemss[1] = new item();



            itemss[2] = new item();


        }

        public static item itemFromType(itemsType type)
        {
            return (item)itemss[itemsTypes.IndexOf(type)];
        }
        public static itemsType itemFromType(item Item)
        {
            return (itemsType)itemsTypes[itemss.IndexOf(Item)];
        }

    }
}
