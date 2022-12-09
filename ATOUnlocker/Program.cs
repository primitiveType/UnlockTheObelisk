// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace ATOUnlocker;

public static class Program
{
    private static string Path { get; set; }

    public static void Main(string[] args)
    {
        Console.Title = "Unlock The Obelisk";
        Console.ForegroundColor = ConsoleColor.DarkYellow;

      

        if (args.Length == 0)
        {
            Console.WriteLine("No path provided. First argument must be a path, dummy. It should be the full path to the player.ato in localLow.");
            Console.WriteLine("Use 'ATOUnlocker.exe help' if you want to see arguments.");
            return;
        }
        
        if (args[0] == "help")
        {
            Console.WriteLine(
                "First argument must be a path to the player.ato in C:\\Users\\USER_NAME\\AppData\\LocalLow\\Dreamsite Games\\AcrossTheObelisk\\STEAM_ID\\player.ato");
            Console.WriteLine("You must provide further arguments if you want this thing to do anything. Possible Arguments: ");
            Console.WriteLine("perks - max out all perk points.");
            Console.WriteLine("heroes - unlock all heroes.");
            Console.WriteLine("town - unlock all town upgrades.");

            return;
        }


        Path = args[0];

        if (args.Length == 1)
        {
            Console.WriteLine("No unlock arguments provided. Doing nothing.");
        }

        if (!File.Exists(Path))
        {
            Console.WriteLine("Couldn't find the file at path. Make sure the path exists. You should be pointing at the player.ato");
        }

        if (args.Contains("perks"))
        {
            Console.WriteLine("Maxing out all perk points.");
            MaxAllHeroesPerks();
        }

        if (args.Contains("heroes"))
        {
            Console.WriteLine("Unlocking all heroes.");
            AddAllHeroes();
        }

        if (args.Contains("town"))
        {
            Console.WriteLine("Maxing out all town upgrades.");
            UpgradeTown();
        }
    }


    private static void AddAllHeroes()
    {
        PlayerData test;
        test = LoadPlayerData();
        foreach (string subClass in Reference.Heroes.Where(subClass => !test.UnlockedHeroes.Contains(subClass)))
        {
            test.UnlockedHeroes.Add(subClass);
        }


        SavePlayerData(test);
    }


    private static void MaxAllHeroesPerks()
    {
        PlayerData test;

        test = LoadPlayerData();
        test.PlayerRankProgress = 100_000;
        foreach (string subClass in Reference.Heroes.Where(subClass => test.UnlockedHeroes.Contains(subClass)))
        {
            test.HeroProgress[subClass] = 1_000;
        }


        SavePlayerData(test);
    }


    private static void UpgradeTown()
    {
        PlayerData test;

        test = LoadPlayerData();
        test.SupplyBought = new List<string>();

        for (int x = 1; x < 7; x++)
        {
            for (int y = 1; y < 7; y++)
            {
                test.SupplyBought.Add($"townUpgrade_{x}_{y}");
            }
        }

        SavePlayerData(test);
    }

    private static void SavePlayerData(PlayerData playerData)
    {
        DESCryptoServiceProvider cryptoServiceProvider = new();
        using (FileStream fileStream = new(Path, FileMode.Create, FileAccess.Write))
        {
            using (CryptoStream cryptoStream =
                   new(fileStream, cryptoServiceProvider.CreateEncryptor(Cryptography.Key, Cryptography.IV), CryptoStreamMode.Write))
            {
                new BinaryFormatter().Serialize(cryptoStream, playerData);
                cryptoStream.Close();
            }

            fileStream.Close();
        }
    }

    private static PlayerData LoadPlayerData()
    {
        if (File.Exists(Path))
        {
            using (FileStream fileStream = new(Path, FileMode.Open))
            {
                if (fileStream.Length == 0L)
                {
                    fileStream.Close();
                }
                else
                {
                    DESCryptoServiceProvider cryptoServiceProvider = new();
                    PlayerData playerData2;
                    try
                    {
                        CryptoStream cryptoStream = new(fileStream,
                            cryptoServiceProvider.CreateDecryptor(Cryptography.Key, Cryptography.IV), CryptoStreamMode.Read);
                        BinaryFormatter binaryFormatter = new();
                        try
                        {
                            playerData2 = binaryFormatter.Deserialize(cryptoStream) as PlayerData;
                        }
                        catch (Exception ex)
                        {
                            fileStream.Close();
                            File.Delete(Path);
                            return null;
                        }
                    }
                    catch (SerializationException ex)
                    {
                        fileStream.Close();
                        return null;
                    }
                    catch (DecoderFallbackException ex)
                    {
                        fileStream.Close();
                        return null;
                    }

                    fileStream.Close();
                    return playerData2;
                }
            }
        }


        throw new FileNotFoundException();
    }
}
