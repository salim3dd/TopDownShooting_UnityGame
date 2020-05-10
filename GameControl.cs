using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static int Score = 0;
    public static float Hleath = 1;

    public Text TXTScore;
    public Image HleathBar;

    public GameObject GameOver;

    void Start()
    {
        Score = 0;
        Hleath = 1;
        GameOver.SetActive(false);

    }
 
    void Update()
    {
        HleathBar.fillAmount = Hleath;
        TXTScore.text = Score.ToString();

        if (Hleath <= 0) {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void BTNRestart() {
        Time.timeScale = 1;
        Score = 0;
        Hleath = 1;
        GameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
