using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class Sifaris
    {
        public Sifaris(int id ,byte quanity, decimal price, int mehsulId,  int sifarisDetalId)
        {
            Id = id;
            Quanity = quanity;
            Price = price;
            MehsulId = mehsulId;
            SifarisDetalId = sifarisDetalId;
        }
        public int Id { get; set; }
        public byte Quanity { get; set; }
        public decimal Price { get; set; }

        public int  MehsulId{ get; set; }
        public int SifarisDetalId { get; set; }

    }
}
