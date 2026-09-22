// See https://aka.ms/new-console-template for more information

Console.Write("Enter org filename:");
string orgFilePath = Console.ReadLine();
Console.Write("Enter pattern filename:");
string patternFilePath = Console.ReadLine();
Console.Write("Enter Number of faults:");
int faultThreshold = int.Parse(Console.ReadLine());

// string orgFilePath = "Org.txt";
// string patternFilePath = "p2.txt";

// var orgFile = File.ReadAllLines($"../../../{orgFilePath}")
//     .Select(x => 
//         x.Trim().Split(" ").Select(Convert.FromHexString)
//             .Select(b => Convert.ToString(b.First(), 2).PadLeft(8, '0'))
//             .ToList()).ToList();
// var orgFile = File.ReadLines($"../../../{orgFilePath}")
//     .Select(x => Convert.ToString(Convert.FromHexString(x.Replace(" ", "")).First(), 2).PadLeft(8, '0')).ToList();

var orgFile = File.ReadLines($"../../../{orgFilePath}")
    .Skip(1)
    .Select(s => 
        string.Concat(Convert.FromHexString(s.Replace(" ", ""))
            .Select(b=> Convert.ToString(b,2).PadLeft(8, '0')))
        ).ToList();

var pattern = File.ReadAllLines($"../../../{patternFilePath}")
    .Skip(1)
    .Select(s=> 
            string.Concat(
                    Convert.FromHexString(s.Replace(" ", "")).Select(b => Convert.ToString(b,2).PadLeft(8,'0'))
                )
        ).ToList();

for (int i = 0; i <= orgFile.Count - pattern.Count; i++)
{
    for (int j = 0; j <= orgFile[i].Length - pattern[0].Length; j++)
    {
        if (orgFile[i][j] == pattern[0][0])
        {
            int fault = 0;
            // bool match = true;
            for (int x = 0; x < pattern.Count; x++)
            {
                // if(i+pattern.Count > orgFile.Count || j+pattern[0].Length > orgFile[i].Length) break;
                for (int y = 0; y < pattern[x].Length; y++)
                {
                    if (orgFile[i + x][j + y] != pattern[x][y])
                    {
                        fault++;
                        // match = false;
                        break;
                    }
                }
                if(fault > faultThreshold) break;
            }
            if(fault <= faultThreshold) Console.Write($"x1:{j}, y1:{i}, x2:{j + pattern[0].Length}, y2:{i + pattern.Count}");
            else Console.WriteLine("No match.");
        }
    }   
}



//Console.ReadKey();