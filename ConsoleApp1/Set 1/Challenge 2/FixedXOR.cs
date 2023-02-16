namespace ConsoleApp1.Set_1.Challenge_2;

public static class FixedXor
{
    public static string Xor(string hex1, string hex2)
    {
        //q: explain this code to me in a way that I can understand it
        
        var bytes1 = Enumerable.Range(0, hex1.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(hex1.Substring(x, 2), 16))
            .ToArray();

        var bytes2 = Enumerable.Range(0, hex2.Length)
            .Where(x => x % 2 == 0)
            .Select(x => Convert.ToByte(hex2.Substring(x, 2), 16))
            .ToArray();

        var result = new byte[bytes1.Length];

        for (var i = 0; i < bytes1.Length; i++)
        {
            result[i] = (byte)(bytes1[i] ^ bytes2[i]);
        }
        return BitConverter.ToString(result).Replace("-", string.Empty);
    }
}