using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealt : MonoBehaviour
{
    public int lives;
    public gameMnager reinicio;
    public TextMeshProUGUI vidasText;

    private void Start()
    {
        vidasText.text = lives.ToString();
    }
    private void Update() //hacer daño al jugador presionando L
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DamagePlayer(1);
        }

       /* if (lives <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        /* if (Input.GetKeyDown(KeyCode.M))
         {
             Debug.Log(lives);
         }*/
       if (lives <= 0)
        {
            reinicio.reiniciar();
        }
    }
    
    //hacer daño al jugador
    public void DamagePlayer(int danio)
    {
        lives = lives - danio;
        //Debug.Log("vidas = " + lives);
        
        if (lives >= 0)
        {
            vidasText.text = lives.ToString();
        }
        else
        {
            vidasText.text = "0";
        }
    }



}
