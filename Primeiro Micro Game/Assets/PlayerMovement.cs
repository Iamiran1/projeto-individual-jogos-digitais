using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 8f;

    [Header("Sons")]
    [SerializeField] private AudioClip somPulo;
    [SerializeField] private AudioClip somColetavel;
    [SerializeField] private AudioClip somDano;
    [SerializeField] private AudioClip somMorte;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            TocarSom(somPulo);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);
    }

    private void TocarSom(AudioClip clip)
    {
        if (clip != null)
            audioSource.PlayOneShot(clip);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coletavel"))
        {
            TocarSom(somColetavel);
            GameController.Collect();
            Destroy(other.gameObject);
        }
    }

    public void TocarSomDano() => TocarSom(somDano);
    public void TocarSomMorte() => TocarSom(somMorte);
}