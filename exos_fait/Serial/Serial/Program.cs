
using System.Text.Json;

Actor Actor = new Actor
{
    FirstName = "Jean",
    LastName = "Dujardin",
    BirthDate = new DateTime(2000, 11, 5),
    Country = "France",
    IsAlive = true
};

Character character = new Character 
{
    FirstName = "René",
    LastName = "Bernard",
    Description = "Personnage secondaire de la série",
    PlayedBy = Actor
};

string jsonCharacter = JsonSerializer.Serialize(character);
File.WriteAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\rene.json", jsonCharacter);

string jsonActor = JsonSerializer.Serialize(Actor);
File.WriteAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\Dujardin.json", jsonActor);

string jsonEliottin = File.ReadAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\eliottin.json");
string jsonRene = File.ReadAllText("C:\\Users\\pk50gbi\\Documents\\GitHub\\321-Prog_distrib\\exos_fait\\Serial\\rene.json");

Character Eliottin = JsonSerializer.Deserialize<Character>(jsonEliottin);
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