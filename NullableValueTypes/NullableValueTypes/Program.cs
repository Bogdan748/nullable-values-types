using System;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            bool? flag = true;
            //? nullable e boolean Nullable<bool>

            PrinNullableTypeDetails(flag, true);

            int? number = null;
            PrinNullableTypeDetails(number, -10);

            // daca e null da crash:
            //cast implicit ar trebui sa fie evitat
            //int castedbackNumber = (int)number;

            //V1
            int castedBackNumber = number.HasValue 
                ? number.Value 
                : int.MinValue;
            Console.WriteLine(castedBackNumber);

            //V2
            int castedBackNumber2 = number is int intValue
                ? intValue
                : int.MinValue;
            Console.WriteLine(castedBackNumber2);

            //V3 - recomandare1
            int castedBackNumber3 = number ?? int.MinValue;
            Console.WriteLine(castedBackNumber3);

            //V4 - recomandare2
            int castedBackNumber4 = number.GetValueOrDefault(int.MinValue);
            Console.WriteLine(castedBackNumber4);

            int? number2 = 10;
            if (number < number2)
            {
                Console.WriteLine($"{number} is less than {number2}");
            }
            else if (number > number2)
            {
                Console.WriteLine($"{number} is greater than {number2}");
            }
            else if(number == number2)
            {
                Console.WriteLine($"{number} is equal than {number2}");
            }
            else
            {
                Console.WriteLine("Cannot process");
            }


            object obj = number2;
            int? unboxed = (int?)obj;
            //int unboxed = (int)obj;  nu merge
            Console.WriteLine($"Unboxed: {unboxed}.")

;        }

        private static void PrinNullableTypeDetails<T>(T? value, T defaultvalue)
            where T:struct
        {
            Console.WriteLine("***********************************");
            Console.WriteLine($"flag = {value}");
            Console.WriteLine($"flag.GetValueOrDefault() = {value.GetValueOrDefault()}");
            Console.WriteLine($"flag.HasValue = {value.HasValue}");

            bool isNull = value is null;
            if (!isNull)
            {
                Console.WriteLine($"flag.Value = {value.Value}");
            }
            
            Console.WriteLine($"flag.GetValueOrDefault(true) = {value.GetValueOrDefault(defaultvalue)}");
            Console.WriteLine("***********************************");
        }
    }
}
