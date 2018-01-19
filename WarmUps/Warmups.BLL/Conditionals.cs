using System;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
            {
                return true;
            }
            else if (aSmile == false && bSmile == false)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            bool sleepIn;
            if (isVacation || !isWeekday)
            {
                sleepIn = true;
            }
            else
            {
                sleepIn = false;
            }
            return sleepIn;
            throw new NotImplementedException();
        }

        public int SumDouble(int a, int b)
        {
            int finalSum;
            if (a == b)
            {
                finalSum = (a += b) * 2;
            }
            else
            {
                finalSum = a += b;
            }
            return finalSum;
            throw new NotImplementedException();
        }

        public int Diff21(int n)
        {
            int finalNumber;
            if (n > 21)
            {
                finalNumber = Math.Abs(n - 21) * 2;
            }
            else
            {
                finalNumber = Math.Abs(n - 21);
            }
            return finalNumber;
            throw new NotImplementedException();
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            bool inTrouble;
            if (isTalking && hour < 7)
            {
                inTrouble = true;
            }
            else if (isTalking && hour > 20)
            {
                inTrouble = true;
            }
            else
            {
                inTrouble = false;
            }
            return inTrouble;
            throw new NotImplementedException();
        }

        public bool Makes10(int a, int b)
        {
            bool Is10;
            if (a == 10 || b == 10 || a + b == 10)
            {
                Is10 = true;
            }
            else
            {
                Is10 = false;
            }
            return Is10;
            throw new NotImplementedException();
        }

        public bool NearHundred(int n)
        {
            bool isNear;
            if (Math.Abs(n - 100) < 11 || Math.Abs(n - 200) < 11)
            {
                isNear = true;
            }
            else
            {
                isNear = false;
            }
            return isNear;
            throw new NotImplementedException();
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            bool isTrue;
            if (negative && a < 0 && b < 0)
            {
                isTrue = true;
            }
            else if (a < 0 ^ b < 0)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
            throw new NotImplementedException();
        }

        public string NotString(string s)
        {
            string finalString;
            if (s.Length > 3)
            {
                if (s.Substring(0, 3) == "not")
                {
                    finalString = s;
                }
                else
                {
                    finalString = "not " + s;
                }
            }
            else
            {
                finalString = "not " + s;
            }
            return finalString;
            throw new NotImplementedException();
        }

        public string MissingChar(string str, int n)
        {
            string finalString;
            finalString = str.Remove(n, 1);
            return finalString;
            throw new NotImplementedException();
        }

        public string FrontBack(string str)
        {
            string FinalString;
            if (str.Length > 1)
            {
                int len = str.Length;
                FinalString = str[len - 1] + str.Substring(1, len - 2) + str[0];
            }
            else
            {
                FinalString = str;
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public string Front3(string str)
        {
            string FinalString;
            if (str.Length > 2)
            {
                string TempString = str.Substring(0, 3);
                FinalString = TempString + TempString + TempString;

            }
            else
            {
                FinalString = str + str + str;
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public string BackAround(string str)
        {
            string FinalString;
            int len = str.Length;
            FinalString = str[len - 1] + str + str[len - 1];
            return FinalString;
            throw new NotImplementedException();
        }

        public bool Multiple3or5(int number)
        {
            bool IsMultiple = false;
            if (number % 3 == 0 || number % 5 == 0)
            {
                IsMultiple = true;
            }
            return IsMultiple;
            throw new NotImplementedException();
        }

        public bool StartHi(string str)
        {
            bool StartsWithHi = false;
            if (str.Length > 3)
            {
                if (str.Substring(0, 3) == "hi ")
                {
                    StartsWithHi = true;
                }
                else
                {
                    if (str.Substring(0, 3) == "hi,")
                    {
                        StartsWithHi = true;
                    }
                }
            }
            else
            {
                if (str.Length == 2 && str.Substring(0, 2) == "hi")
                {
                    StartsWithHi = true;
                }
            }
            return StartsWithHi;
            throw new NotImplementedException();
        }

        public bool IcyHot(int temp1, int temp2)
        {
            bool isIcyHot = false;
            if (temp1 < 0 && temp2 > 100 || temp1 > 100 && temp2 < 0)
            {
                isIcyHot = true;
            }
            return isIcyHot;
            throw new NotImplementedException();
        }

        public bool Between10and20(int a, int b)
        {
            bool IsBetween = false;
            if (a >= 10 && a <= 20 || b >= 10 && b <= 20)
            {
                IsBetween = true;
            }
            return IsBetween;
            throw new NotImplementedException();
        }

        public bool HasTeen(int a, int b, int c)
        {
            if (a > 12 && a < 20 || b > 12 && b < 20 || c > 12 && c < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool SoAlone(int a, int b)
        {
            if ((a > 12 && a < 20) ^ (b > 12 && b < 20))
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public string RemoveDel(string str)
        {
            string FinalString;
            if (str.Substring(1, 3) == "del")
            {
                FinalString = str.Remove(1, 3);
            }
            else
            {
                FinalString = str;
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public bool IxStart(string str)
        {
            bool StartsWithix;
            if (str.Substring(1, 2) == "ix")
            {
                StartsWithix = true;
            }
            else
            {
                StartsWithix = false;
            }
            return StartsWithix;
            throw new NotImplementedException();
        }

        public string StartOz(string str)
        {
            string FinalString;
            if (str.Length > 2)
            {
                if (str.Substring(0, 1) == "o" && str.Substring(1, 1) == "z")
                {
                    FinalString = str.Substring(0, 2);
                }
                else if (str.Substring(0, 1) == "o")
                {
                    FinalString = str.Substring(0, 1);
                }
                else if (str.Substring(1, 1) == "z")
                {
                    FinalString = str.Substring(1, 1);
                }
                else
                {
                    FinalString = "";
                }
            }
            else
            {
                FinalString = "";
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public int Max(int a, int b, int c)
        {
            int MaxNumber;
            MaxNumber = Math.Max(a, Math.Max(b, c));
            return MaxNumber;
            throw new NotImplementedException();
        }

        public int Closer(int a, int b)
        {
            int FinalInt;
            int ADistanceFrom10 = Math.Abs(10 - a);
            int BDistanceFrom10 = Math.Abs(10 - b);
            if (ADistanceFrom10 == BDistanceFrom10)
            {
                FinalInt = 0;
            }
            else if (ADistanceFrom10 < BDistanceFrom10)
            {
                FinalInt = a;
            }
            else
            {
                FinalInt = b;
            }
            return FinalInt;
            throw new NotImplementedException();
        }

        public bool GotE(string str)
        {
            bool isBetween1And3;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == "e")
                {
                    count++;
                }
            }
            if (count < 4 && count > 0)
            {
                isBetween1And3 = true;
            }
            else
            {
                isBetween1And3 = false;
            }
            return isBetween1And3;
            throw new NotImplementedException();
        }

        public string EndUp(string str)
        {
            string FinalString;
            if (str.Length > 3)
            {
                int BreakPoint = str.Length - 3;
                string UpperCasePart = str.Substring(BreakPoint, 3);
                UpperCasePart = UpperCasePart.ToUpper();
                string LowerCasePart = str.Substring(0, BreakPoint);
                LowerCasePart.ToLower();
                FinalString = LowerCasePart + UpperCasePart;
            }
            else
            {
                FinalString = str.ToUpper();
            }
            return FinalString;
            throw new NotImplementedException();
        }

        public string EveryNth(string str, int n)
        {
            string FinalString;
            string TempString = "";
            for (int i = 0; i < str.Length; i += n)
            {
                TempString += str.Substring(i, 1);
            }
            FinalString = TempString;
            return FinalString;
            throw new NotImplementedException();
        }
    }
}
