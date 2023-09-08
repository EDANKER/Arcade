using System.Data;
using System.Threading.Tasks;
using UnityEngine;
// using Mono.Data.Sqlite;
using System.Data;
public class SaveGame : MonoBehaviour
{
    // private SqliteConnection _SqLiteConnection;
    // private string path;
    // private int money;
    //
    // public async Task<string> SaveGameOver()
    // {
    //     var buttonClick = new BattonClick();
    //     buttonClick.num = money;
    //     
    //     path = "/Save/saveGame.bytes";
    //     const string command = "INSERT INTO saveGame(id, money) VALUES(@Id, @Money)";
    //     _SqLiteConnection = new SqliteConnection($"Data Source={path}");
    //     await _SqLiteConnection.OpenAsync();
    //     SqliteCommand sqliteCommand = new SqliteCommand(command,_SqLiteConnection);
    //     sqliteCommand.Parameters.Add("@Id", DbType.Int32).Value = 1;
    //     sqliteCommand.Parameters.Add("@Money", DbType.Int32).Value = money;
    //     sqliteCommand.ExecuteNonQuery();
    //     await _SqLiteConnection.CloseAsync();
    //     return "Good";
    // }
    //
    // public async Task<string> Create()
    // {
    //     path = "/Save/saveGame.bytes";
    //     var command = "INSERT INTO saveGame(id, money) VALUES(id = 0, money = 0)";
    //     _SqLiteConnection = new SqliteConnection("URL-File" + path);
    //     await _SqLiteConnection.OpenAsync();
    //     SqliteCommand sqliteCommand = new SqliteCommand(command, _SqLiteConnection);
    //     await sqliteCommand.ExecuteNonQueryAsync();
    //     return "Good";
    // }
}