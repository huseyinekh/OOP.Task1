using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class MusteriSifaris
    {
        public MusteriSifaris(int id, int sifarisId,int musteriId)
        {
            Id = id;
            SifarisId = sifarisId;
            MusteriId = musteriId;
        }
        public int Id { get; set; }
        public int SifarisId { get; set; }
        public int MusteriId { get; set; }

    }
}
