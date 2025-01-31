﻿using System.Security.Cryptography;

namespace WebAppGB_ForDocker.RSATools
{
    public class RSAExtensions
    {
        public static RSA GetPrivateKey()
        {
            var key = File.ReadAllText(@"../WebAppGB_ForDocker/Keys/private_key.pem");
            var rsa = RSA.Create();

            rsa.ImportFromPem(key);

            return rsa;
        }

        public static RSA GetPublicKey()
        {
            var key = File.ReadAllText(@"../WebAppGB_ForDocker/Keys/public_key.pem");
            var rsa = RSA.Create();

            rsa.ImportFromPem(key);

            return rsa;
        }
    }
}
