using System;

namespace Warmups.BLL
{
    public class Arrays
    {

        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool SameFirstLast(int[] numbers)
        {
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
        //having trouble come back
        public int[] MakePi(int n)
        {
            int[] Pi = new int[] { 3, 1, 4, 1, 5 };
            int[] ReturnArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                ReturnArray[i] = Pi[i];
            }
            return ReturnArray;
            throw new NotImplementedException();
        }

        public bool CommonEnd(int[] a, int[] b)
        {
            bool SameFirstOrLast = false;
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                SameFirstOrLast = true;
            }
            return SameFirstOrLast;
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int FinalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                FinalSum += numbers[i];
            }
            return FinalSum;
            throw new NotImplementedException();
        }

        public int[] RotateLeft(int[] numbers)
        {
            int[] RotatedLeft = new int[3];
            RotatedLeft[0] = numbers[1];
            RotatedLeft[1] = numbers[2];
            RotatedLeft[2] = numbers[0];
            return RotatedLeft;
            throw new NotImplementedException();
        }

        public int[] Reverse(int[] numbers)
        {
            int[] Reversed = new int[numbers.Length];
            for (int i = 1; i <= numbers.Length; i++)
            {
                Reversed[i - 1] = numbers[numbers.Length - i];
            }
            return Reversed;
            throw new NotImplementedException();
        }

        public int[] HigherWins(int[] numbers)
        {
            int[] ReturnArray = new int[numbers.Length];
            int Largest;
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Largest = numbers[0];
            }
            else if (numbers[0] > numbers[numbers.Length - 1])
            {
                Largest = numbers[0];
            }
            else
            {
                Largest = numbers[numbers.Length - 1];
            }
            for (int i = 0; i < ReturnArray.Length; i++)
            {
                ReturnArray[i] = Largest;
            }
            return ReturnArray;
            throw new NotImplementedException();
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] ReturnArray = new int[2];
            ReturnArray[0] = a[1];
            ReturnArray[1] = b[1];
            return ReturnArray;
            throw new NotImplementedException();
        }

        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
            throw new NotImplementedException();
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] ReturnArray = new int[numbers.Length * 2];
            ReturnArray[ReturnArray.Length - 1] = numbers[numbers.Length - 1];
            return ReturnArray;
            throw new NotImplementedException();
        }

        public bool Double23(int[] numbers)
        {
            int TwoCount = 0;
            int ThreeCount = 0;
            bool HasMultiple = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    TwoCount += 1;
                }
                else if (numbers[i] == 3)
                {
                    ThreeCount += 1;
                }
            }
            if (TwoCount == 2 || ThreeCount == 3)
            {
                HasMultiple = true;
            }
            return HasMultiple;
            throw new NotImplementedException();
        }

        public int[] Fix23(int[] numbers)
        {
            int[] ReturnArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i <= 1)
                {
                    if (numbers[i] == 2 && numbers[i + 1] == 3)
                    {
                        ReturnArray[i] = 2;
                        ReturnArray[i + 1] = 0;
                        i += 1;
                    }
                    else
                    {
                        ReturnArray[i] = numbers[i];
                    }
                }
                else
                {
                    ReturnArray[i] = numbers[i];
                }
            }
            return ReturnArray;
            throw new NotImplementedException();
        }

        public bool Unlucky1(int[] numbers)
        {
            if (numbers[0] == 1 && numbers[1] == 3 ||
                numbers[1] == 1 && numbers[2] == 3)
            {
                return true;
            }
            else if (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public int[] Make2(int[] a, int[] b)
        {
            int[] ReturnArray = new int[2];
            if (a.Length > 1)
            {
                for (int i = 0; i < ReturnArray.Length; i++)
                {
                    ReturnArray[i] = a[i];
                }
            }
            else if (a.Length == 1)
            {
                ReturnArray[0] = a[0];
                ReturnArray[1] = b[0];
            }
            else
            {
                for (int i = 0; i < ReturnArray.Length; i++)
                {
                    ReturnArray[i] = b[i];
                }
            }
            return ReturnArray;
            throw new NotImplementedException();
        }

    }
}
