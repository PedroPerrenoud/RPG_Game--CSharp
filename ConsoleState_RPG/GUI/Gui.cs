using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleState_RPG
{
    class Gui
    {
        public static String Title(String str)
        {
            str = String.Format("=== {0} === \n\n", str);

            return str;
        }

        public static String MenuTitle(String str)
        {
            str = String.Format("-- {0} -- \n", str);

            return str;
        }

        public static String Annoucement(String str)
        {
            str = String.Format("\t(~) {0} \n", str);

            return str;
        }

        public static String MenuOption(int opt, String str)
        {
            str = String.Format("- [{0}] {1} \n", opt, str);

            return str;
        }
    }
}
