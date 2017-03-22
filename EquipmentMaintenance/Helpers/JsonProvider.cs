using Newtonsoft.Json;
using System.Collections.Generic;
using Windows.Storage;

namespace EquipmentMaintenance
{
    public class JsonProvider
    {
        public static List<string> LoadFromJson(string fileName = "chart.json")
        {
            string jsonString = DeserializeFile(fileName);
            if (jsonString != null)
                return JsonConvert.DeserializeObject<List<string>>(jsonString);
            return null;
        }

        private static string DeserializeFile(string fileName)
        {
            var localFile = ApplicationData.Current.LocalFolder.GetFileAsync(fileName).GetResults();
            return FileIO.ReadTextAsync(localFile).GetResults();
        }
    }
}
