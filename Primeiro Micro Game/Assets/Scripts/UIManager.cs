using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject healthBar;
    public GameObject winnerTimeText;
    public GameObject InicialTimer;
    public TMP_Text endTimerText;
    
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
            Time.timeScale = 0f;
            winnerTimeText.SetActive(true);
            endTimerText.text = (timer - GameController.timeCount).ToString("F000");
            endGamePanel.SetActive(true);
            healthBar.SetActive(false);
            timerText.gameObject.SetActive(false);
            InicialTimer.SetActive(false);

        }

        if (!GameController.gameOver && !GameController.winner)
        {
            GameController.RefreshTime();
        }
    }
}
