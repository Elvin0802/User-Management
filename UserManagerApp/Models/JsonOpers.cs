using System.IO;
using System.Text.Json;

namespace UserManagement.Models;

internal static class JsonOpers
{
	public static JsonSerializerOptions op = new JsonSerializerOptions() { WriteIndented = true};
	public static string path = "../../../UserFiles/usersData.json";

    public static List<City> GetCities()
    {
        var data = File.ReadAllText("../../../UserFiles/az.json");

        return JsonSerializer.Deserialize<List<City>>(data);

    }

    public static bool Write(List<User> users)
    {
		try
		{
            File.WriteAllText(path, JsonSerializer.Serialize<List<User>>(users, op));

			return true;
		}
		catch
		{
			return false;
		}
    }

    public static List<User>? Read()
    {
        var data = File.ReadAllText(path);

       return JsonSerializer.Deserialize<List<User>>(data);

    }



}






/*
 public static class JsonOperations
{
	private static string FolderPath { get; } = "..\\..\\..\\Json Database\\";

	public static void WriteToFile<T>(List<T> lst, string fileName)
	{
		var opt = new JsonSerializerSettings { Formatting = Formatting.Indented };

		File.WriteAllText($"{FolderPath}{fileName}", JsonConvert.SerializeObject(lst, opt));
	}
	public static void ReadFromFile<T>(out List<T> lst, string fileName)
	{
		var data = File.ReadAllText($"{FolderPath}{fileName}");

		lst = JsonConvert.DeserializeObject<List<T>>(data);
	}

	public static void ProccessLog(LogData ld)
	{
		var opt = new JsonSerializerSettings { Formatting = Formatting.Indented };

		File.AppendAllText($"{FolderPath}log.json", JsonConvert.SerializeObject(ld, opt));
	}
}
 */