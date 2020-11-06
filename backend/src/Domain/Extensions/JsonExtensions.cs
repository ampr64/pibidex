using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Pibidex.Domain.Extensions
{
    public static class JsonExtensions
    {
        private static readonly JsonSerializerOptions _defaultOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static string ToJson(this object obj, JsonSerializerOptions? options = null) =>
            JsonSerializer.Serialize(obj, options ?? _defaultOptions);

        public static T FromJson<T>(this string json, JsonSerializerOptions? options = null) =>
            JsonSerializer.Deserialize<T>(json, options ?? _defaultOptions);

        public static bool TryDeserialize<T>(this string json, [MaybeNull] out T result, JsonSerializerOptions? options = null)
        {
            try
            {
                result = json.FromJson<T>(options);
                return true;
            }
            catch
            {
                result = default!;
                return false;
            }
        }
    }
}