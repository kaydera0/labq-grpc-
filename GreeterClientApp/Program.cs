using System.Numerics;
using System.Text;
using GreeterClientApp;
using Grpc.Net.Client;
using Microsoft.VisualBasic;

// using var channel = GrpcChannel.ForAddress("http://localhost:5263"); //5081
using var channel = GrpcChannel.ForAddress("http://localhost:5081"); //5081
// створюємо клієнта
var client = new Greeter.GreeterClient(channel);
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
//Testing



Console.Write("Введіть им'я: ");
// string? name = Console.ReadLine();
int name = Convert.ToInt32(Console.ReadLine());
// обмінюємось повідомленнями з сервером
var reply = await client.SayHelloAsync(new BaseRequest { Name = name });
var reply2 = await client.FactorialAsync(new BaseRequest { Name = name });
Console.WriteLine($"Відповідь серверу: {reply.Message}");
Console.WriteLine($"Відповідь серверу: {reply2.Message}");
Console.ReadKey();
