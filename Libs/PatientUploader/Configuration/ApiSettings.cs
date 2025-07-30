namespace PatientUploaderConsoleApp.Configuration;

public sealed class ApiSettings
{
    public string BaseUrl { get; set; }
    public string PostPatientEndpoint { get; set; }
    public int Count { get; set; } = 100;
}