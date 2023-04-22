using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTi3
{
    static class Program
    {
        public class ElGramal
        {
            public long  p=0, g=0, k=0, x=0;
            public long y;
            public List<long> divs;
            public List<long> primeRoots;
            public short[] plaintextS;
            public short[] cipherS;
            public byte[] plaintextB;
            public byte[] cipherB;

            public bool isPrime(long p)
            {
                for(long i=2;i<=Math.Sqrt(p);i++)
                    if(p%i==0)
                        return false;
                return true;
            }
            long mul(long a, long b, long m){
                if(b==1)
                    return a;
                if(b%2==0){
                    var t = mul(a, b/2, m);
                    return (2 * t) % m;
                }
                return (mul(a, b-1, m) + a) % m;
            }

            long pow(long a, long b, long m)
            {
                long result = 1;
                while (b != 0) {
                    while (b % 2 == 0) {
                        b /= 2;
                        a = (a * a) % m;
                    }
                    b--;
                    result = (result * a) % m;
                }
                return result;
            }

            long pows(long a, long b, long m){
                if(b==0)
                    return 1;
                if(b%2==0){
                    var t = pows(a, b/2, m);
                    return mul(t , t, m) % m;
                }
                return (mul(pows(a, b-1, m) , a, m)) % m;
            }

           public List<long> GetAllPrimeDivs(long n)
            {
                List<long> divs = new List<long>();
                for (int i = 2; i <= n; i++) {
                    while (n % i == 0) {
                        if (!divs.Contains(i)) {
                            divs.Add(i);
                        }
                        n /= i;
                    }
                }
                this.divs = divs;
                return divs;
            }

            public bool isPrimeRoot(long ofWhat, long what)
            {
                foreach (var el in divs)
                {
                    if(pow(what, (ofWhat-1)/el, ofWhat) == 1)
                    {
                        return false;
                    }
                }
                return true;
            }

            public List<long> GetAllPrimeRoots(long p)
            {
                List<long> allPrimeRooots = new List<long>();
                for (long i = 2; i < p; i++)
                {
                    if (isPrimeRoot(p, i))
                    {
                        allPrimeRooots.Add(i);
                    }
                }
                primeRoots = allPrimeRooots;
                return allPrimeRooots;
            }
            
            private long GetGCD(long a, long b) {
                if (b == 0) {
                    return a;
                }
                return GetGCD(b, a % b);
            }
            
            public bool isCoPrime(long a, long b) {
                long gcd = GetGCD(a, b);
                return gcd == 1;
            }

            public void Encrypt()
            {
                cipherB = new byte[plaintextB.Length*4];
                cipherS = new short[plaintextB.Length * 2];
                long a, b;
                long y = pow(g, x, p);
                this.y = y;
                for (int i = 0; i < plaintextB.Length; i++)
                {
                    a = pow(g, k, p);
                    var temp = pow(y, k, p);
                    b = pow(temp * pow(plaintextB[i],1,p), 1, p);
                    byte a1 = (byte)a; 
                    byte a2 = (byte)(a >> 8); 
                    byte b1 = (byte)b; 
                    byte b2 = (byte)(b >> 8);
                    cipherS[i << 1] = (short)a;
                    cipherS[(i << 1) + 1] = (short)b;
                    cipherB[i<<2] = a1;
                    cipherB[(i << 2) + 1] = a2;
                    cipherB[(i << 2) + 2] = b1;
                    cipherB[(i << 2) + 3] = b2;
                }
                Decrypt();
            }

            public void Decrypt()
            {
                plaintextB = new byte[cipherB.Length/4];
               // short  b;
                for (int i = 0; i < plaintextB.Length; i++)
                {
                  //  b = cipherB[(i << 1) + 1];
                    byte a1 = cipherB[i<<2];
                    byte a2 = cipherB[(i << 2) + 1];
                    byte b1 = cipherB[(i << 2) + 2];
                    byte b2 = cipherB[(i << 2) + 3];
                    short a = (short)((a2 << 8) | a1);
                    short b = (short)((b2 << 8) | b1);
                    a = (short)pow(a, p-1-x, p);
                    b = (short)pow(b, 1, p);
                    plaintextB[i] = (byte)pow(a * b, 1, p);
                }
            }

        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}