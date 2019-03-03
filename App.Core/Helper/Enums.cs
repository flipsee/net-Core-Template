using System;
using System.ComponentModel;
using System.Reflection;

namespace App.Core
{
    public static class Enums
    {
        public static string DescriptionAttr<T>(this T source)
        {
            try
            {
                FieldInfo fi = source.GetType().GetField(source.ToString());

                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
                else
                    return source.ToString();
            }
            catch 
            {
                return source.ToString();
            }            
        }

        public static T GetEnum<T>(string value) where T : struct, IConvertible
        {
            try
            {
                if (!typeof(T).IsEnum)
                    throw new ArgumentException("T must be an enumerated type");

                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch
            {
                try
                {
                    foreach (FieldInfo fi in typeof(T).GetFields())
                    {
                        DescriptionAttribute[] attribute = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                        if(attribute.Length > 0 && attribute[0].Description == value)
                        {
                            return (T)fi.GetValue(null);
                        }
                    }
                } catch { }
            }
            return default(T);
        }
    }

    public enum MessageType
    {
        None,
        Error,
        Warning, 
        Information, 
        Confirmation,        
    }

    public enum ActionType
    {
        None,
        Insert,
        Update,
        Delete,
        Remove,
    }

    public enum Question
    {
        [Description("Here is another")]
        Role = 2,
        ProjectFunding = 3,
        TotalEmployee = 4,
        NumberOfServers = 5,
        TopBusinessConcern = 6
    }
}
