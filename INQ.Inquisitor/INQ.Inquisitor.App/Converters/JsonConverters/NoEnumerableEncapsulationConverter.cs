using Newtonsoft.Json;

namespace INQ.Inquisitor.App.Converters.JsonConverters;

public class NoEnumerableEncapsulationConverter : JsonConverter<IEnumerable<object>>
{
    public override void WriteJson(JsonWriter writer, IEnumerable<object>? values, JsonSerializer serializer)
    {
        var originalItemList = values?.ToList() ?? new List<object>();
        string finalString = "";

        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };

        foreach (var value in originalItemList)
        {
            var itemJson = JsonConvert.SerializeObject(value, settings);
            itemJson = itemJson.TrimStart('{');
            itemJson = itemJson.TrimEnd('}');
            finalString = finalString == "" 
                ? itemJson 
                : finalString + Environment.NewLine + itemJson;
        }

        writer.WriteRawValue(finalString);
    }

    public override IEnumerable<object> ReadJson(JsonReader reader, Type objectType, IEnumerable<object> existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanRead => false;
}


