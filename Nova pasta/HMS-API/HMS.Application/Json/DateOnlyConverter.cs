using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HMS.Application.Json
{
    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            DateTime result;
            if (DateTime.TryParseExact(reader.GetString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                DateOnly dateOnly = DateOnly.FromDateTime(result);
                return dateOnly;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                DateOnly dateOnly = DateOnly.FromDateTime(result);
                return dateOnly;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                DateOnly dateOnly = DateOnly.FromDateTime(result);
                return dateOnly;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                DateOnly dateOnly = DateOnly.FromDateTime(result);
                return dateOnly;
            }
            else if (DateTime.TryParseExact(reader.GetString(), "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                DateOnly dateOnly = DateOnly.FromDateTime(result);
                return dateOnly;
            }

            throw new JsonException("Invalid date format.");
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
        }
    }


}
