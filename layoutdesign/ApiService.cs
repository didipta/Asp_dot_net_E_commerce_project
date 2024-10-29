using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class ApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ApiService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
    {
        _httpClientFactory = httpClientFactory;
        _httpContextAccessor = httpContextAccessor;
    }

    // A common method to make API GET calls
    public async Task<T> GetApiResponseAsync<T>(string apiUrl)
    {
        var client = _httpClientFactory.CreateClient();

        // Retrieve Bearer token from session
        var token = _httpContextAccessor.HttpContext.Session.GetString("BearerToken");
        if (!string.IsNullOrEmpty(token))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        try
        {
            var response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            else
            {
                throw new HttpRequestException($"API call failed with status code: {response.StatusCode}");
            }
        }
        catch (HttpRequestException ex)
        {
            throw new HttpRequestException("Error occurred while calling API", ex);
        }
        catch (JsonException ex)
        {
            throw new JsonException("Error occurred while deserializing the API response", ex);
        }
    }

    // Method for POST requests
    public async Task<T> PostApiResponseAsync<T>(string apiUrl, object data)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonContent = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        // Retrieve Bearer token from session
        var token = _httpContextAccessor.HttpContext.Session.GetString("BearerToken");
        if (!string.IsNullOrEmpty(token))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        var response = await client.PostAsync(apiUrl, content);
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
        else
        {
            throw new HttpRequestException($"API call failed with status code: {response.StatusCode}");
        }
    }

    // Method for PUT requests
    public async Task<T> PutApiResponseAsync<T>(string apiUrl, object data)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonContent = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        // Retrieve Bearer token from session
        var token = _httpContextAccessor.HttpContext.Session.GetString("BearerToken");
        if (!string.IsNullOrEmpty(token))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        var response = await client.PutAsync(apiUrl, content);
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
        else
        {
            throw new HttpRequestException($"API call failed with status code: {response.StatusCode}");
        }
    }

    // Method for DELETE requests
    public async Task DeleteApiResponseAsync(string apiUrl)
    {
        var client = _httpClientFactory.CreateClient();

        // Retrieve Bearer token from session
        var token = _httpContextAccessor.HttpContext.Session.GetString("BearerToken");
        if (!string.IsNullOrEmpty(token))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        var response = await client.DeleteAsync(apiUrl);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"API call failed with status code: {response.StatusCode}");
        }
    }
}
