using UnityEngine;

public class platform : MonoBehaviour
{
    [SerializeField] private float _timeToBreak;
    private float _timerAtCollision;
    private float _timerAtExit;
    private bool _isBreaking;
    [SerializeField] private GameObject _PlataformGameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isBreaking)
        {
            if (Time.time >= (_timerAtCollision + _timeToBreak))
            {
                _isBreaking = false;
                //Destroy(gameObject);//  gameObject.SetActive(false);
                _PlataformGameObject.SetActive(false);
            }
        }

       /* if (_isBreaking)
        {
            if (Time.time >= (_timerAtExit + (_timeToBreak *2)))
            {
                _isBreaking = true;
                _PlataformGameObject.SetActive(true);
            }
        }*/

        //se va para abajo
        // transform.position = transform.position + (Vector3.down * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory != null)
        {
            _isBreaking = true;
            _timerAtCollision = Time.time;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory != null)
        {
            //_isBreaking = false;
            _timerAtExit = Time.time;
            Debug.Log(_timerAtExit);
        }
    }
}
