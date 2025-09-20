using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMnager : MonoBehaviour
{
    public playerHealt vidas;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI vidasText;
    public TextMeshProUGUI timerText;
        public float timeToLose;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeToLose = timeToLose + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //cerrar el juego
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //reiniciar el juego
        
        if (Input.GetKeyDown(KeyCode.R)) //|| vidas.lives <= 0)
        {
            reiniciar();
        }

        timerText.text = (timeToLose - Time.time).ToString("F0");

        if((timeToLose - Time.time) <= 0)
        {
            reiniciar();
        }
    }
    public void reiniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
}
