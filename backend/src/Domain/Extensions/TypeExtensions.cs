using Ardalis.GuardClauses;
using System;
using System.Reflection;

namespace Pibidex.Domain.Extensions
{
    public static class TypeExtensions
    {
        private const BindingFlags _defaultBindingAttr = (BindingFlags)28;

        public static object? GetPropertyValue(this Type type, string name, object? obj = null, BindingFlags bindingAttr = _defaultBindingAttr)
        {
            return GetPropertyValue<object?>(type, name, obj, bindingAttr);
        }

        public static TValue GetPropertyValue<TValue>(this Type type, string name, object? obj = null, BindingFlags bindingAttr = _defaultBindingAttr)
        {
            Guard.Against.NullOrWhiteSpace(name, nameof(name));

            var property = type.GetProperty(name, bindingAttr);
            Guard.Against.Null(property, nameof(property));

            return (TValue)property.GetValue(obj)!;
        }

        public static object? GetFieldValue(this Type type, string name, object? obj = null, BindingFlags bindingAttr = _defaultBindingAttr)
        {
            return GetPropertyValue<object?>(type, name, obj, bindingAttr);
        }

        public static TValue GetFieldValue<TValue>(this Type type, string name, object? obj = null, BindingFlags bindingAttr = _defaultBindingAttr)
        {
            Guard.Against.NullOrWhiteSpace(name, nameof(name));

            var field = type.GetField(name, bindingAttr);
            Guard.Against.Null(field, nameof(field));

            return (TValue)field.GetValue(obj)!;
        }
    }
}