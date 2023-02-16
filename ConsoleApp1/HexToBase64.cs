namespace ConsoleApp1;

public static class HexToBase64
{
    public static string ConvertToHex(string hex)
    {
        var bytes = Enumerable.Range(0, hex.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
            .ToArray();

        return Convert.ToBase64String(bytes);
    }
}