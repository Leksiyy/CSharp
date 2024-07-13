using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace _28_06_24;

public class IpWho
{
    public string Ip { get; set; }
    public string City { get; set; }

    public async void DoRequest(string ip)
    {
        string url = $"http://ipwho.is/{ip}";
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();
            if (content.Length > 0)
            {
                var data = JsonConvert.DeserializeObject<IpWho>(content);
                Console.WriteLine($"This IP {data.Ip} is located at {data.City}");
                this.City = data.City;
                this.Ip = data.Ip;
                string jsonStr = JsonSerializer.Serialize(this);
                Console.WriteLine(jsonStr);
                File.WriteAllText("/Users/leksiy/CSharpHomework/CSharp/28-06-24/ip_date.json", jsonStr);
            }
        }
    }
}