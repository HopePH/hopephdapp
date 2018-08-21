using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace Hello.Contract
{
    public class HelloWorld : SmartContract
    {
        public static void Main(string[] args)
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World");
        }
    }
}
