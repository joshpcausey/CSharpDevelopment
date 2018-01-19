using System;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            string MultipliedString = "";
            for (int i = 0; i < n; i++)
            {
                MultipliedString += str;
            }
            return MultipliedString;
            throw new NotImplementedException();
        }

        public string FrontTimes(string str, int n)
        {
            string FinalString = "";
            if (str.Length < 3)
            {
                for (int i = 0; i < n; i++)
                {
                    FinalString += str;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    FinalString += str.Substring(0, 3);
                }
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public int CountXX(string str)
        {
            int FinalCountOfX = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2) == "xx")
                {
                    FinalCountOfX += 1;
                }
            }
            return FinalCountOfX;
            throw new NotImplementedException();
        }
        //COME BACK
        public bool DoubleX(string str)
        {
            bool IsDouble;
            int IndexOfFirstX = 0;
            bool FoundFirstX = false;
            while (!FoundFirstX)
            {
                for(int i = 0; i < str.Length -1; i++)
                {
                    if(str.Substring(i,1) == "x")
                    {
                        IndexOfFirstX = i;
                        FoundFirstX = true;
                        break;
                    }
                }
                if(FoundFirstX == false)
                {
                    return false;
                }
            }
            if(str.Substring(IndexOfFirstX + 1, 1) == "x")
            {
                IsDouble = true;
            }
            else
            {
                IsDouble = false;
            }
            return IsDouble;
            throw new NotImplementedException();
        }

        public string EveryOther(string str)
        {
            throw new NotImplementedException();
        }

        public string StringSplosion(string str)
        {
            throw new NotImplementedException();
        }

        public int CountLast2(string str)
        {
            throw new NotImplementedException();
        }

        public int Count9(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool ArrayFront9(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Array123(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SubStringMatch(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string StringX(string str)
        {
            throw new NotImplementedException();
        }

        public string AltPairs(string str)
        {
            throw new NotImplementedException();
        }

        public string DoNotYak(string str)
        {
            throw new NotImplementedException();
        }

        public int Array667(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool NoTriples(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Pattern51(int[] numbers)
        {
            throw new NotImplementedException();
        }

    }
}
