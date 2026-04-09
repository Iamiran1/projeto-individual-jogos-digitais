using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            endGamePanel.SetActive(true);
            healthBar.SetActive(false);
        }
    }
}
