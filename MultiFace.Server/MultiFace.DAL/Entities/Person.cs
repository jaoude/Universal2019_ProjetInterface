using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MultiFace.Common.Constants;

namespace MultiFace.DAL.Entities
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(NAME_LEN)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(NAME_LEN)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [MaxLength(TITLE_LEN)]
        public string Title { get; set; }

        public byte[] Photo { get; set; }
    }
}
