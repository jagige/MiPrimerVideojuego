using UnityEngine;

public class plataformaMovil : MonoBehaviour
{
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float velocidadMovimiento;
    private int siguientePlataforma = 1;
    private bool ordenPlataforma = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.position = transform.position + (Vector3.up * Time.deltaTime); 
        if (ordenPlataforma && siguientePlataforma + 1 >= puntosMovimiento.Length)
        {
            ordenPlataforma = false;
        }
        if (!ordenPlataforma && siguientePlataforma <= 0)
        {
            ordenPlataforma = true;
        }

        if (Vector2.Distance(transform.position, puntosMovimiento[siguientePlataforma].position) < 0.1f)
        {
            if (ordenPlataforma)
            {
                siguientePlataforma += 1;
            }
            else
            {
                siguientePlataforma -= 1;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePlataforma].position, velocidadMovimiento * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(this.transform);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        other.transform.SetParent(null);
    }
}
