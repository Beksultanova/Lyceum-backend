using Lyceum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lyceum.Infrastructure.Ef;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
    
    public DbSet<Component> Components { get; set; }
    
    public DbSet<Person> Persons { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Achievement> Achievements { get; set; }
    public DbSet<AddCourse> AddCourses { get; set; }
    public DbSet<History> Histories { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<ParentСommission> ParentСommissions { get; set; }
    public DbSet<Stakeholder> Stakeholders { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}