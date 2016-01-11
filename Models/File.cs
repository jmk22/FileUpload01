using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileUpload01.Models
{
    [Table("Uploads")]
    public partial class File
    {
        [Key]
        public int Id { get; set; }
        public string ImagePath { get; set; }

    }
}
