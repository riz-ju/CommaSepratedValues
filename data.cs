namespace CSV
{
    public class data
    {
        public static dynamic prrr()
        {
            string st = File.ReadAllText("sample.csv");
            // Console.WriteLine(st);
            return st;
            /*FileStream F = new FileStream("sample.csv", FileMode.OpenOrCreate);//, FileAccess.ReadWrite);
            StreamReader Reader = new StreamReader(F);
            dynamic str = Reader.ReadToEnd();
            return str;*/
        }
    }
}
