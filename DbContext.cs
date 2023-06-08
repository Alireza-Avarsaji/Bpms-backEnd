using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<QuestionEntity> Questions { get; set; }
    public DbSet<FormEntity> Forms { get; set; }
    public DbSet<SubmissionEntity> Submissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        this.UserOnModelCreating(modelBuilder);
        this.ProjectOnModelCreating(modelBuilder);
    }


    public void ProjectOnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.id);
        modelBuilder.Entity<UserEntity>().Property(u => u.age).IsRequired();
        modelBuilder.Entity<UserEntity>().Property(u => u.name).IsRequired();
        modelBuilder.Entity<UserEntity>().Property(u => u.gender).IsRequired();
    }


    public void UserOnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.id);
        modelBuilder.Entity<UserEntity>().Property(u => u.age).IsRequired();
        modelBuilder.Entity<UserEntity>().Property(u => u.name).IsRequired();
        modelBuilder.Entity<UserEntity>().Property(u => u.gender).IsRequired();
        modelBuilder.Entity<UserEntity>().HasOne(u => u.project).WithMany(p => p.users).HasForeignKey(u => u.projectId);
    }




}