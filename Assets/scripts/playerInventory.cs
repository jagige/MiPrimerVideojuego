using TMPro;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    int coins;
    public TextMeshProUGUI coinText;

    public void addCoins(int cantidad )
    {
        coins = coins + cantidad;
        coinText.text = coins.ToString();
    }
}
