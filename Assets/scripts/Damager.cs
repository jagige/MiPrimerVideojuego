using UnityEngine;

public class Damager : MonoBehaviour
{
    public int danio;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       playerHealt playerHealt = collision.gameObject.GetComponent<playerHealt>();

        if (playerHealt == null)
        {
        }
        else
        {
            playerHealt.DamagePlayer(danio);
        }
    }
    
}
