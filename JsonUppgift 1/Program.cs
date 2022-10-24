using System.Text.Json;
using JsonÖvningar;

var movieDb = new MovieCollection();

//Path.Combine används för att bygga sökvägar på ett korrekt sätt.
//I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Demo.json");

//File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg
if (!File.Exists(path))
{
    var options = new JsonSerializerOptions();
    options.WriteIndented = true;
    var json = JsonSerializer.Serialize(movieDb.Movies, options);
    //StreamWriter används för att öppna en fil och skriva till den.
    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
    using StreamWriter sw = new StreamWriter(path);
    //foreach (var movie in movieDb.Movies)
    //{
    //    //WriteLine används för att skriva en ny rad.
    //    sw.WriteLine(movie);
    //}
    sw.WriteLine(json);
}

if (File.Exists(path))
{
    var text = String.Empty;
    string? line = String.Empty;
    //StreamReader används för att öppna en fil och läsa från den.
    //nyckelordet using används här för att på ett säkert sätt stänga den öppnade filen så den inte är låst efter operationen
    using StreamReader sr = new StreamReader(path);
    //ReadLine() läser nästa rad i filen

    //För att skriva ut exakt vad som står i JSON filen
    while ((line = sr.ReadLine()) != null)
    {
        text += line;
        Console.WriteLine(line);
    }

    //För att göra om JSON filen till objekt
    var movies = JsonSerializer.Deserialize<List<Movie>>(text);

    //Skriver ut movies som är från JSON filen på ett fint sett.
    if (movies is not null)
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }
    }

    //Skriv en applikation som läser in alla rader men bara skriver ut titlarna på filmer med genre SciFi
    //Tror vi behöver leta efter ord, kan inte skriva movie.Genres.Equals("SciFi"eller 1) för att programmet ser bara en lång radda bokstäver.

    if (movies is not null)
    {
        //Där movies har en genre där genre är scifi
        var sciFiMovies = movies.Where(m => m.Genres.Any(g => g == Genres.SciFi));

        foreach (var sciFiMovie in sciFiMovies)
        {
            Console.WriteLine(sciFiMovie.Title);
        }

    }
}