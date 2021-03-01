using System;
using System.Linq;
using System.Reflection;

namespace HttpApiUploadPlugin
{
  internal static class EnumExtensions
  {
    public static string GetDescription(this Enum value)
    {
      Type enumType = value.GetType();

      MemberInfo[] memberInfo = enumType.GetMember(value.ToString());

      if (memberInfo.Length > 0)
      {
        object[] attributes = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

        if ((attributes.Length > 0))
        {
          return ((System.ComponentModel.DescriptionAttribute) attributes.ElementAt(0)).Description;
        }
      }

      return value.ToString();
    }
  }
}