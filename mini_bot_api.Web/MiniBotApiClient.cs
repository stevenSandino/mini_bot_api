namespace mini_bot_api.Web;

public class MiniBotApiClient(HttpClient httpClient)
{
    public async Task<ResponceRecord[]> GetResponceAsync(int maxItems = 10, CancellationToken cancellationToken = default)
    {
        List<ResponceRecord>? responces = null;

        await foreach (var responce in httpClient.GetFromJsonAsAsyncEnumerable<ResponceRecord>("/responce", cancellationToken))
        {
            if (responces?.Count >= maxItems)
            {
                break;
            }
            if (responce is not null)
            {
                responces ??= [];
                responces.Add(responce);
            }
        }

        return responces?.ToArray() ?? [];
    }
}

public record ResponceRecord(string question, string answer)
{
}
