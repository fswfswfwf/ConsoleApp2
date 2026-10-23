// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace ComputerApp
{
    // Описание класса Computer (вычислительная машина)
    class Computer
    {
        // Открытые поля
        public int inventoryNumber;   // инвентарный номер
        public double cpuFrequency;   // частота процессора (ГГц)
        public int hardDriveSize;     // объём жёсткого диска (ГБ)

        // Метод для вывода данных о компьютере на экран
        public void ShowInfo()
        {
            Console.WriteLine("=== Данные о компьютере ===");
            Console.WriteLine($"Инвентарный номер: {inventoryNumber}");
            Console.WriteLine($"Частота процессора: {cpuFrequency} ГГц");
            Console.WriteLine($"Объём жёсткого диска: {hardDriveSize} ГБ");
        }

        // Метод расчёта стоимости внешней памяти
        // Параметр pricePerGB — стоимость одного гигабайта
        public double CalculateMemoryCost(double pricePerGB)
        {
            return hardDriveSize * pricePerGB;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаём объект Computer
            Computer comp = new Computer();

            // 2. Задаём значения полям объекта
            comp.inventoryNumber = 123345;
            comp.cpuFrequency = 1.5;
            comp.hardDriveSize = 400;

            // 3. Выводим значения полей на экран
            comp.ShowInfo();

            // 4. Считаем стоимость внешней памяти (100 руб. за 1 ГБ)
            double pricePerGB = 100;
            double totalCost = comp.CalculateMemoryCost(pricePerGB);

            Console.WriteLine();
            Console.WriteLine($"Стоимость внешней памяти ({comp.hardDriveSize} ГБ × {pricePerGB} руб.): {totalCost} руб.");
        }
    }
}