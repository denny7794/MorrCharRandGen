// Создаем список строк

List<string> genders = new List<string>()
    {"Мужской","Женский"};
string gender = chooseParameter(genders);
System.Console.WriteLine(gender);

List<string> races = new List<string>()
    {"Аргониание","Бретон", "Высокий эльф", "Имперец", "Лесной эльф",
    "Нордлинг", "Орк", "Темный эльф", "Хаджит"};
string race = chooseParameter(races);
System.Console.WriteLine(race);

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

List<string> skills = new List<string>()
    {"Защита", "Зачарование", "Безопасность",
    "Кузнец", "Разрушение", "Скрытность",
    "Средние доспехи", "Изменения", "Акробатика",
    "Тяжелые доспехи", "Иллюзии", "Легкие доспехи",
    "Дробящее оружие", "Колдовство", "Короткие клинки",
    "Длинные клинки", "Мистицизм", "Меткость",
    "Секиры", "Восстановление", "Торговля",
    "Древковое оружие", "Алхимия", "Красноречие",
    "Атлетика", "Бездоспешный бой", "Рукопашный бой"};

List<string> majorSkills = new List<string>();
List<string> minorSkills = new List<string>();

for (int i = 0; i < 5; i++)
{
    majorSkills.Add(chooseParameter(skills));
    minorSkills.Add(chooseParameter(skills));
}



// ЗАПИСЫВАЕМ СГЕНЕРИРОВАННОЕ В ФАЙЛ

string filePath = "RandChar.txt";
// Используем StreamWriter для записи в файл
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("ПОЛ:");
    writer.WriteLine(gender);
    writer.WriteLine("");
    writer.WriteLine("РАСА:");
    writer.WriteLine(race);
    writer.WriteLine("");
    writer.WriteLine("СПЕЦИАЛИЗАЦИЯ:");
    writer.WriteLine(specialization);
    writer.WriteLine("");
    writer.WriteLine("ГЛАВНЫЕ ХАРАКТЕРИСТИКИ:");
    writer.WriteLine(attribute1);
    writer.WriteLine(attribute2);
    writer.WriteLine("");
    writer.WriteLine("ГЛАВНЫЕ НАВЫКИ:");
    foreach (var skill in majorSkills)
    {
        writer.WriteLine(skill);
    }
    writer.WriteLine("");
    writer.WriteLine("ВАЖНЫЕ НАВЫКИ:");
    foreach (var skill in minorSkills)
    {
        writer.WriteLine(skill);
    }
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