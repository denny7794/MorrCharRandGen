// Создаем список строк

List<string> genders = new List<string>()
    {"Мужской","Женский"};
string gender = chooseParameter(genders);
System.Console.WriteLine(gender);

List<string> specializations = new List<string>()
    {"Боец","Маг","Бродяга"};
string specialization = chooseParameter(specializations);
System.Console.WriteLine(specialization);

List<string> attributes = new List<string>()
    {"Сила","Интеллект","Сила воли", "Ловкость", "Скорость", "Выносливость", "Привлекательность", "Удача"};
string attribute1 = chooseParameter(attributes);
System.Console.WriteLine(attribute1);
string attribute2 = chooseParameter(attributes);
System.Console.WriteLine(attribute2);



/* // Создаем объект Random
Random random = new Random();

// Генерируем случайное число от 0 до последнего индекса коллекции
int randomNumber = random.Next(0, specializations.Count);
// Выводим результат
string specialization = specializations[randomNumber];
Console.WriteLine(specialization); */



// ЗАПИСЫВАЕМ СГЕНЕРИРОВАННОЕ В ФАЙЛ

string filePath = "RandChar.txt";
// Используем StreamWriter для записи в файл
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("ПОЛ:");
    writer.WriteLine(gender);
    writer.WriteLine("");
    writer.WriteLine("СПЕЦИАЛИЗАЦИЯ:");
    writer.WriteLine(specialization);
    writer.WriteLine("");
    writer.WriteLine("ГЛАВНЫЕ ХАРАКТЕРИСТИКИ:");
    writer.WriteLine(attribute1);
    writer.WriteLine(attribute2);
    writer.WriteLine("");
}

Console.WriteLine("Файл успешно создан и данные записаны.");

string chooseParameter(List<string> list)
{
    Random random = new Random();
    int index = random.Next(0, list.Count);
    string result = list[index];
    list.RemoveAt(index);
    return result;
}