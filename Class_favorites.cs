using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class Class_favorites
    {
        public int User_id { get; set; }
        public int Adv_id { get; set; }

        public Class_favorites(int user_id, int adv_id)
        {
            User_id = user_id;
            Adv_id = adv_id;
        }
    }
}
