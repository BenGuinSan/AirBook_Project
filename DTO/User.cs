using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public string User_ID { get; set; }
        public string Role_ID { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string Real_name { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string Nation { get; set; }
        public string User_address { get; set; }
        public string Phone_number { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public DateTime Date_Create { get; set; }
    }
}
