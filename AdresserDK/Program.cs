using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json; // for JsonConvert.DeserializeObject

namespace AdresserDK
{

    class Program
    {
        static async Task Main(string[] args)
        {
            // Definer vejnavnet
            string _vejnavn = "";

            Console.WriteLine("Find adresser");
            Console.WriteLine("-------------");
            while (true)
            {
                Console.WriteLine("Indtast adresse eller postnummer(eller del af - brug *)");
                _vejnavn = Console.ReadLine();
                if (_vejnavn == "")
                {
                    break;
                }

                // Opret en HttpClient
                using var client = new HttpClient();

                try
                {
                    // Foretag HTTP GET-anmodningen til API'en med det specificerede vejnavn
                    string url = $"https://api.dataforsyningen.dk/vejnavnpostnummerrelationer?q={_vejnavn}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Sørg for, at anmodningen var vellykket
                    response.EnsureSuccessStatusCode();

                    // Læs svaret som en streng
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON response into list of VejnavnPostnummerRelation objects
                    List<VejnavnPostnummerRelation> relations = JsonConvert.DeserializeObject<List<VejnavnPostnummerRelation>>(responseBody);

                    // Loop through the list of relations and access data
                    foreach (var relation in relations)
                    {
                        // Access and print data from each relation
                        Console.Write($"{relation.betegnelse} ");
                        //Console.WriteLine($"Href: {relation.href}");
                        //Console.WriteLine($"Vejnavn: {relation.vejnavn}");
                        //Console.WriteLine($"Postnummer Href: {relation.postnummer.href}");
                        //Console.WriteLine($"Postnummer Nr: {relation.postnummer.nr}");
                        //Console.WriteLine($"Postnummer Navn: {relation.postnummer.navn}");
                        //Console.WriteLine($"Bbox: [{string.Join(", ", relation.bbox)}]");
                        //Console.WriteLine($"Visueltcenter: [{string.Join(", ", relation.visueltcenter)}]");

                        // Loop through and print each kommuner
                        foreach (var kommune in relation.kommuner)
                        {
                            //Console.WriteLine($"Kommune Href: {kommune.href}");
                            //Console.WriteLine($"Kommune Kode: {kommune.kode}");
                            Console.Write($"({kommune.navn})");
                        }

                        Console.WriteLine(); // Empty line for separation
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"HTTP-anmodning mislykkedes: {e.Message}");
                }
                Console.WriteLine(); // Empty line for separation
            }
        }

    }

}


