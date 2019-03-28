using Core.Services;

namespace RCShell.Services
{
    public class HelloMessageService : IHelloMessageService
    {
        public string HelloMessage => "Hello from Razor Components";
    }
}
