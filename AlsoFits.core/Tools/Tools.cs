using System.Text;

namespace AlsoFits.core.Tools
{
    public static class Tools
    {
        public static string PropertyList(this object obj)
        {
            var props = obj.GetType().GetProperties();
            var sb = new StringBuilder();
            foreach (var p in props)
            {
                sb.AppendLine(p.Name + ": " + p.GetValue(obj, null));
            }
            return sb.ToString();
        }
    }
}           