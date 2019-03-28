using Core.Services;

namespace BlazorShell.Services
{
    public class HelloMessageService : IHelloMessageService
    {
        public string HelloMessage => "Hello from Blazor";
    }
}
