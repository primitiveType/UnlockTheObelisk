namespace ATOUnlocker;

[Serializable]
public class PlayerData
{
    private string steamUserId;
    private string[] lastUsedTeam;
    private List<string> tutorialWatched;
    private List<string> unlockedHeroes;
    private List<string> unlockedCards;
    private List<string> unlockedNodes;
    private List<string> playerRuns;
    private List<string> bossesKilledName;
    private List<string> supplyBought;
    private bool ngUnlocked;
    private int ngLevel;
    private int playerRankProgress;
    private int maxAdventureMadnessLevel;
    private int obeliskMadnessLevel;
    private int bossesKilled;
    private int monstersKilled;
    private int expGained;
    private int cardsCrafted;
    private int cardsUpgraded;
    private int goldGained;
    private int dustGained;
    private int bestScore;
    private int purchasedItems;
    private int supplyGained;
    private int supplyActual;
    private int corruptionsCompleted;
    private List<string> treasuresClaimed;
    private Dictionary<string, List<string>> unlockedCardsByGame;
    private Dictionary<string, int> heroProgress;
    private Dictionary<string, List<string>> heroPerks;
    private Dictionary<string, string> skinUsed;
    private Dictionary<string, string> cardbackUsed;

    public List<string> UnlockedHeroes
    {
        get => unlockedHeroes;
        set => unlockedHeroes = value;
    }

    public List<string> UnlockedCards
    {
        get => unlockedCards;
        set => unlockedCards = value;
    }

    public List<string> UnlockedNodes
    {
        get => unlockedNodes;
        set => unlockedNodes = value;
    }

    public List<string> PlayerRuns
    {
        get => playerRuns;
        set => playerRuns = value;
    }

    public List<string> TreasuresClaimed
    {
        get => treasuresClaimed;
        set => treasuresClaimed = value;
    }

    public Dictionary<string, List<string>> UnlockedCardsByGame
    {
        get => unlockedCardsByGame;
        set => unlockedCardsByGame = value;
    }

    public List<string> TutorialWatched
    {
        get => tutorialWatched;
        set => tutorialWatched = value;
    }

    public string[] LastUsedTeam
    {
        get => lastUsedTeam;
        set => lastUsedTeam = value;
    }

    public int BossesKilled
    {
        get => bossesKilled;
        set => bossesKilled = value;
    }

    public int MonstersKilled
    {
        get => monstersKilled;
        set => monstersKilled = value;
    }

    public int CardsCrafted
    {
        get => cardsCrafted;
        set => cardsCrafted = value;
    }

    public int CardsUpgraded
    {
        get => cardsUpgraded;
        set => cardsUpgraded = value;
    }

    public int GoldGained
    {
        get => goldGained;
        set => goldGained = value;
    }

    public int DustGained
    {
        get => dustGained;
        set => dustGained = value;
    }

    public int BestScore
    {
        get => bestScore;
        set => bestScore = value;
    }

    public int ExpGained
    {
        get => expGained;
        set => expGained = value;
    }

    public int PurchasedItems
    {
        get => purchasedItems;
        set => purchasedItems = value;
    }

    public Dictionary<string, int> HeroProgress
    {
        get => heroProgress;
        set => heroProgress = value;
    }

    public Dictionary<string, List<string>> HeroPerks
    {
        get => heroPerks;
        set => heroPerks = value;
    }

    public List<string> BossesKilledName
    {
        get => bossesKilledName;
        set => bossesKilledName = value;
    }

    public int SupplyGained
    {
        get => supplyGained;
        set => supplyGained = value;
    }

    public int SupplyActual
    {
        get => supplyActual;
        set => supplyActual = value;
    }

    public List<string> SupplyBought
    {
        get => supplyBought;
        set => supplyBought = value;
    }

    public bool NgUnlocked
    {
        get => ngUnlocked;
        set => ngUnlocked = value;
    }

    public int CorruptionsCompleted
    {
        get => corruptionsCompleted;
        set => corruptionsCompleted = value;
    }

    public string SteamUserId
    {
        get => steamUserId;
        set => steamUserId = value;
    }

    public int NgLevel
    {
        get => ngLevel;
        set => ngLevel = value;
    }

    public Dictionary<string, string> SkinUsed
    {
        get => skinUsed;
        set => skinUsed = value;
    }

    public Dictionary<string, string> CardbackUsed
    {
        get => cardbackUsed;
        set => cardbackUsed = value;
    }

    public int ObeliskMadnessLevel
    {
        get => obeliskMadnessLevel;
        set => obeliskMadnessLevel = value;
    }

    public int MaxAdventureMadnessLevel
    {
        get => maxAdventureMadnessLevel;
        set => maxAdventureMadnessLevel = value;
    }

    public int PlayerRankProgress
    {
        get => playerRankProgress;
        set => playerRankProgress = value;
    }
}
