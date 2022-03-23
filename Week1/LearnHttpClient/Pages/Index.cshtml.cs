using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace LearnHttpClient.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    //this variable will be used to hold response message's headers property
    // it lives in System.Net.Http namespace, Headers class
    internal HttpResponseHeaders? _headers;
    internal string _contentString = string.Empty;
    
    public IEnumerable<GitHubBranch>? GitHubBranches { get; set; }

    public IndexModel(IHttpClientFactory httpClientFactory , ILogger<IndexModel> logger)
    {
        _logger = logger;
        _httpClientFactory= httpClientFactory;
    }

        
    public async Task OnGet()
    {
        //prepare request message
         var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            "https://api.github.com/repos/dotnet/AspNetCore.Docs/branches")
        {
            Headers =
            {
                { HeaderNames.Accept, "application/vnd.github.v3+json" },
                { HeaderNames.UserAgent, "HttpRequestsSample" }
            }
        };
        //obtain HttpClient from HttpClientFactory
        HttpClient httpClient = _httpClientFactory.CreateClient();
        //send the request 
        HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        // what is the return from calling SendAsync?
        // Task<???>
        //use .net api browser https://docs.microsoft.com/en-us/dotnet/api/
        //here is the doc on the method
        //https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient.sendasync?view=net-6.0#system-net-http-httpclient-sendasync(system-net-http-httprequestmessage)
        // the method returns System.Net.Http.HttpResponseMessage
        // here is the doc for that message class 
        //https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-6.0
        
        if (httpResponseMessage.IsSuccessStatusCode)
        {
            _headers = httpResponseMessage.Headers;
            //_contentString =await httpResponseMessage.Content.ReadAsStringAsync();
            using var contentStream =
                await httpResponseMessage.Content.ReadAsStreamAsync();
            
            GitHubBranches = await JsonSerializer.DeserializeAsync
                <IEnumerable<GitHubBranch>>(contentStream);
        }
    }


}
public record GitHubBranch(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("commit")] Commit Commit)
    ;

public record Commit(
[property: JsonPropertyName("sha")] string SHA,
[property: JsonPropertyName("url")] string Url
);
//{"name":"2responseCompression/ra/1",
//"commit":
//{"sha":"143ef551e62dc97472bb9a1f2a65e68808c83271",
//"url":"https://api.github.com/repos/dotnet/AspNetCore.Docs/commits/143ef551e62dc97472bb9a1f2a65e68808c83271"}
//,"protected":false}


