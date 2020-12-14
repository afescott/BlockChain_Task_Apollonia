using System;
using System.Linq;

namespace BlockChain_Apollonia
{
    //<summary>
    // Classes representing an example blockchain, containing an example run when a block is generated. In this scenario wealth, such as  
    // welfare is being distributed with the 'HashList'. Seek documentation for description.
    //</summary>
    public class BlockChain
    {
        private string[] ValidRecipentsHashList = new[] { "FASFA", "CK2FA5", "B2FA5", "N2FA5", "L2FA5", "M2FA5", "N2FAK", };

        private string[] TampererHashList = new[] { "FAVA", "CK2FCS", "FSABD12", "FSAS12" };

        public string[] CheckforTamperes(string[] hashList)
        {
            var securityDivision = new SecurityDivision();

            var previousList = new string[] { };

            previousList = hashList;

            for (int i = 0; i < hashList.Length; i++) //wealth being distributed 
            {
                if (i > 0 && i < hashList.Length - 1)
                {
                    if (hashList.ElementAt(i - 1) != previousList.ElementAt(i - 1))
                    {
                        securityDivision.CommunicateFishyHash(hashList.ElementAt(-1));
                        var tempList = hashList.ToList();
                        tempList.Remove(hashList[i - 1]);

                        if (previousList.Length > 0)
                        previousList = hashList;

                        CheckforTamperes(tempList.ToArray());

                    }
                }
                if (!ValidRecipentsHashList.Contains(hashList[i]))
                {
                    securityDivision.CommunicateFishyHash(hashList[i]);

                    var rand = new Random();

                    var randomInt = rand.Next(2); //Randomise for a tamperer

                    var tempList = hashList.ToList();

                    if (randomInt == 1)
                    {
                        var tampererHash = TampererHashList[rand.Next(TampererHashList.Length)];

                        tempList.Add(tampererHash);
                    }
                    previousList = hashList;
                    tempList.Remove(hashList[i]);
                    CheckforTamperes(tempList.ToArray());
                }

                if (i == hashList.Length-1)
                {
                    Console.WriteLine("New block added to each address");
                }

            }

            return hashList;


            //Sign that the block has been successfully distributed to the desired recipents.
        }

    }
}
