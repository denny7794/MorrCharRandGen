// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string filePath = "example.txt";

// Используем StreamWriter для записи в файл
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("Первая строка");
    writer.WriteLine("Вторая строка");
    writer.WriteLine("Третья строка2");
}

Console.WriteLine("Файл успешно создан и данные записаны.");