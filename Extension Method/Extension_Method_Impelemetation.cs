namespace Csharp
{
    static class Extension_Method_Impelemetation
    {
         public static int Mirror(this int i)
        {
            var temp=i.ToString().ToCharArray();
            temp.Reverse();

            return int.Parse(new string(temp));
        }

        public static string Mirror2(this string i)
        {
            var temp = Convert.ToInt32(i);
            var str = (temp * 10).ToString();
            return str;
        }
    }

   

}