using System.ComponentModel.DataAnnotations;

namespace LeonFitness.Models.Admin.Dtos
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
