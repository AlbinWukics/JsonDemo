using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Linq;
using ReadWriteFileDemo;
using static System.Net.Mime.MediaTypeNames;

var movieDb = new MovieCollection();

var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"Demo.json");

// var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"QuizQuestionsLab-3\QuizQuestions.json");

//var path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Demo.json");

//var json = JsonSerializer.Serialize(movieDb.Movies, new JsonSerializerOptions() { WriteIndented = true });


if (!File.Exists(path))
{
    Console.WriteLine("Skapar filer");

    using StreamWriter sw = new StreamWriter(path); //Skapar filer

    foreach (var genre in Enum.GetValues<Genres>())
    {

        var json = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"{genre}.json");

        using StreamWriter genreJson = new StreamWriter(json);

   
    }
    
}

if (File.Exists(path))
{
    Console.WriteLine("Hittade filer");
}

//var jsonGenre = JsonSerializer.Serialize()


    //StreamWriter används för att öppna en fil och skriva till den.
    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
   

    ////foreach (var movie in movieDb.Movies)
    ////{
    ////    //WriteLine används för att skriva en ny rad.
    ////    sw.WriteLine(movie);
    ////}
    //sw.WriteLine(json);

//if (File.Exists(path2))
//{
//    var text = string.Empty;
//    string? line = string.Empty;
//    //StreamReader används för att öppna en fil och läsa från den.
//    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
//    using StreamReader sr = new StreamReader(path2);
//    //ReadLine() läser nästa rad i filen
//    while ((line = sr.ReadLine()) != null)
//    {
//        text += line;
//    }

//    var movies = JsonSerializer.Deserialize<List<Movie>>(text);

//    //var mySciFi = movies.Where(x => x.Genres.Any(x => x == Genres.SciFi));

//    //foreach (var movie in mySciFi)
//    //{
//    //    Console.WriteLine(movie.Title);
//    //}
//}






////Path.Combine används för att bygga sökvägar på ett korrekt sätt.
////I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
////var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Demo.json");

//var path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Demo.json");


////File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
//if (!File.Exists(path2))
//{


//    //var options = new JsonSerializerOptions();
//    //options.WriteIndented = true;

//    var json = JsonSerializer.Serialize(movieDb.Movies, new JsonSerializerOptions() { WriteIndented = true });

//    //var jsonGenre = JsonSerializer.Serialize()


//    //StreamWriter används för att öppna en fil och skriva till den.
//    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen

//    using StreamWriter sw = new StreamWriter(path2);

//    ////foreach (var movie in movieDb.Movies)
//    ////{
//    ////    //WriteLine används för att skriva en ny rad.
//    ////    sw.WriteLine(movie);
//    ////}
//    //sw.WriteLine(json);
//}

////if (File.Exists(path2))
////{
////    var text = string.Empty;
////    string? line = string.Empty;
////    //StreamReader används för att öppna en fil och läsa från den.
////    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
////    using StreamReader sr = new StreamReader(path2);
////    //ReadLine() läser nästa rad i filen
////    while ((line = sr.ReadLine()) != null)
////    {
////        text += line;
////    }

////    var movies = JsonSerializer.Deserialize<List<Movie>>(text);

////    //var mySciFi = movies.Where(x => x.Genres.Any(x => x == Genres.SciFi));

////    //foreach (var movie in mySciFi)
////    //{
////    //    Console.WriteLine(movie.Title);
////    //}
////}