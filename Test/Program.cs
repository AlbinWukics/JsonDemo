using System.Collections.Generic;

class MyClass
{
    public static void FindQuizFiles()
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Lab-3_QuizQuestions");
        var path2 = Directory.GetFiles(path, ".json");
        foreach (var p in path2)
        {
            Console.WriteLine(p);
        }

    }
    static void Main(string[] args)
    {
        FindQuizFiles();
    }
}