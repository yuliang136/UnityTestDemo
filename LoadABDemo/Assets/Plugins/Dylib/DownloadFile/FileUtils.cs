using System.IO;

public class FileUtils {

    public static bool IsExisitFile(string path)
    {
        return File.Exists(path);
    }

    public static string ReadFile(string path)
    {
        return System.IO.File.ReadAllText(@path);
    }

    public static FileStream CreateFile(string filePath, FileMode mode = FileMode.Create)
    {
        string floderPath = filePath.Substring(0, filePath.LastIndexOf("/"));

        if (!Directory.Exists(floderPath))   //如果不存在就创建file文件夹
        {
            Directory.CreateDirectory(floderPath);
        }
        
        if(!IsExisitFile(filePath))
        {
            mode = FileMode.Create;
        }

        FileStream f = new FileStream(filePath, mode);
        return f;
    }

    public static void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}
