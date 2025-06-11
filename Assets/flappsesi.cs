using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip flapSound;
    public AudioClip deathSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    void Flap()
    {
        // Fizik işlemleri (kuşu yukarı zıplatma vs.)
        audioSource.PlayOneShot(flapSound);
    }

    void Die()
    {
        audioSource.PlayOneShot(deathSound);
        // Ölüm animasyonu, sahne restart falan burada olabilir
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Kuş bir yere çarptığında öl
        Die();
    }
}
