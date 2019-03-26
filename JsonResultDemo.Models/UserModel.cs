namespace JsonResultDemo.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Company { get; set; }
    }
}
