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
    public DbSet<Patient> Patients { get; set; }
    public DbSet<WearableDevice> WearableDevices{ get; set; }
    public DbSet<Administrator> Administrators{ get; set; }
    public DbSet<HealthCareProfessional> HealthCareProfessionals{ get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Allergy> Allergies { get; set; }
    public DbSet<BloodPressureReading> BloodPressureReadings { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<MedicalExam> MedicalExams { get; set; }
    public DbSet<MedicalHistory> MedicalHistories { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<MonitoringRecord> MonitoringRecords { get; set; }
    public DbSet<Observation> Observations { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<Surgery> Surgeries { get; set; }
    public DbSet<TreatmentHistory> TreatmentHistories { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<IdentityDocument> IdentityDocuments { get; set; }
    public DbSet<MaritalStatus> MaritalStatus { get; set; }
    public DbSet<WearableManufacturer> WearableManufacturers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Patient>()
            .HasOne(p => p.MedicalHistory)
            .WithOne(mh => mh.Patient)
            .HasForeignKey<MedicalHistory>(mh => mh.PatientId);
        base.OnModelCreating(builder);
    }

}