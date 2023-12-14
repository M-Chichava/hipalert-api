namespace Domain;

public class BloodPressureReading
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public DateTime ReadingDate { get; set; }
    public int SystolicPressure { get; set; }
    public int DiastolicPressure { get; set; }
    public int PulseRate { get; set; }
    public DateTime ReadingTime { get; set; }
}