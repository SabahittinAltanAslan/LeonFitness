using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


namespace LeonFitness.Models;

public class Context  : DbContext
{
    private readonly IConfiguration Configuration;

    public Context(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<PersonalTrainer.PersonalTrainer> Trainers { get; set; }

    public DbSet<Member.Member> Members { get; set; }

    public DbSet<Receptionist.Receptionist> Receptionists { get; set; }
    public DbSet<Admin.Admin> Admins { get; set; }
}
