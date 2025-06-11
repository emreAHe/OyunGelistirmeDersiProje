using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // --- Components & refs ---
    Rigidbody2D rb;            // cached rigidbody
    [Header("Movement")]
    public float jumpForce = 0.5f;   // yukarı zıplama hızı

    [Header("UI")]
    public Text scoreText;
    public GameObject deadPanel;

    int score;
    bool isDead;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
        scoreText.text = "0";
        deadPanel.SetActive(false);
    }

    void Update()
    {
        // Yaşarken tek dokunuşla yukarı zıplat
        if (!isDead && Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = new Vector2(0f, jumpForce);   // 🔸 velocity — linearVelocity değil!
           
            
        }

        // Ölünce oyunu durdur, panel aç, dokununca yeniden başlat
        if (isDead)
        {
            Time.timeScale = 0f;
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    // Puan objesi “IsTrigger” olmalı
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("skor"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    // Engelle çarpınca öl
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (isDead) return;           // çift tetiklenmesin
        isDead = true;
        deadPanel.SetActive(true);
    }
}