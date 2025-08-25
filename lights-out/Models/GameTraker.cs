using System.Text.Json;
using System.IO;

public class GameTrak
{
    private const string FilePath = "GameHistory.json";
    private List<GameRecord> _records;
    public GameTrak()
    {
        _records = new List<GameRecord>();
        LoadHistory();
    }

    public void AddRecord(GameRecord record)
    {
        _records.Add(record);
        SaveHistory();
    }

    public List<GameRecord> GetAllRecords()
    {
        return new List<GameRecord>(_records);
    }

    private void SaveHistory()
    {
        var json = JsonSerializer.Serialize(_records, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    private void LoadHistory()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            Console.WriteLine(json);
            _records = JsonSerializer.Deserialize<List<GameRecord>>(json) ?? new List<GameRecord>();
        }
        else
        {
            _records = new List<GameRecord>();
        }
    }
}