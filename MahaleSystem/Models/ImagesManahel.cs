using System.ComponentModel.DataAnnotations.Schema;

namespace MahaleSystem.Models
{
    public class ImagesManahel
    {
        public int Id { get; set; }
        public string ImagesString { get; set; }
        [ForeignKey("Manahel")]
        public int ManahelId { get; set; }
        public Manahel Manahel { get; set; }

    }
}
