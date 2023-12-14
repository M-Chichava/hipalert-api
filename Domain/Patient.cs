namespace Domain;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Contact { get; set; }
    public Address Address { get; set; }
    public MedicalHistory MedicalHistory { get; set; }
    public List<Allergy> Allergies { get; set; }
    public List<Medication> PrescribedMedications { get; set; }
}