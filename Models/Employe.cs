using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class Employe
    {
        public Employe(int id,string name, string surname, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

    }
}
