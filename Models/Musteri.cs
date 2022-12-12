using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class Musteri
    {


        public Musteri(int id,string name, string surname,string email)
        {
            Id = id;
            Email = email;
            Name = name;
            SurName = surname;
        }
        public int Id { get; set; }


        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }

        public string Passsword { get; set; } = null;



    }
}
