using System.ComponentModel.DataAnnotations;

namespace LeonFitness.Models.PersonalTrainer
{
    public class PersonalTrainer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
