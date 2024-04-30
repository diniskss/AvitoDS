using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class advertisment
    {
        public int Adv_id { get; set; }
        public string Name { get; set; }
        public string Date_of_creation { get; set; }
        public int User_id{ get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Discription { get; set; }
        public string Images { get; set; }

        public advertisment(int adv_id, string name, string date_of_creation, int user_id, string type, int price, string discription, string images)
        {
            Adv_id = user_id;
            Name = name;
            Date_of_creation = date_of_creation;
            User_id = user_id;
            Type = type;
            Price = price;
            Discription = discription;
            Images = images;
        }
    }
}
