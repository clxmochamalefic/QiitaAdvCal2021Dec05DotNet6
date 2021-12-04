// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var message = new HttpRequestMessage();
//message.Version = Version.Parse("3.0");

var client = new HttpClient();
client.DefaultRequestVersion = Version.Parse("3.0");

var response = await client.GetAsync("https://localhost:5001");
var html = await response.Content.ReadAsStringAsync();

Console.WriteLine(html);
