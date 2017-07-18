using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public bool IsMain { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public virtual Product Products { get; set; }

    }

}