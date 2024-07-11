using Microsoft.Extensions.Primitives;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System;

public class TimeOnlyConverter : JsonConverter<TimeOnly>
{
    public override void WriteJson(JsonWriter writer, TimeOnly value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString(@"hh\:mm\:ss"));
    }

    public override TimeOnly ReadJson(JsonReader reader, Type objectType, TimeOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
            return TimeOnly.MinValue;

        if (reader.TokenType == JsonToken.String)
        {
            if (TimeOnly.TryParseExact((string)reader.Value, @"hh\:mm\:ss", out TimeOnly time))
            {
                return time;
            }
            else if (TimeOnly.TryParseExact((string)reader.Value, @"hh\:mm", out TimeOnly time2))
            {
                return time2;
            }
        }

        throw new JsonSerializationException($"Invalid time format: {reader.Value}");
    }
}
