// See https://aka.ms/new-console-template for more information
using System.Net;

Console.WriteLine("input access address");

var address = Console.ReadLine();

//var message = new HttpRequestMessage(HttpMethod.Get, @"https://" + address);
//var message = new HttpRequestMessage(HttpMethod.Get, @"https://172.30.7.233:5001");
//message.Version = Version.Parse("3.0");
//message.VersionPolicy = HttpVersionPolicy.RequestVersionOrHigher;

var client = new HttpClient();
client.DefaultRequestVersion = HttpVersion.Version30;
client.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact;

//var response = await client.SendAsync(message);
var response = await client.GetAsync(@"https://" + address);
var html = await response.Content.ReadAsStringAsync();

Console.WriteLine(html);
