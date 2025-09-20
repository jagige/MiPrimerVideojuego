using UnityEngine;

public class plataformaReaparece : MonoBehaviour
{
    [SerializeField] private GameObject _PlataformGameObject;

    [SerializeField] private float _timeToReaparecer;
    private float reaparecer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_PlataformGameObject == false)
        {
            reaparecer = Time.time;
            if (Time.time >= (reaparecer + _timeToReaparecer))
            {
                _PlataformGameObject.SetActive(true);
            }
        }
    }
}
