using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class sellers
    {
        public int User_id {  get; set; }
        public int Rating { get; set; }
        public string Phone_number {  get; set; }
        public int Adv_id { get; set; }
        public sellers(int user_id, int rating, string phone_number, int adv_id)
        {
            User_id = user_id;
            Rating = rating;
            Phone_number = phone_number;
            Adv_id = adv_id;
        }
    }
}
