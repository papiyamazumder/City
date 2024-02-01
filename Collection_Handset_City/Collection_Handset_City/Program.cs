internal class Program
{
    private static void Main(string[] args)
    {
        #region using List

        List<string> list = new List<string>();
        list.Add("ROME");
        list.Add("LONDON");
        list.Add("NAIROBI");
        list.Add("CALIFORNIA");
        list.Add("ZURICH");
        list.Add("NEW DELHI");
        list.Add("AMSTERDAM");
        list.Add("ABU DHABI");
        list.Add("PARIS");

        foreach (string place in list.ToList())
        {
            if (place.StartsWith("A") && place.EndsWith("M"))
            {
                Console.WriteLine("The city starting with A and ending with M is: " + place);
            }
        }
        #endregion

        // OR

        #region using Array

        string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        //char startChar = 'A';
        //char endChar = 'M';
        //foreach (string city in cities)
        //{
        //    if (city.StartsWith(startChar) && city.EndsWith(endChar))
        //    {
        //        Console.WriteLine("The city starting with A and ending with M is: " + city);
        //    }
        //}

        // OR

        char startChar = Console.ReadKey().KeyChar;
        char endChar = Console.ReadKey().KeyChar;

        string resultCity = FindCity(cities, startChar, endChar);
        Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is: {resultCity}");
    }


    static string FindCity(string[] cities, char startChar, char endChar)
    {
        foreach (string city in cities)
        {
            if (city.StartsWith(startChar) && city.EndsWith(endChar))
            {
                return city;
            }
        }

        return "No matching city found.";
    }

    #endregion
}