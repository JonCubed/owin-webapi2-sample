namespace Owin.WebApi2.Services
{
    public interface IHelloWorldService
    {
        string Hello();
        string HelloWorld();
    }

    public class HelloWorldService :IHelloWorldService
    {
        public string Hello()
        {
            return "Hello";
        }

        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}