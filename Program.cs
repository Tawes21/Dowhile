namespace Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stundenlohn;
            int tageslohn;
            const int multi = 8; // Konstante deffiniert hier

            do
            {
                Console.WriteLine("Bitte geben sie Ihren Stundenlohn ein oder 'Exit' um das Programm zu beenden.\n"); // \n für einen Zeilenumbruch
                stundenlohn = Console.ReadLine();

                if (stundenlohn.ToLower() == "exit") // .ToLower Casesensetivity aufegehoben (Groß und Kleinschreibung)

                {
                    break; // Hausaufgabe nochmal nachzulesen (return und break beenden den programmteil in dem sie stehen, aber return kann noch mehr :D)
                }

                if (int.TryParse(stundenlohn, out int stundenlohnint)) // Out bestimmt die wiedergabe (neue Variable erstellt): int stundenlohnint
                {
                    tageslohn = multi * stundenlohnint;
                    Console.WriteLine($"Ihr Tageslohn beträgt bei 8h Arbeit: {tageslohn} \n"); // $ Zeichen damit man in {} Variablen schreiben kann
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }

            } while (true);

            Console.WriteLine("Programm beendet");

        }
    }
}