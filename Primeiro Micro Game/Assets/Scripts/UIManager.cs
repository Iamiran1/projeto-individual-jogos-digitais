using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject healthBar;
    public GameObject gameOverPanel;
    public float timer;
    public TMP_Text timerText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameController.Init();
        GameController.timeText = timerText ;
        GameController.timeCount = timer;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameController.TimeCount();
        if (GameController.gameOver)
        {
            SceneManager.LoadScene("GameOver");
            healthBar.SetActive(false);
        }

        if (GameController.winner)
        {
            endGamePanel.SetActive(true);
            healthBar.SetActive(false);

        }

        if (!GameController.gameOver && !GameController.winner)
        {
            GameController.RefreshTime();
        }
    }
}
