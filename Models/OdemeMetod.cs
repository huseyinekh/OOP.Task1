using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class OdemeMetod
    {
        public OdemeMetod(int id, string odemeMethodName)
        {
            Id = id;
            OdemeMetodName = odemeMethodName;
        }
        public int Id { get; set; }
        public string OdemeMetodName { get; set; }
    }
}
