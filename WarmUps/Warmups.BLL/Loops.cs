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
        public bool DoubleX(string str)
        {
            bool IsDouble;
            int IndexOfFirstX = 0;
            bool FoundFirstX = false;
            while (!FoundFirstX)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str.Substring(i, 1) == "x")
                    {
                        IndexOfFirstX = i;
                        FoundFirstX = true;
                        break;
                    }
                }
                if (FoundFirstX == false)
                {
                    return false;
                }
            }
            if (str.Substring(IndexOfFirstX + 1, 1) == "x")
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
            string FinalString = "";
            for (int i = 0; i < str.Length; i += 2)
            {
                FinalString += str.Substring(i, 1);
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public string StringSplosion(string str)
        {
            string FinalString = "";
            for (int i = 1; i < str.Length + 1; i++)
            {
                FinalString += str.Substring(0, i);
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public int CountLast2(string str)
        {
            int NumberOfTimes = 0;
            string Last2 = str.Substring(str.Length - 2, 2);
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == Last2)
                {
                    NumberOfTimes += 1;
                }
            }
            return NumberOfTimes;
            throw new NotImplementedException();
        }

        public int Count9(int[] numbers)
        {
            int NumberOf9s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    NumberOf9s += 1;
                }
            }
            return NumberOf9s;
            throw new NotImplementedException();
        }

        public bool ArrayFront9(int[] numbers)
        {
            if (numbers.Length < 4)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 9)
                    {
                        return true;
                    }
                }
            }
            else if (numbers.Length > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (numbers[i] == 9)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
        public bool Array123(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i] == 1)
                {
                    if (numbers[i + 1] == 2)
                    {
                        if (numbers[i + 2] == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
            throw new NotImplementedException();
        }

        public int SubStringMatch(string a, string b)
        {
            int NumberOfMatches = 0;
            {
                if (a.Length <= b.Length)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                        if (a.Substring(i, 2) == b.Substring(i, 2))
                        {
                            NumberOfMatches += 1;
                        }
                }
                else
                {
                    for (int i = 0; i < b.Length - 1; i++)
                        if (b.Substring(i, 2) == a.Substring(i, 2))
                        {
                            NumberOfMatches += 1;
                        }
                }
            }
            return NumberOfMatches;
            throw new NotImplementedException();
        }

        public string StringX(string str)
        {
            string FinalString = "";
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 1) != "x")
                {
                    FinalString += str.Substring(i, 1);
                }
            }
            FinalString = str.Substring(0, 1) + FinalString;
            FinalString = FinalString + str.Substring(str.Length - 1, 1);
            return FinalString;
            throw new NotImplementedException();
        }

        public string AltPairs(string str)
        {
            if (str.Length < 7)
            {
                return str.Substring(0, 2) + str.Substring(4, 2);
            }
            else if (str.Length == 9)
            {
                return str.Substring(0, 2) + str.Substring(4, 2) + str.Substring(8, 1);
            }
            else
            {
                return str.Substring(0, 2) + str.Substring(4, 2) + str.Substring(8, 2);
            }
            throw new NotImplementedException();
        }

        public string DoNotYak(string str)
        {
            if (str.Contains("yak"))
            {
                return str.Replace("yak", "");
            }
            else
            {
                return str;
            }
            throw new NotImplementedException();
        }

        public int Array667(int[] numbers)
        {
            int NumberOfTimes = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && numbers[i + 1] == 6 || numbers[i + 1] == 7)
                {
                    NumberOfTimes += 1;
                }
            }
            return NumberOfTimes;
            throw new NotImplementedException();
        }

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
            throw new NotImplementedException();
        }

        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 5)
                {
                    if (numbers[i + 2] == numbers[i] - 1)
                    {
                        return true;
                    }
                }
            }
            return false;
            throw new NotImplementedException();
        }

    }
}
