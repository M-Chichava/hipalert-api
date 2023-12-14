namespace Domain;

public class MedicalHistory
{
    public int Id { get; set; }
    public Patient Patient { get; set; }
    public List<Allergy> Allergies { get; set; }
    public List<Medication> Medications { get; set; }
    public List<Surgery> Surgeries { get; set; }
    public List<MedicalExam> MedicalExams { get; set; }
    public List<Event> Events { get; set; }
    public List<Observation> Observations { get; set; }
}