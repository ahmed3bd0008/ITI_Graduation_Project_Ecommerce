using MahaleSystem.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace MahaleSystem.Models
{
    public class UsersManhals
    {
        public int Id { get; set; }
        [ForeignKey("Manahel")]
        public int ManelId { get; set; }
        public Manahel Manahel { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public CustomIdentityuser User { get; set; }
    }
}
