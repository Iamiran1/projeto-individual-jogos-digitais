using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    public Sprite[] frames;       // arraste os sprites aqui
    public float fps = 8f;

    private SpriteRenderer sr;
    private int currentFrame;
    private float timer;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f / fps)
        {
            timer = 0;
            currentFrame = (currentFrame + 1) % frames.Length;
            sr.sprite = frames[currentFrame];
        }
    }
}