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

            int? number = 10;
            PrinNullableTypeDetails(number, -10);
            
        }

        private static void PrinNullableTypeDetails<T>(T? value, T defaultvalue)
            where T:struct
        {
            Console.WriteLine("***********************************");
            Console.WriteLine($"flag = {value}");
            Console.WriteLine($"flag.GetValueOrDefault() = {value.GetValueOrDefault()}");
            Console.WriteLine($"flag.HasValue = {value.HasValue}");
            if (value.HasValue)
            {
                Console.WriteLine($"flag.Value = {value.Value}");
            }
            
            Console.WriteLine($"flag.GetValueOrDefault(true) = {value.GetValueOrDefault(defaultvalue)}");
            Console.WriteLine("***********************************");
        }
    }
}
