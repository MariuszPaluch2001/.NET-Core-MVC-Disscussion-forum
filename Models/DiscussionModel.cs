using DiscussionForum.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscussionForum.Models
{
    public class DiscussionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
