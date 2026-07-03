using UnityEngine;
using System.Collections;

public class otraPlatRompe : MonoBehaviour
{
    [SerializeField] private float _timeToBreak;
    [SerializeField] private float _timeToRespawn;
    private SpriteRenderer _renderer;
    private Collider2D _collider;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<Collider2D>();
    }
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(rompePlat());
        }
    }

    private IEnumerator rompePlat()
    {
        yield return new WaitForSeconds(_timeToBreak);
        _renderer.color = Color.gray;
        _collider.enabled = false;

        yield return new WaitForSeconds(_timeToRespawn);
        _renderer.color = Color.purple;
        _collider.enabled = true;
    }
}
