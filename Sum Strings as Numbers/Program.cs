using System.Numerics;

public static class Kata
{
    public static void Main()
    {
        // Test
        var t = sumStrings("432341231", "567658768");
        // ...should return "999999999"
    }

    public static string sumStrings(string a, string b)
    {
        if (a == "") 
            a = "0";

        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}