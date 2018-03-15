using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    [KnownType(typeof(ActCommon))]
    [KnownType(typeof(ActIndividual))]
    [DataContract]
    public class ActBase
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        public int RegionNum
        {
            get => 1 + (int) Region;
            set => Region = (Region) (value - 1);
        }

        [DataMember]
        public Region Region { get; set; }
        
        [DataMember]
        public byte[] DocumentBytes { get; set; }
    }
}