using System;
using System.Collections;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var arrayList = new ArrayList(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    arrayList.Remove(numbers[i]);
                }
            }

            numbers = arrayList.ToArray(typeof(int)) as int[];

            return numbers;
        }
    }
}
