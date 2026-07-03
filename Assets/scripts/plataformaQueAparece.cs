using UnityEngine;
using System.Collections;

public class plataformaQueAparece : MonoBehaviour
{
    [SerializeField] private float _timeToBreak;
    [SerializeField] private float _timeToRespawn;
    [SerializeField] private GameObject _PlataformGameObject;
  

      private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(destruccion());
        }
    }

    private IEnumerator destruccion()
    {
        yield return new WaitForSeconds(_timeToBreak);
        _PlataformGameObject.SetActive(false);
        yield return new WaitForSeconds(_timeToRespawn);
        _PlataformGameObject.SetActive(true);
    }
}
