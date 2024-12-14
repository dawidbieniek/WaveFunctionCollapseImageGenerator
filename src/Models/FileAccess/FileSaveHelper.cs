namespace WaveFunctionCollapseImageGenerator.Models.FileAccess;

public static class FileSaveHelper
{
    public static string GetSafeFileSavePath(string filePath, string fileExtension = "")
    {
        if (!File.Exists($"{filePath}{fileExtension}"))
            return $"{filePath}{fileExtension}";

        int count = 1;
        while (File.Exists($"{filePath}{count}{fileExtension}")) count++;

        return $"{filePath}{count}{fileExtension}";
    }
}