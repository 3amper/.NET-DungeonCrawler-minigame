// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

ConsoleKeyInfo inputKey;
string convertedInput = "a";
string inputType = "Key";
int charX = 1;
int charY = 2;
int visionLength = 4;
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
        if (inputType == "Key")
        {
            inputType = "Text";
            convertedInput = Console.ReadLine();
            switch (convertedInput)
            {
                case "render":
                    Console.WriteLine("Render distance:");
                    visionLength = int.Parse(Console.ReadLine());
                    break;

                
            }


            
        }

        break;

    

    default:

        break;
}
inputType = "Key";

Draw();
goto A;


void Draw()
    {
    Console.Clear();
        for (int i = -visionLength; i < visionLength; i++)
        {
            for (int j = -visionLength; j < visionLength; j++)
            {
                if(i==0 && j == 0)
                {
                    Console.Write("JL");
                }
                else if(charY + i > -1 && charX + j > -1 && charY + i < LengthY && charX + j < LengthX)
                { 
                    Console.Write(map[charY+i, charX+j]);
                }
            
            }
            Console.WriteLine();
        }
    //Console.WriteLine(convertedInput);

}

