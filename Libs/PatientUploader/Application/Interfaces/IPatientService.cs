using PatientUploaderConsoleApp.Domain.Models;

namespace PatientUploaderConsoleApp.Application.Interfaces;

public interface IPatientService
{
    Task UploadPatientsAsync(IEnumerable<Patient> patients);
}