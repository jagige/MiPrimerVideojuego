using UnityEngine;

public class coin : MonoBehaviour
{
    public int cantidad;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory != null)
        {
            //añade coin
            playerInventory.addCoins(cantidad);

            Destroy(gameObject);
        }
    }
}
