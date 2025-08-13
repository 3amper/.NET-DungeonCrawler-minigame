

using System.Diagnostics.Metrics;
Console.Title = "ver 1.1";
Console.WriteLine("Hello, World!");

ConsoleKeyInfo inputKey;
string convertedInput = "a";
bool cheats = true;
int charX = 1;
int charY = 2;
int visionLength = 5;
string[,] map = { { "##", "##", "##", "##", "##", "##", "##", "##", "##", "##", "##", "##", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "##", "##", "##", "##", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "##", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "##", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "##", "##", "##", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "##" },
                  { "##", "##", "##", "##", "##", "##", "##", "##", "##", "##", "##", "##", "##"} };
int LengthY = map.GetLength(0);
int LengthX = map.GetLength(1);

Draw();

A:


    inputKey = Console.ReadKey();
    convertedInput = inputKey.Key.ToString();


switch (convertedInput)
{
    case "A":
        charX--;
        if (map[charY, charX] == "##")
        {
            charX++;
        }
        break;

    case "D":
        charX++;
        if (map[charY, charX] == "##")
        {
            charX--;
        }
        break;

    case "W":
        charY--;
        if (map[charY, charX] == "##")
        {
            charY++;
        }
        break;

    case "S":
        charY++;
        if (map[charY, charX] == "##")
        {
            charY--;
        }
        break;

    case "Delete":
        
        
            
            convertedInput = Console.ReadLine();
            switch (convertedInput)
            {
                case "render":
                    Console.WriteLine("Render distance:");
                    visionLength = int.Parse(Console.ReadLine());
                    break;

                case "tp":
                    if(cheats)
                    {
                    Console.WriteLine("X coordinate:");
                    charX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Y coordinate:");
                    charY = int.Parse(Console.ReadLine());
                }

                break;
            }


        break;

    

    default:

        break;
}


Draw();
goto A;


void Draw()
    {
    Console.Clear();

    Console.Write("╔");
    for(int k = -visionLength * 2; k < visionLength * 2 + 2; k++)
    {
        Console.Write("═");
    }
    Console.WriteLine("╗");

        for (int i = -visionLength; i < visionLength+1; i++)
        {
        Console.Write("║");
            for (int j = -visionLength; j < visionLength+1; j++)
            {
                if(i==0 && j == 0)
                {
                    Console.Write("JL");
                }
                else if(charY + i > -1 && charX + j > -1 && charY + i < LengthY && charX + j < LengthX)
                { 
                    Console.Write(map[charY+i, charX+j]);
            }
                else
                {
                Console.Write("  ");
            }
            
            }
            Console.WriteLine("║");
        }

    Console.Write("╚");
    for (int k = -visionLength * 2; k < visionLength * 2 + 2; k++)
    {
        Console.Write("═");
    }
    Console.WriteLine("╝");

    //Console.WriteLine(convertedInput);

}

