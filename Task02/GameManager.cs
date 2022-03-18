public sealed class GameManager
{
    public static GameManager Manager = null;		
    public int LeftScore;
    public int RightScore;

    private GameManager() { }

    public static GameManager GetManagerObject()
    {
        if (Manager is not null)
            return Manager;

        if (Manager is null)
            Manager = new GameManager();

        return Manager;
    }
}