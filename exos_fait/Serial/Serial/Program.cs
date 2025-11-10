using System.Text.Json;

Episode episode = new Episode
{
    Title = "La petite maison dans la prairie",
    DurationMinutes = 35,
    SequenceNumber = 12,
    Director = "Orson Krennic",
    Synopsis = "René par à la recherche de son chien perdu dans la forêt",
    Characters = new List<Character>
    {
        new Character
        {
            FirstName = "René",
            LastName = "Bernard",
            Description = "Personnage secondaire de la série",
            PlayedBy = new Actor
            {
                FirstName = "Jean",
                LastName = "Dujardin",
                BirthDate = new DateTime(2000, 11, 5),
                Country = "France",
                IsAlive = true
            }
        }
    }
};

string jsonEpisode = JsonSerializer.Serialize(episode);
File.WriteAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\episode.json", jsonEpisode);

string jsonCharacter = JsonSerializer.Serialize(episode.Characters[0]);
File.WriteAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\rene.json", jsonCharacter);

string jsonActor = JsonSerializer.Serialize(episode.Characters[0].PlayedBy);
File.WriteAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\Dujardin.json", jsonActor);

string jsonRene = File.ReadAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\rene.json");

Character perso = JsonSerializer.Deserialize<Character>(jsonRene);

Console.WriteLine($"Le personnage de {perso.FirstName} {perso.LastName} est joué par {perso.PlayedBy.FirstName} {perso.PlayedBy.LastName}");

public class Character
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public Actor PlayedBy { get; set; }
}

public class Actor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public bool IsAlive { get; set; }
}

public class Episode
{
    public string Title { get; set; }
    public int DurationMinutes { get; set; }
    public int SequenceNumber { get; set; }
    public string Director { get; set; }
    public string Synopsis { get; set; }
    public List<Character> Characters { get; set; } = new List<Character>();
}