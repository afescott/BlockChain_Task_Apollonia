using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BlockChain_Apollonia
{
   public class ApolloniaBlockChainTask
    {
        private static string[] ExampleValidOrInvalidHashAddresses = new[] { "FASFA", "CK2FA5", "AS2FA5", "B2FA5", "N2FA5", "L2FA5", "B2FA5", "M2FA5", "D2FA5", "N2FAK", };

        static void Main(string[] args)
        {
            var blockChain = new BlockChain();

            blockChain.CheckforTamperes(ExampleValidOrInvalidHashAddresses);
        }

      


   

        }
}
