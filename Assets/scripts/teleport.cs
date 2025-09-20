using UnityEngine;

public class teleport : MonoBehaviour
{
    private Vector3 _Position;

    private void Start()
    {
        _Position = new Vector3(x:-4.17f,y: 9.32f, z:0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHealt playerHealt = collision.gameObject.GetComponent<playerHealt>();

        if (playerHealt == null)
        {
        }
        else
        {
            playerHealt.transform.position = _Position;
        }
    }
}
