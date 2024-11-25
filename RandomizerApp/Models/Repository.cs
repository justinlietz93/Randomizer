using SQLite;

namespace RandomizerApp.Models;

public class Repository
{

    private readonly SQLiteConnection _database;
    int prevID = 0;

    public Repository()
    {
        var dbPath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "randomizer.db");

        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Entity>();
    }

    public List<Entity> GetEntities()
    {
        return _database.Query<Entity>("SELECT DISTINCT * FROM Entity ORDER BY Name");
        //return _database.Table<Movie>().ToList();
    }

    public Entity GetRandomEntity()
    {
        var randID = _database.Query<Entity>(@"SELECT DISTINCT * 
                                               FROM Entity 
                                               ORDER BY RANDOM()
                                               LIMIT 1").FirstOrDefault();
        
        var randEntity = _database.Query<Entity>(@"SELECT DISTINCT * 
                                                   FROM Entity 
                                                   ORDER BY RANDOM()
                                                   LIMIT 1").FirstOrDefault();
        
        return randEntity;
    }

    public void SaveEntity(Entity entity)
    {
        _database.Insert(entity);
    }
    
}