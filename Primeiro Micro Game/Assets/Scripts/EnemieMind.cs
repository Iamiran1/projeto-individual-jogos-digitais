using UnityEngine;

public class AiMind : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float damage = 20f;
    public float damageCooldown = 1f;

    private float distance;
    private float damageTimer;

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        damageTimer -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && damageTimer <= 0)
        {
            col.gameObject.GetComponent<PlayerHealth>().setHealth(-damage);
            damageTimer = damageCooldown;
        }
    }
}

