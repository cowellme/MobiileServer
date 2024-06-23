namespace MobileServer.DataBase
{
    public class Db
    {
        public static void SaveToDataBase(string code)
        {
            var path = Environment.CurrentDirectory + @"/codes.tmp";

            File.AppendAllText(path, code + Environment.NewLine);
        }
    }
}
