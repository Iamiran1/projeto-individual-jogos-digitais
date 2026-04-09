using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health, MaxHealth;
    
    [SerializeField]
    private HealthBarUI healthBar;
    private PlayerController playerController;
    void Start()
    {
    healthBar.setMaxHealth(MaxHealth);
    playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            setHealth(20f);
        }
        if (Input.GetKeyDown("l"))
        {
            setHealth(-20f);
        }
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
                playerController.TocarSomMorte();
        }
    }
}
