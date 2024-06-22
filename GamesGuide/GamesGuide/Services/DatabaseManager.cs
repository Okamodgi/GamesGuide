using SQLite;
using System;
using System.IO;

public class DatabaseContext : SQLiteAsyncConnection
{
    public DatabaseContext(string dbPath) : base(dbPath)
    {
        // Создание таблиц при инициализации базы данных
        CreateTableAsync<Game>().Wait();
        CreateTableAsync<GameSection>().Wait();
        CreateTableAsync<SectionItem>().Wait();
    }
}

public class DatabaseManager
{
    static DatabaseContext database;

    public static DatabaseContext Current
    {
        get
        {
            if (database == null)
            {
                // Путь к файлу базы данных внутри локального хранилища приложения
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydatabase.db3");
                database = new DatabaseContext(databasePath);
            }
            return database;
        }
    }
}
