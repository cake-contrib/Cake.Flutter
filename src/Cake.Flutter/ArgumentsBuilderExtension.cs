using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Cake.Flutter
{
    /// <summary>
    /// Arguments builder
    /// </summary>
    /// <summary>
    /// Arguments builder
    /// </summary>
    public static class ArgumentsBuilderExtension
    {
        /// <summary>
        /// Appends all arguments from <paramref name="settings"/> .
        /// </summary>
        /// <typeparam name="TSettings"></typeparam>
        /// <param name="cakeEnvironment"></param>
        /// <param name="builder"></param>
        /// <param name="command"></param>
        /// <param name="settings">The settings.</param>
        public static void AppendAll<TSettings>(this ProcessArgumentBuilder builder, ICakeEnvironment cakeEnvironment, string command, TSettings settings)
            where TSettings : AutoToolSettings, new()
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder");
            }
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command");
            }
            if (settings == null)
            {
                settings = new TSettings();
            }
            AppendArguments(cakeEnvironment, builder, settings, preCommand: true);
            builder.Append(command);
            AppendArguments(cakeEnvironment, builder, settings, preCommand: false);
        }
        /// <summary>
        /// Appends pre or post command arguments.
        /// </summary>
        /// <typeparam name="TSettings"></typeparam>
        /// <param name="cakeEnvironment"></param>
        /// <param name="builder"></param>
        /// <param name="settings"></param>
        /// <param name="preCommand"></param>
        public static void AppendArguments<TSettings>(ICakeEnvironment cakeEnvironment, ProcessArgumentBuilder builder, TSettings settings, bool preCommand)
            where TSettings : AutoToolSettings, new()
        {
            foreach (var property in typeof(TSettings).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.DeclaringType != typeof(ToolSettings))
                {
                    foreach (string argument in GetArgumentFromProperty(cakeEnvironment, property, settings, preCommand: preCommand))
                    {
                        if (!string.IsNullOrEmpty(argument))
                        {
                            builder.Append(argument);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets and processes <paramref name="property"/> value from <paramref name="settings"/>.
        /// </summary>
        /// <typeparam name="TSettings"></typeparam>
        /// <param name="cakeEnvironment"></param>
        /// <param name="property"></param>
        /// <param name="settings">The settings.</param>
        /// <param name="preCommand">Pre or post command.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetArgumentFromProperty<TSettings>(
            ICakeEnvironment cakeEnvironment, PropertyInfo property, TSettings settings, bool preCommand)
            where TSettings : AutoToolSettings, new()
        {
            var autoPropertyAttribute = GetAutoPropertyAttributeOrNull(property);
            if (autoPropertyAttribute?.Format != null)
            {
                if (autoPropertyAttribute.PreCommand == preCommand)
                {
                    yield return GetArgumentFromAutoProperty(autoPropertyAttribute, property, property.GetValue(settings));
                }
            }
            else if (!preCommand || (autoPropertyAttribute != null && autoPropertyAttribute.PreCommand && preCommand))
            {
                if (property.PropertyType == typeof(bool))
                {
                    yield return GetArgumentFromBoolProperty(property, (bool)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(bool?))
                {
                    yield return GetArgumentFromNullableBoolProperty(property, (bool?)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(int?))
                {
                    yield return GetArgumentFromNullableIntProperty(property, (int?)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(Int64?))
                {
                    yield return GetArgumentFromNullableInt64Property(property, (Int64?)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(UInt64?))
                {
                    yield return GetArgumentFromNullableUInt64Property(property, (UInt64?)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(UInt16?))
                {
                    yield return GetArgumentFromNullableUInt16Property(property, (UInt16?)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(string))
                {
                    yield return GetArgumentFromStringProperty(property, (string)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(FilePath))
                {
                    yield return GetArgumentFromFilePathProperty(cakeEnvironment, property, (FilePath)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(DirectoryPath))
                {
                    yield return GetArgumentFromDirectoryPathProperty(cakeEnvironment, property, (DirectoryPath)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(TimeSpan?))
                {
                    yield return GetArgumentFromNullableTimeSpanProperty(property, (TimeSpan?)property.GetValue(settings));
                }
                else if (property.PropertyType == typeof(string[]))
                {
                    foreach (string arg in GetArgumentFromStringArrayProperty(property, (string[])property.GetValue(settings)))
                    {
                        yield return arg;
                    }
                }
                else
                {
                    var enumType = Nullable.GetUnderlyingType(property.PropertyType);
                    if (enumType != null)
                    {
                        yield return GetArgumentFromEnumProperty(property, property.GetValue(settings));
                    }
                }
            }
        }
        internal static string GetArgumentFromEnumProperty(PropertyInfo property, object value)
        {
            string text = GetArgumentForEnumValue(value);
            return !string.IsNullOrEmpty(text) ? $"--{GetPropertyName(property.Name)}={text}": null;
        }
        internal static string GetArgumentForEnumValue(object value)
        {
            if (ReferenceEquals(value, null))
            {
                return null;
            }
            string text = Convert.ToString(value);
            string result = text.Substring(0, 1).ToLower();
            foreach (char c in text.Substring(1))
            {
                if (char.IsUpper(c))
                {
                    result += $"-{char.ToLower(c)}";
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
        /// <summary>
        /// Uses format specified in attribute to format the argument.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromAutoProperty(AutoPropertyAttribute attribute, PropertyInfo property, object value)
        {
            if (value == null)
            {
                return null;
            }

            string result = string.Format(attribute.Format, GetPropertyName(property.Name), value);
            if (attribute.OnlyWhenTrue)
            {
                bool boolvalue = (bool)value;
                return boolvalue ? result : string.Empty;
            }
            else
            {
                if (property.PropertyType == typeof(string[]))
                {
                    var strings = (string[])value;
                    result = string.Join(" ", strings.Select(s => string.Format(attribute.Format, GetPropertyName(property.Name), s)));
                }
            }
            return result;
        }
        /// <summary>
        /// Retrieve <see cref="AutoPropertyAttribute"/> from property or null if there isn't one.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static AutoPropertyAttribute GetAutoPropertyAttributeOrNull(PropertyInfo property)
        {
            return property.GetCustomAttribute<AutoPropertyAttribute>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromBoolProperty(PropertyInfo property, bool value)
        {
            return value ? $"--{GetPropertyName(property.Name)}" : $"--no-{GetPropertyName(property.Name)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromNullableIntProperty(PropertyInfo property, int? value)
        {
            return value.HasValue ? $"--{GetPropertyName(property.Name)}={value.Value}" : null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromNullableInt64Property(PropertyInfo property, Int64? value)
        {
            return value.HasValue ? $"--{GetPropertyName(property.Name)}={value.Value}" : null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromNullableUInt64Property(PropertyInfo property, UInt64? value)
        {
            return value.HasValue ? $"--{GetPropertyName(property.Name)}={value.Value}" : null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromNullableUInt16Property(PropertyInfo property, UInt16? value)
        {
            return value.HasValue ? $"--{GetPropertyName(property.Name)}={value.Value}" : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromNullableBoolProperty(PropertyInfo property, bool? value)
        {
            if (value.HasValue)
            {
                return GetArgumentFromBoolProperty(property, value.Value);
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetArgumentFromDictionaryProperty(PropertyInfo property, Dictionary<string, string> values)
        {
            if (values != null)
            {
                foreach (var kp in values)
                {
                    yield return GetArgumentFromStringProperty(property, $"{kp.Key}={kp.Value}");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetArgumentFromStringArrayProperty(PropertyInfo property, string[] values)
        {
            if (values != null)
            {
                foreach (string value in values)
                {
                    yield return GetArgumentFromStringProperty(property, value);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromStringProperty(PropertyInfo property, string value)
        {
            return !string.IsNullOrEmpty(value) ? $"--{GetPropertyName(property.Name)}=\"{value}\"" : null;
        }
        internal static string GetArgumentFromFilePathProperty(ICakeEnvironment cakeEnvironment, PropertyInfo property, FilePath value)
        {
            return value != null ? $"--{GetPropertyName(property.Name)}=\"{value.MakeAbsolute(cakeEnvironment).FullPath}\"" : null;
        }
        internal static string GetArgumentFromDirectoryPathProperty(ICakeEnvironment cakeEnvironment, PropertyInfo property, DirectoryPath value)
        {
            return value != null ? $"--{GetPropertyName(property.Name)}=\"{value.MakeAbsolute(cakeEnvironment).FullPath}\"" : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetArgumentFromNullableTimeSpanProperty(PropertyInfo property, TimeSpan? value)
        {
            return value.HasValue ? $"--{GetPropertyName(property.Name)} {ConvertTimeSpan(value.Value)}" : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ConvertTimeSpan(TimeSpan source)
        {
            return $"{Math.Floor(source.TotalHours)}h{source.Minutes}m{source.Seconds}s";
        }

        /// <summary>
        /// Converts property name to appcenter arguments format
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <example>NoForce -> no-force</example>
        public static string GetPropertyName(string name)
        {
            string result = null;
            if (!string.IsNullOrEmpty(name))
            {
                result = name.Substring(0, 1).ToLower();
                if (name.Length > 1)
                {
                    foreach (char c in name.Substring(1))
                    {
                        if (char.IsUpper(c))
                        {
                            result += "-" + char.ToLower(c);
                        }
                        else
                        {
                            result += c;
                        }
                    }
                }
            }
            return result;
        }
    }
}
