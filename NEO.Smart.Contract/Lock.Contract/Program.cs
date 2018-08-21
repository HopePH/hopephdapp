using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace Lock.Contract
{
    public class Lock : SmartContract
    {
        public static bool Main(uint timestamp, byte[] pubkey, byte[] signature)
        {
            Header header = Blockchain.GetHeader(Blockchain.GetHeight());
            if (timestamp > header.Timestamp) return false;
            return VerifySignature(signature, pubkey);
        }
    }
}


