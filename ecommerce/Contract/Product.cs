using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsOffer { get; set; }

        [DataMember]
        public double Percent { get; set; }

        [DataMember]
        public bool Enabled { get; set; }

        [DataMember]
        public DateTime StartDay { get; set; }

        [DataMember]
        public DateTime EndDay { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int CategoryId{ get; set; }

        [DataMember]
        public virtual Category Category  { get;set;}
    }
}
