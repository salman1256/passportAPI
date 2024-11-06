using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportAPI.Models
{
    [Table("Passport")]
    public class Passport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string HolderName { get; set; }

        [Required]
        [StringLength(10)]
        public string PassportNumber { get; set; }
        //10/28
        [Required]
        [StringLength(5)]
        public string Expiry { get; set; }
        [Required]
        [StringLength(6)]
        public string PinCode { get; set; }
    }
}
