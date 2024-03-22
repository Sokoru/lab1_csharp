using System;

namespace lab1
{
    public class Program
    {
        // Метод для обчислення суми та добутку цифр
        static public void CalculateSumAndProduct(int number, out int sum, out int product)
        {
            sum = 0;
            product = 1;

            // Розділити число на цифри та обчислити суму та добуток
            while (number != 0)
            {
                int digit = number % 10; // Отримати останню цифру
                sum += digit; // Додати цифру до суми
                product *= digit; // Помножити цифру на добуток
                number /= 10; // Видалити останню цифру з числа
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть чотиризначне число:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int d) || input.Length != 4)
            {
                Console.WriteLine("Некоректне введення числа. Будь ласка, введіть чотиризначне число.");
                Main(args); // Повторний виклик Main для введення правильного числа
                return;
            }

            int sum, product;

            // Обчислити суму та добуток цифр за допомогою методу
            CalculateSumAndProduct(d, out sum, out product);

            // Вивести результат
            Console.WriteLine("Сума цифр: " + sum);
            Console.WriteLine("Добуток цифр: " + product);

            Console.ReadLine(); // Зупинити консоль
        }
    }
}
