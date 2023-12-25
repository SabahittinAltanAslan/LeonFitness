using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace LeonFitness.Models;

public class Context  : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=LEGEN\\MSSQLSERVER01;database=LeonFitness;integrated security= true; Trust Server Certificate=true;");
    }
    public DbSet<PersonalTrainer.Dtos.PersonalTrainer> Trainers { get; set; }

    public DbSet<Member.Dtos.Member> Members { get; set; }

    public DbSet<Receptionist.Dtos.Receptionist> Receptionists { get; set; }
    public DbSet<Admin.Dtos.Admin> Admins { get; set; }
}
