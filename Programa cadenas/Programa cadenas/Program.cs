// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Leer el contenido de cuento.txt donde esta proporciona textos
        string cuento = File.ReadAllText("cuento.txt");
        string resultados = "";

        // 1. string.Concat()
        string concatResult = string.Concat("Bitín ", "con la palabra ", "Explorador");
        Console.WriteLine("1. " + concatResult);
        resultados += "1. Concat: " + concatResult + "\n";

        // 2. string.Join()
        string[] oraciones = cuento.Split('.'); // Separa por puntos
        string joinResult = string.Join(" | ", oraciones);
        Console.WriteLine("2. " + joinResult);
        resultados += "2. Join: " + joinResult + "\n";

        // 3. string.Format()
        int caracteres = cuento.Length;
        int palabras = cuento.Split(new[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
        string formatResult = string.Format("El cuento tiene {0} caracteres y {1} palabras", caracteres, palabras);
        Console.WriteLine("3. " + formatResult);
        resultados += "3. Format: " + formatResult + "\n";

        // 4. Interpolación ($"")
        string interpResult = $"El protagonista es Bitín y busca explorar mundos";
        Console.WriteLine("4. " + interpResult);
        resultados += "4. Interpolación: " + interpResult + "\n";

        // 5. Convert.ToString()
        string toStringResult = Convert.ToString(cuento.Length) + " caracteres";
        Console.WriteLine("5. " + toStringResult);
        resultados += "5. ToString: " + toStringResult + "\n";

        // 6. IndexOf()
        int indexMundo = cuento.IndexOf("mundo");
        Console.WriteLine("6. " + (indexMundo >= 0 ? indexMundo.ToString() : "No encontrado"));
        resultados += "6. IndexOf mundo: " + (indexMundo >= 0 ? indexMundo.ToString() : "No encontrado") + "\n";

        // 7. LastIndexOf()
        int lastCeros = cuento.LastIndexOf("ceros");
        Console.WriteLine("7. " + (lastCeros >= 0 ? lastCeros.ToString() : "No encontrado"));
        resultados += "7. LastIndexOf ceros: " + (lastCeros >= 0 ? lastCeros.ToString() : "No encontrado") + "\n";

        // 8. Contains()
        bool containsNube = cuento.Contains("Nube");
        Console.WriteLine("8. " + (containsNube ? "Sí" : "No"));
        resultados += "8. Contains Nube: " + (containsNube ? "Sí" : "No") + "\n";

        // 9. StartsWith()
        bool starts = cuento.StartsWith("En el vasto universo");
        Console.WriteLine("9. " + (starts ? "Sí" : "No"));
        resultados += "9. StartsWith: " + (starts ? "Sí" : "No") + "\n";

        // 10. EndsWith()
        bool ends = cuento.EndsWith("ceros y unos");
        Console.WriteLine("10. " + (ends ? "Sí" : "No"));
        resultados += "10. EndsWith: " + (ends ? "Sí" : "No") + "\n";

        // 11. Substring()
        int startCiudades = cuento.IndexOf("ciudades luminosas");
        string sub = startCiudades >= 0 ? cuento.Substring(startCiudades, "ciudades luminosas".Length) : "No encontrado";
        Console.WriteLine("11. " + sub);
        resultados += "11. Substring: " + sub + "\n";

        // 12. Remove()
        string remove = cuento.Remove(0, 15); // Elimina primeros 15 chars
        Console.WriteLine("12. " + remove);
        resultados += "12. Remove: " + remove + "\n";

        // 13. Replace()
        string replace = cuento.Replace("Bitín", "ProgramaX");
        Console.WriteLine("13. " + replace);
        resultados += "13. Replace: " + replace + "\n";

        // 14. Insert()
        int firewallIdx = cuento.IndexOf("firewall");
        string insert = firewallIdx >= 0 ? cuento.Insert(firewallIdx + "firewall".Length, " (IMPORTANTE)") : cuento;
        Console.WriteLine("14. " + insert);
        resultados += "14. Insert: " + insert + "\n";

        // 15. PadLeft()
        string padLeft = "Bitín".PadLeft(10, '*');
        Console.WriteLine("15. " + padLeft);
        resultados += "15. PadLeft: " + padLeft + "\n";

        // 16. PadRight()
        string padRight = "Nube".PadRight(12, '-');
        Console.WriteLine("16. " + padRight);
        resultados += "16. PadRight: " + padRight + "\n";

        // 17. Trim()
        string trim = " ( firewall ) ".Trim();
        Console.WriteLine("17. " + trim);
        resultados += "17. Trim: " + trim + "\n";

        // 18. TrimStart()
        string trimStart = "  Mundo binario".TrimStart();
        Console.WriteLine("18. " + trimStart);
        resultados += "18. TrimStart: " + trimStart + "\n";

        // 19. TrimEnd()
        string trimEnd = "Bitín explorador  ".TrimEnd();
        Console.WriteLine("19. " + trimEnd);
        resultados += "19. TrimEnd: " + trimEnd + "\n";

        // 20. Split()
        string[] palabrasArray = cuento.Split(new[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string splitResult = string.Join(", ", palabrasArray.Take(10));
        Console.WriteLine("20. Split: " + splitResult);
        resultados += "20. Split() - Primeras 10 palabras: " + splitResult + "\n";

        // 21. Equals()
        bool equals = "Nube".Equals("nube", StringComparison.OrdinalIgnoreCase); // Ignora mayús/minús
        Console.WriteLine("21. " + (equals ? "Iguales" : "Diferentes"));
        resultados += "21. Equals: " + (equals ? "Iguales" : "Diferentes") + "\n";

        // 22. Compare()
        int compare = string.Compare("Bitín", "Firewall", StringComparison.Ordinal);
        Console.WriteLine("22. " + compare);
        resultados += "22. Compare: " + compare + "\n";

        // 23. CompareTo()
        int compareTo = "Nube".CompareTo("Cielo");
        Console.WriteLine("23. " + compareTo);
        resultados += "23. CompareTo: " + compareTo + "\n";

        // 24. IsNullOrEmpty()
        bool isEmpty = string.IsNullOrEmpty("");
        Console.WriteLine("24. " + isEmpty);
        resultados += "24. IsNullOrEmpty: " + isEmpty + "\n";

        // 25. IsNullOrWhiteSpace()
        bool isWhite = string.IsNullOrWhiteSpace("   ");
        Console.WriteLine("25. " + isWhite);
        resultados += "25. IsNullOrWhiteSpace: " + isWhite + "\n";

        // 26. ToLower()
        string lower = cuento.ToLower();
        Console.WriteLine("26. " + lower);
        resultados += "26. ToLower: " + lower + "\n";

        // 27. ToUpper()
        string upper = cuento.ToUpper();
        Console.WriteLine("27. " + upper);
        resultados += "27. ToUpper: " + upper + "\n";

        // 28. ToLowerInvariant()
        string lowerInv = "NUBE".ToLowerInvariant();
        Console.WriteLine("28. " + lowerInv);
        resultados += "28. ToLowerInvariant: " + lowerInv + "\n";

        // 29. ToUpperInvariant()
        string upperInv = "bitín".ToUpperInvariant();
        Console.WriteLine("29. " + upperInv);
        resultados += "29. ToUpperInvariant: " + upperInv + "\n";

        // Crea y guardar los resultados en de la copilacion en resultados.txt
        File.WriteAllText("resultados.txt", resultados);
        Console.WriteLine("Resultados guardados en resultados.txt");
        Console.ReadKey(); // Para que no se cierre la consola 
    }
}
