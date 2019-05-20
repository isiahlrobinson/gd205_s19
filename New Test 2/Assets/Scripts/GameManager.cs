using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timeLimit = 30f;
    public float score = 0f;
    public float highScore;

    public bool isGameOver = false;

    public Text timeLimitText;
    public Text scoreText;
    public Text scoreText2;
    public Text highScoreText;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        //Getting Highscore from PlayerPrefs
        highScore = PlayerPrefs.GetFloat("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        //Decreasing timer
        timeLimit -= Time.deltaTime;

        GameOver();

        //Setting all game text fields
        timeLimitText.text = Mathf.RoundToInt(timeLimit).ToString();
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
        highScoreText.text ="Highscore: " + highScore.ToString();
    }

    void GameOver()
    {
        if (timeLimit<= 0)
        {
            isGameOver = true;
        }

        if (isGameOver)
        {
            if (score > highScore)
            {
                PlayerPrefs.SetFloat("highScore", score);
                highScore = PlayerPrefs.GetFloat("highScore");
                                
            }
            gameOverPanel.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
