namespace shop.Models
{
    public static  class Extensions
    {
        public static bool Empty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool NotEmpty(this string value)
        {
            return !value.Empty();
        }
    }
}