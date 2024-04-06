using System;

class Program
{
    static void OscilliateY(int fanSpeed)
    {
        int fanInc = fanSpeed;

        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine(new string('~', fanInc));
            fanInc += fanSpeed;
            System.Threading.Thread.Sleep(500);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('~', fanSpeed * 10));
            System.Threading.Thread.Sleep(500);
        }
        fanInc -= fanSpeed;
        for (int i = 9; i >= 1; i--)
        {
            Console.WriteLine(new string('~', fanInc));
            fanInc -= fanSpeed;
            System.Threading.Thread.Sleep(500);
        }
    }

    static void OscilliateN(int fanSpeed)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string('~', fanSpeed * 10));
            System.Threading.Thread.Sleep(500);
        }
    }

    static void Main(string[] args)
    {
        int fanSpeed;
        char oscilliateOpt;

        do
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            fanSpeed = int.Parse(Console.ReadLine());
        } while (fanSpeed < 1 || fanSpeed > 3);

        do
        {
            Console.Write("Oscilliate fan? (Y/N): ");
            oscilliateOpt = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (oscilliateOpt != 'Y' && oscilliateOpt != 'N');

        Console.WriteLine();

        int baseFanPower = 10;
        int fanPowerOutput = baseFanPower * fanSpeed;

        if (oscilliateOpt == 'Y')
        {
            OscilliateY(fanSpeed);
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('~', fanPowerOutput));
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}