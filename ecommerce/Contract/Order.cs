using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NameCustomer { get; set; }
     

        [DataMember]
        public virtual List<OrderProduct> OrderProduct { get; set; }

        [DataMember]
        public int OrderStatusId { get; set; }

        [DataMember]
        public virtual OrderStatus OrderStatus { get; set; }

        [DataMember]
        public string Mail { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Payment { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public DateTime OrderDone { get; set; }

        public double Total { get; set; }
    }
}
