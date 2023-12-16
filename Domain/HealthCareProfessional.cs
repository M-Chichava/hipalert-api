using System;

namespace Domain
{
    public class HealthCareProfessional 
    {
        public Guid Id { get; set; }
        public AppUser AppUser { get; set; }
    }
}