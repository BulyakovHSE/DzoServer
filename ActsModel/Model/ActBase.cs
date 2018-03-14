using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    [DataContract]
    public class ActBase
    {
        [DataMember]
        [Key]
        public int Id { get; set; }
        
        [DataMember]
        public int RegionNum => 1 + (int) Region;
        
        [DataMember]
        public Region Region { get; set; }
        
        [DataMember]
        public byte[] DocumentBytes { get; set; }
    }
}