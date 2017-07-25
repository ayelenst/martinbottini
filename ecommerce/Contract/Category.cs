using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string Warranty { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public bool Enabled { get; set; }

        [DataMember]
        public virtual List<Product> Products { get; set; }


    }
 
}
