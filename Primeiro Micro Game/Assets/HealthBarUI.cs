using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public float Health, MaxHealth, Width, Height;
    
    [SerializeField]
    private RectTransform healthBar;
    public void setMaxHealth(float maxHealth)
    {
        MaxHealth = maxHealth;
    }

    public void setHealth(float health)
    {
        Health = health;
        float  newHealth = (Health / MaxHealth)*Width;
        healthBar.sizeDelta = new Vector2(newHealth, Height);
    }
}
