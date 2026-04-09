using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health, MaxHealth;

    [SerializeField]
    private HealthBarUI healthBar;
    void Start()
    {
    healthBar.setMaxHealth(MaxHealth);
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
        Health =  Mathf.Clamp(Health, 0, MaxHealth);
        healthBar.setHealth(Health);
    }
}
