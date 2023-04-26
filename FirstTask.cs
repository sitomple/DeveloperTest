namespace Library
{
    //Никогда не писать русские слова английскими буквами.
    public class TaskOne
    {
        // Был добавлен модификатор static чтобы выхывать метод без объявления экземпляра
        public static void One()
        {
            Console.Write("Введите число N: ");
            //Доавленна проверка try-catch, ведь пользователь может ввести не число.
            try
            {
                //переменные надо называть понятно, а не 1 буквой.
                int number = int.Parse(Console.ReadLine());
                string result = string.Join(", ", Enumerable.Range(1, number));
                //не ясный пользователю вывод информации 
                Console.WriteLine($"\nВот порядок чисел до вашего введённого числа N - {number}: \n");
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
    //Никогда не писать русские слова английскими буквами.
    public class TaskTwo
    {
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            try
            {
                 //переменные надо называть понятно, а не 1 буквой.
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) // If N is an even number, exit the function.
                {
                    Console.WriteLine("Вы ввели четное N.");
                    return;
                }            
                //для циклов используются по правилу хорошего тона i, j - переменные, но не критично
                //перебор всегда начинается с 0
                for (int row = 0; row <= number; row++) {
                    for (int col = 0; col <= number; col++) {
                        if (row == number / 2 + 1 && col == number / 2 + 1) // для повышения читабильности кода, действия в условиях всегда пишутся под условиями.
                            Console.Write(" ");
                        else // для повышения читабильности кода, действия в условиях всегда пишутся под условиями.
                            Console.Write("#");                    
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
}
