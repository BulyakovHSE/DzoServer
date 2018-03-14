using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    [DataContract]
    public class ActBase
    {
        [Key]
        public int Id { get; set; }

        public int RegionNum => (int) Region;

        public Region Region { get; set; }

        public byte[] DocumentBytes { get; set; }

        public string Discriminator { get; set; }
    }
}