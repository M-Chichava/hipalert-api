namespace Domain;

public class MonitoringRecord
{
    public int Id { get; set; }
    public string VitalDataPrevious { get; set; }
    public string PreviousMeasurementRecords { get; set; }
    public string Notes { get; set; }
}