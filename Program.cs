// Создаем список строк
List<string> specialization = new List<string>();

// Добавляем элементы
specialization.Add("Fighter");
specialization.Add("Thief");
specialization.Add("Mage");


// Создаем объект Random
Random random = new Random();
// Генерируем случайное число от 0 до 2 (включительно)
int randomNumber = random.Next(0, 3);
// Выводим результат
Console.WriteLine(specialization[randomNumber]);

//string filePath = "example.txt";

// Используем StreamWriter для записи в файл
/* using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("Первая строка");
    writer.WriteLine("Вторая строка");
    writer.WriteLine("Третья строка2");
}

Console.WriteLine("Файл успешно создан и данные записаны."); */