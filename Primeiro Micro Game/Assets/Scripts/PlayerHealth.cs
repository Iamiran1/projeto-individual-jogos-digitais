using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health, MaxHealth;
    
    [SerializeField]
    private HealthBarUI healthBar;
    private PlayerController playerController;
    public bool gameOver = false;
    void Start()
    {
    healthBar.setMaxHealth(MaxHealth);
    playerController = GetComponent<PlayerController>();
    }
    

    public void setHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBar.setHealth(Health);
        playerController = GetComponent<PlayerController>();
        if (healthChange < 0)
        {
            playerController.TocarSomDano();

            if (Health <= 0)
            {
                
                gameOver  = true;
            }
        }
    }
    public void InstantKill()
    {
        Health = 0;
    }
}
