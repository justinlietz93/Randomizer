using SQLite;

namespace RandomizerApp.Models;

public class Entity
{
    [PrimaryKey, AutoIncrement] public int ID { get; set; }

    public string Name { get; set; }
    
}