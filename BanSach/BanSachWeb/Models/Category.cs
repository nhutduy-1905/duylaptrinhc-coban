using System.ComponentModel.DataAnnotations;

namespace BanSachWeb.Models
{
    public class Category
    {
        [Key] // Khóa chính
        public int Id { get; set; }
        [Required] // không được rỗng
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; }    = DateTime.Now;
    }
}
