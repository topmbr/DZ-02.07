class Program
{
    static void Main(string[] args)
    {
        string rootPath = "C:\\"; // Путь

        TraverseDirectories(rootPath);

        Console.WriteLine("Обход каталогов завершен.");
        Console.ReadKey();
    }

    static void TraverseDirectories(string path)
    {
        try
        {
            // Обход файлов в текущем каталоге
            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine(file);
            }

            // Рекурсивный обход подкаталогов
            foreach (string directory in Directory.GetDirectories(path))
            {
                TraverseDirectories(directory);
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"Отказано в доступе к каталогу: {path}");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"Каталог не найден: {path}");
        }
        catch (IOException)
        {
            Console.WriteLine($"Ошибка ввода-вывода при доступе к каталогу: {path}");
        }
    }
}