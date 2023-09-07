using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Domain.Models;

namespace WebApplication1.Services;

public class StudentOpdrachtVoortgangService
{
    private readonly HttpClient _httpClient;
    public StudentOpdrachtVoortgangService()
    {
        _httpClient = new HttpClient{ BaseAddress = new Uri("https://localhost:5297/StudentOpdrachtVoortgang") };
    }

    public async Task Update(StudentOpdrachtVoortgang sov)
    {
        var request = new HttpRequestMessage(HttpMethod.Put, _httpClient.BaseAddress);
        // Optionally, set request content (e.g., JSON data)
        var jsonContent = JsonSerializer.Serialize(sov);
        request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        // Send the PUT request and await the response
        var response = await _httpClient.SendAsync(request);
    }

    public async Task<List<StudentOpdrachtVoortgang>?> GetAll()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, _httpClient.BaseAddress);
        var response = await _httpClient.SendAsync(request);
        var result = JsonSerializer.Deserialize<List<StudentOpdrachtVoortgang>>(response.Content.ReadAsStringAsync().Result);
        return result;
    }
}