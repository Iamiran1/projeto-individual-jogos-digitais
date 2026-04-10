using UnityEngine;
using TMPro;

public static class GameController
{
    private static int collectableCount;
    private static PlayerHealth playerHealth;
    public static TMP_Text timeText;
    public static float timeCount;
    public static bool timeOver;

    public static void Restart()
    {
        collectableCount = 11;
        timeCount = 60f;
        timeOver = false;
    }

    public static bool winner
    {
        get { return collectableCount <= 0; }
    }

    public static bool gameOver
    {
        get { return playerHealth != null && playerHealth.Health <= 0; }
    }

    public static void Init()
    {
        playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
        collectableCount = 11;
        timeOver = false;
        timeCount = 60f;
    }

    public static void Collect()
    {
        collectableCount--;
    }

    public static void RefreshTime()
    {
        if (timeText != null)
        {
            timeText.text = timeCount.ToString("F000");
        }
    }

    public static void TimeCount()
    {
        if (!timeOver && timeCount > 0)
        {
            timeCount -= Time.deltaTime;
            RefreshTime();
        }

        if (timeCount <= 0)
        {
            timeCount = 0;
            playerHealth.InstantKill();
            timeOver = true;
        }
    }
}