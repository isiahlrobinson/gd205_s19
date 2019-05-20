using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    float highScore;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text ="Highscore:" + highScore.ToString();
    }

    public void LoadLevel(int i)
    {
        SceneManager.LoadScene(i); 
    }

    public void Quit()
    {
        Application.Quit();
    }
}
