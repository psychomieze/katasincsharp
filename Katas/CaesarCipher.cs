using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class CaesarCipher
    {
        private const int ALPHA_LETTERS = 26;
        private static int shiftState;

        public static List<string> movingShift(string s, int shift)
        {
            shiftState = shift;
            char[] charArr = ShiftString(s);
            int partLength = Convert.ToInt32(Math.Ceiling(charArr.Length / 5.00));
            return ConvertStringInSplittedAndCodedParts(charArr, partLength);
        }

        private static List<string> ConvertStringInSplittedAndCodedParts(char[] charArr, int partLength)
        {
            List<string> result = new List<string>();

            string partString = "";
            for (int i = 1; i <= charArr.Length; i++)
            {
                partString += charArr[i - 1].ToString();
                if (i%partLength == 0)
                {
                    result.Add(partString);
                    partString = "";
                }
            }
            result.Add(partString);
            return result;
        }

        private static char[] ShiftString(string s, bool reverse = false)
        {
            char[] buffer = s.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char oldLetter = buffer[i];
                char newLetter = (char)(oldLetter + shiftState);
                ShiftShiftState(reverse);

                if (IsInvalidChar(oldLetter)) continue;

                newLetter = HandleOverflow(oldLetter, newLetter, 'A', 'Z');;
                newLetter = HandleOverflow(oldLetter, newLetter, 'a', 'z'); ;
                buffer[i] = newLetter;
            }
            return buffer;
        }


        private static char HandleOverflow(char oldLetter, char newLetter, char lowerBoundary, char upperBoundary)
        {
            if (oldLetter >= lowerBoundary && oldLetter <= upperBoundary)
            {
                if (newLetter > upperBoundary)
                {
                    newLetter = (char) (newLetter - ALPHA_LETTERS);
                }
                else if (newLetter < lowerBoundary)
                {
                    newLetter = (char) (newLetter + ALPHA_LETTERS);
                }
            }
            return newLetter;
        }

        private static bool IsInvalidChar(char oldLetter)
        {
            if (oldLetter < 'A' || oldLetter > 'z' || (oldLetter > 'Z' && oldLetter < 'a'))
            {
                return true;
            }
            return false;
        }

        private static void ShiftShiftState(bool reverse)
        {
            if (Math.Abs(shiftState) >= ALPHA_LETTERS) shiftState = 0;
            if (reverse)
            {
                shiftState--;
            }
            else
            {
                shiftState++;
            }
        }

        public static string demovingShift(List<string> s, int shift)
        {
            shiftState = -shift;
            string message = string.Join("", ShiftString(string.Join("", s), true).Select(c => c.ToString()));

            return message;
        }

    }
}