using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject healthBar;
    public GameObject gameOverPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameController.Init();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            gameOverPanel.SetActive(true);
            healthBar.SetActive(false);
        }
    }
}
