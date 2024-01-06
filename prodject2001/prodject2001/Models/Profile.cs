using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prodject2001.Models
{
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        public required string Description { get; set; }

        [StringLength(100)]
        public required string Location { get; set; }

        public bool Archived { get; set; }

        // Navigation property to User
        public virtual required User User { get; set; }

    }
}
