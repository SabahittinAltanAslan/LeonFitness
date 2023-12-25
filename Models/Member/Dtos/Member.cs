using System.ComponentModel.DataAnnotations;

namespace LeonFitness.Models.Member.Dtos
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Time { get; set; }


    }
}

