using Neo.SmartContract.Framework.Services.Neo;

namespace Hello.Contract
{
    public class SmartLogic
    {
        public bool Success { get; set; }

        public SmartLogic()
        {
            try
            {
                Storage.Put(null, "Hello", "World");
            }
            catch { }
            Success = !Success;
        }
    }
}
