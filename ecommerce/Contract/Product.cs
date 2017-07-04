using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    [DataContract]
    public class Product
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CategoryId{ get; set; }

        [DataMember]
        public virtual Category Category  { get;set;}
    }
}
