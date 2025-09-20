using System.Collections;
using UnityEngine;

public class plataformaDestruible : MonoBehaviour
{
    [SerializeField] private float tiempoDeEspera;
    private BoxCollider2D _collider;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D rb2D;
    private bool caida = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Caida(other));
        }
    }

    private IEnumerator Caida(Collision2D other)
    {
        yield return new WaitForSeconds(tiempoDeEspera);
        caida = true;
        Physics2D.IgnoreCollision(transform.GetComponent<Collider2D>(), other.transform.GetComponent<Collider2D>());
        rb2D.constraints = RigidbodyConstraints2D.None;
        rb2D.AddForce(new Vector2(0.1f, 0));
    }
}
