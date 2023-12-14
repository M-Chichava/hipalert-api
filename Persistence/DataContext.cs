using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : IdentityDbContext<AppUser> 
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Allergy> Allergies { get; set; }
    public DbSet<BloodPressureReading> BloodPressureReadings { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<MedicalExam> MedicalExams { get; set; }
    public DbSet<MedicalHistory> MedicalHistories { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<MonitoringRecord> MonitoringRecords { get; set; }
    public DbSet<Observation> Observations { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<Surgery> Surgeries { get; set; }
    public DbSet<TreatmentHistory> TreatmentHistories { get; set; }
    
}