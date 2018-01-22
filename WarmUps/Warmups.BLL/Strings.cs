using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
            throw new NotImplementedException();
        }

        public string MakeTags(string tag, string content)
        {
            return $"<{tag}>{content}</{tag}>";
            throw new NotImplementedException();
        }

        public string InsertWord(string container, string word)
        {
            string FinalString = "";
            FinalString = container.Substring(0, 2) + word + container.Substring(2, 2);
            return FinalString;
            throw new NotImplementedException();
        }

        public string MultipleEndings(string str)
        {
            string Last2 = str.Substring(str.Length - 2, 2);
            return Last2 + Last2 + Last2;
            throw new NotImplementedException();
        }

        public string FirstHalf(string str)
        {
            int HalfStringLength = str.Length / 2;
            return str.Substring(0, HalfStringLength);
            throw new NotImplementedException();
        }

        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
            throw new NotImplementedException();
        }

        public string LongInMiddle(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a + b + a;
            }
            else
            {
                return b + a + b;
            }
            throw new NotImplementedException();
        }

        public string RotateLeft2(string str)
        {
            return str.Substring(2, str.Length - 2) + str.Substring(0, 2);
            throw new NotImplementedException();
        }

        public string RotateRight2(string str)
        {
            return str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2);
            throw new NotImplementedException();
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1, 1);
            }
            throw new NotImplementedException();
        }

        public string MiddleTwo(string str)
        {
            int StringStart = (str.Length / 2) - 1;
            return str.Substring(StringStart, 2);
            throw new NotImplementedException();
        }

        public bool EndsWithLy(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            else if (str.Substring(str.Length - 2, 2) == "ly")
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
        //come back to here joshua causey
        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
            throw new NotImplementedException();
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (n + 2 > str.Length)
            {
                return str.Substring(0, 2);
            }
            else
            {
                return str.Substring(n, 2);
            }
            throw new NotImplementedException();
        }

        public bool HasBad(string str)
        {
            if (str.Length > 3)
            {
                if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public string AtFirst(string str)
        {
            if (str.Length > 1)
            {
                return str.Substring(0, 2);
            }
            else if (str == "")
            {
                return "@@";
            }
            else
            {
                return str.Substring(0, 1) + "@";
            }
            throw new NotImplementedException();
        }

        public string LastChars(string a, string b)
        {
            if (a == "" && b == "")
            {
                return "@@";
            }
            else if (a == "")
            {
                return "@" + b.Substring(0, b.Length - 1);
            }
            else if (b == "")
            {
                return a.Substring(0, 1) + "@";
            }
            else
            {
                return a.Substring(0, 1) + b.Substring(b.Length - 1, 1);
            }
            throw new NotImplementedException();
        }

        public string ConCat(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string SwapLast(string str)
        {
            throw new NotImplementedException();
        }

        public bool FrontAgain(string str)
        {
            throw new NotImplementedException();
        }

        public string MinCat(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string TweakFront(string str)
        {
            throw new NotImplementedException();
        }

        public string StripX(string str)
        {
            throw new NotImplementedException();
        }
    }
}
