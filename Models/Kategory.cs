using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class Kategory
    {
        public Kategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
