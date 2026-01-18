using System.Text.Json;

public static class JsonReader
{
    public static T Read<T>(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"This JSON file doesn't exist: {filePath}");

        string json = File.ReadAllText(filePath);

        return JsonSerializer.Deserialize<T>(json)
                ?? throw new JsonException("Couldn't deserialize this JSON.");
    }
}