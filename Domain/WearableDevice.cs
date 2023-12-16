using System;

namespace Domain
{
    public class WearableDevice
    {
        public Guid Id { get; set; }
        public AppUser AppUser { get; set; }
        public string Manufacturer { get; set; }
        public WearableManufacturer WearableManufacturer { get; set; }
        public string SerialNumber { get; set; }
        
        public ICollection<Patient> Patients { get; set; }
        public ICollection<HealthCareProfessional> HealthCareProfessionals { get; set; }
        
    }

}