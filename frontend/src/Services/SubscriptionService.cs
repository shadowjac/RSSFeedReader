using System.Net.Http.Json;

namespace RSSFeedReader.Frontend.Services;

public class SubscriptionService
{
    private readonly HttpClient _httpClient;

    public SubscriptionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IReadOnlyList<SubscriptionDto>> GetSubscriptionsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<SubscriptionDto>>("api/subscriptions") ?? [];
    }

    public async Task<SubscriptionDto?> AddSubscriptionAsync(string url)
    {
        var response = await _httpClient.PostAsJsonAsync("api/subscriptions", new { url });
        if (!response.IsSuccessStatusCode)
        {
            var error = await response.Content.ReadFromJsonAsync<ErrorResponse>();
            throw new InvalidOperationException(error?.Message ?? "Unable to add subscription.");
        }

        return await response.Content.ReadFromJsonAsync<SubscriptionDto>();
    }
}

public class SubscriptionDto
{
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
}

public class ErrorResponse
{
    public string Message { get; set; } = string.Empty;
}
