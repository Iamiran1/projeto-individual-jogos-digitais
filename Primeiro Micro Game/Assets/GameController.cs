using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static PlayerHealth playerHealth;
    

    public static bool winner
    {
        get { return collectableCount <= 0; }
    }

    public static bool gameOver
    {
        get
        {
            
            return playerHealth.Health <= 0;
        }
    }
    public static void Init()
    {
        playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
        collectableCount = 11;
    }

    public static void Collect()
    {
        collectableCount--;
    }
}
