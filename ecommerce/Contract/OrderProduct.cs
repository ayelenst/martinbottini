using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [DataContract]
    public class OrderProduct
    {
        [DataMember]
        public int OrderProductId { get; set; }
        
        [DataMember]
        public string NameProduct { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int OrderId { get; set; }
    }
}