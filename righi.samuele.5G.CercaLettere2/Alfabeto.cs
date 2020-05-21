using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        string alfabeto = "abcdefghilmnopqrstuvz";
            foreach (char c in input.ToLower())
            {
                if (alfabeto.Contains(c))
                {
                    alfabeto = alfabeto.Replace(c.ToString(), string.Empty);
                }
            }

            return alfabeto.Length == 0;
    }
}
