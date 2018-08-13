using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour {

    public Vector2 startForce;
    Rigidbody2D rb;

    Animator camAnim;
    public int health;
    public GameObject deathEffect;
    public GameObject explosion;

    private void Start()
    {
        camAnim = Camera.main.GetComponent<Animator>();

        startForce = new Vector2(4f, 2f);
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(startForce, ForceMode2D.Impulse);

        }

    }

    private void Update()
    {
        if (health <= 0) {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            GameManager.instance.score += 10;
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage) {
        camAnim.SetTrigger("shake");
        Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;
    }
}
