using PatientUploaderConsoleApp.Application.Interfaces;
using PatientUploaderConsoleApp.Configuration;
using PatientUploaderConsoleApp.Domain.Models;
using System.Net.Http.Json;

namespace PatientUploaderConsoleApp.Infrastructure.Services;

public class PatientService : IPatientService
{
    private readonly HttpClient _httpClient;
    private readonly ApiSettings _settings;

    public PatientService(HttpClient httpClient, ApiSettings settings)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(settings.BaseUrl);
        _settings = settings;
    }

    public async Task UploadPatientsAsync(IEnumerable<Patient> patients)
    {
        var response = await _httpClient.PostAsJsonAsync(_settings.PostPatientEndpoint, patients);
        response.EnsureSuccessStatusCode();

    }
}