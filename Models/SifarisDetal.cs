using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task.Models
{
    class SifarisDetal
    {


        public SifarisDetal(int status, int shippingMethodId, int paymentMethod,bool catdirildi)
        {
            Status = status;
            ShippingMethodId = shippingMethodId;
            PaymentMethod = paymentMethod;
            Catdirildi = catdirildi;
        }

        public int Status { get; set; }

        public int ShippingMethodId { get; set; }

        public int PaymentMethod { get; set; }

        public bool Catdirildi { get; set; }


    }
}
