using System.ComponentModel.DataAnnotations;

namespace ActsModel.Model
{
    public class ActBase
    {
        [Key]
        public int Id { get; set; }

        public int RegionNum => (int) Region;

        public Region Region { get; set; }

        public byte[] DocumentBytes { get; set; }
    }
}