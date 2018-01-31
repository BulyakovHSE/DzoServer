using System.ComponentModel.DataAnnotations;

namespace ActsModel
{
    public class ContactInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Fio { get; set; }

        public long Inn { get; set; }

        public string Position { get; set; }
        
        public string PhoneNumber { get; set; }

        public long PassportNumber { get; set; }

        public string PassportData { get; set; }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return (Fio == null ? 0 : Fio.GetHashCode()) +
                   Inn.GetHashCode() + (Position == null ? 0 : Position.GetHashCode()) +
                    (PhoneNumber == null ? 0 : PhoneNumber.GetHashCode()) +
                    PassportNumber.GetHashCode() + (PassportData == null ? 0 : PassportData.GetHashCode());
        }
    }
}