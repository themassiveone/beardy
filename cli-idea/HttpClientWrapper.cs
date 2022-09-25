using System.Text;
using Newtonsoft.Json;
public class HttpClientWrapper
{
    private HttpClient client = new HttpClient();

    public T GetJson<T>(string url, IDictionary<string, string>? urlParams = null)
    {

        Task<string> promise;
        if (urlParams is not null)
        {
            var urlParamsString = urlParams.Select(x => $"{x.Key}={x.Value}");
            promise = client.GetStringAsync($"{url}?{string.Join(" & ", urlParamsString)}");

        }
        else
        {
            promise = client.GetStringAsync($"{url}");

        }

        promise.Wait();
        return JsonConvert.DeserializeObject<T>(promise.Result);

    }

}