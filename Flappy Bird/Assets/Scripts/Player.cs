using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public GameManager manager;
    [SerializeField] private float velocity = 4.5f;
    private Rigidbody2D rb;

    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip dead;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
            manager.playSound(jump);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            manager.pause();
        }

        float angle = Mathf.Lerp(35, -15, -rb.velocity.y / 15);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        manager.playSound(dead);
        manager.GameOver();
    }
}
