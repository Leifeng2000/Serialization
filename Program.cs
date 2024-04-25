internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Nguyen van Tu";
        StoreLink(name);
        Console.WriteLine(ReadString());
    }
    static void StoreLink(string linkvalue)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/"+ "Link.txt";
        FileStream fs = new FileStream(path, FileMode.Create);
        StreamWriter streamWriter = new StreamWriter(fs,System.Text.Encoding.UTF8);
        streamWriter.Write(linkvalue);
        streamWriter.Flush();
        fs.Close();

    }
    static string ReadString()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/"+ "Link.txt";
        FileStream fs = new FileStream(path, FileMode.Open);
        StreamReader streamReader = new StreamReader(fs,System.Text.Encoding.UTF8);
        string giatri = streamReader.ReadToEnd();
        streamReader.Close();
        return giatri;
    }
}