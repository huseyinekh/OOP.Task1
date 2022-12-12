using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class IsciSifaris
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IsciSifaris(int id, string name, int sifarisId, int ischiId)
        {
            Id = id;
            Name = name;
            SifarisId = sifarisId;
            IschiId = ischiId;
        }

        public int SifarisId { get; set; }


        public int IschiId { get; set; }


    }
}
