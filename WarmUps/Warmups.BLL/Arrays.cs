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
            throw new NotImplementedException();
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

        public bool HasEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] KeepLast(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Double23(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] Fix23(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool Unlucky1(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int[] Make2(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

    }
}
