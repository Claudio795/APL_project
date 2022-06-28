using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class LoggedUser
    {
        public static int id { get; set; }
        public static string name { get; set; }
        public static string username { get; set; }
        public static bool isadmin { get; set; }


        public static void Clear()
        {
            id = 0;
            name = "";
            username = "";
            isadmin = false;
        }
    }


}
