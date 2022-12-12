using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class Mehsul
    {
        public Mehsul()
        {

        }
        public Mehsul(int id, string name,decimal price, int count, string size,int kategoryId,int anbarId)
        {
            Id = id;
            Name = name;
            Price = price;
            Count = count;
            Size = size;
            KategoryId = kategoryId;
            AnbarId = anbarId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal  Price{ get; set; }
        public int  Count { get; set; }
        public string Size { get; set; }

        public int KategoryId { get; set; }
        public int AnbarId { get; set; }

    }
}
