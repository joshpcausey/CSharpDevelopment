using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            bool GoodParty;
            if (isWeekend)
            {
                if (cigars > 39)
                {
                    GoodParty = true;
                }
                else
                {
                    GoodParty = false;
                }
            }
            else if (cigars > 39 && cigars < 61)
            {
                GoodParty = true;
            }
            else
            {
                GoodParty = false;
            }
            return GoodParty;
            throw new NotImplementedException();
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            int FinalInt;
            if (yourStyle < 3 || dateStyle < 3)
            {
                FinalInt = 0;
            }
            else if (yourStyle > 7 || dateStyle > 7)
            {
                FinalInt = 2;
            }
            else
            {
                FinalInt = 1;
            }
            return FinalInt;
            throw new NotImplementedException();
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            bool AreOutside;
            if (isSummer)
            {
                if (temp > 59 && temp < 101)
                {
                    AreOutside = true;
                }
                else
                {
                    AreOutside = false;
                }
            }
            else if (temp > 59 && temp < 91)
            {
                AreOutside = true;
            }
            else
            {
                AreOutside = false;
            }
            return AreOutside;
            throw new NotImplementedException();
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int Ticket;
            if (isBirthday)
            {
                if (speed > 85)
                {
                    Ticket = 2;
                }
                else if (speed > 66)
                {
                    Ticket = 1;
                }
                else
                {
                    Ticket = 0;
                }
            }
            else if (speed > 80)
            {
                Ticket = 2;
            }
            else if (speed > 61)
            {
                Ticket = 1;
            }
            else
            {
                Ticket = 0;
            }
            return Ticket;
            throw new NotImplementedException();
        }

        public int SkipSum(int a, int b)
        {
            int FinalInt;
            if (a + b >= 10 && a + b <= 19)
            {
                FinalInt = 20;
            }
            else
            {
                FinalInt = a + b;
            }
            return FinalInt;
            throw new NotImplementedException();
        }

        public string AlarmClock(int day, bool vacation)
        {
            string AlarmTime;
            if (vacation)
            {
                if (day >= 1 && day <= 5)
                {
                    AlarmTime = "10:00";
                }
                else
                {
                    AlarmTime = "off";
                }
            }
            else
            {
                if (day >= 1 && day <= 5)
                {
                    AlarmTime = "7:00";
                }
                else
                {
                    AlarmTime = "10:00";
                }
            }
            return AlarmTime;
            throw new NotImplementedException();
        }

        public bool LoveSix(int a, int b)
        {
            bool Is6;
            if (a + b == 6 ||
                a == 6 || b == 6 ||
                a - b == 6)
            {
                Is6 = true;
            }
            else
            {
                Is6 = false;
            }
            return Is6;
            throw new NotImplementedException();
        }

        public bool InRange(int n, bool outsideMode)
        {
            bool IsInRange;
            if (outsideMode)
            {
                if (n <= 1 || n >= 10)
                {
                    IsInRange = true;
                }
                else
                {
                    IsInRange = false;
                }
            }
            else if (n >= 1 && n <= 10)
            {
                IsInRange = true;
            }
            else
            {
                IsInRange = false;
            }
            return IsInRange;
            throw new NotImplementedException();
        }

        public bool SpecialEleven(int n)
        {
            bool IsSpecial;
            if (n % 11 == 0 || n % 11 == 1)
            {
                IsSpecial = true;
            }
            else
            {
                IsSpecial = false;
            }
            return IsSpecial;
            throw new NotImplementedException();
        }

        public bool Mod20(int n)
        {
            bool FinalBool;
            if (n % 20 == 1 || n % 20 == 2)
            {
                FinalBool = true;
            }
            else
            {
                FinalBool = false;
            }
            return FinalBool;
            throw new NotImplementedException();
        }

        public bool Mod35(int n)
        {
            bool IsMultiple;
            if (n % 3 == 0 ^ n % 5 == 0)
            {
                IsMultiple = true;
            }
            else
            {
                IsMultiple = false;
            }
            return IsMultiple;
            throw new NotImplementedException();
        }

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            bool AnswerPhone;
            if (isAsleep)
            {
                AnswerPhone = false;
            }
            else if (isMom)
            {
                AnswerPhone = true;
            }
            else if (isMorning)
            {
                AnswerPhone = false;
            }
            else
            {
                AnswerPhone = true;
            }
            return AnswerPhone;
            throw new NotImplementedException();
        }

        public bool TwoIsOne(int a, int b, int c)
        {
            bool IsEqual;
            if (a + b == c || c + a == b || b + c == a)
            {
                IsEqual = true;
            }
            else
            {
                IsEqual = false;
            }
            return IsEqual;
            throw new NotImplementedException();
        }

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            bool IsTrue;
            if (bOk)
            {
                if (c > b)
                {
                    IsTrue = true;
                }
                else
                {
                    IsTrue = false;
                }

            }
            else if (b > a && c > b)
            {
                IsTrue = true;
            }
            else
            {
                IsTrue = false;
            }
            return IsTrue;
            throw new NotImplementedException();
        }

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            bool IsTrue;
            if (equalOk)
            {
                if (a <= b && c >= b)
                {
                    IsTrue = true;
                }
                else
                {
                    IsTrue = false;
                }
            }
            else if (a < b && b < c)
            {
                IsTrue = true;
            }
            else
            {
                IsTrue = false;
            }
            return IsTrue;
            throw new NotImplementedException();
        }

        public bool LastDigit(int a, int b, int c)
        {
            bool IsEqual;
            if (a % 10 == b % 10 ||
                a % 10 == c % 10)
            {
                IsEqual = true;
            }
            else
            {
                IsEqual = false;
            }
            return IsEqual;
            throw new NotImplementedException();
        }

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            int SumOfDice;
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    if (die1 == 6)
                    {
                        die1 = 1;
                        SumOfDice = die1 + die2;
                    }
                    else
                    {
                        die1 += 1;
                        SumOfDice = die1 + die2;
                    }
                }
                else
                {
                    SumOfDice = die1 + die2;
                }
            }
            else
            {
                SumOfDice = die1 + die2;
            }
            return SumOfDice;
            throw new NotImplementedException();
        }

    }
}
