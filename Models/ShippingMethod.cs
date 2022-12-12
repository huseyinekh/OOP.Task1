using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class ShippingMethod
    {
        public int Id { get; set; }
        public string ShippingMethodName { get; set; }

        public ShippingMethod(int id, string shippingMethodName)
        {
            Id = id;
            ShippingMethodName = shippingMethodName;
        }
    }
}
