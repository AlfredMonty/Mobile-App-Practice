using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public int playerHighscore;

    public AudioSource scoreAudio;

    public Scene scene; 

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    public GameObject gameOverScreen;
    public GameObject endApp;

    public BirdScript birdScript;

    [ContextMenu("Increase Score")]
    //Add to score. 
    public void AddScore(int scoreToAdd)
    {
        if (birdScript.birdAlive == true)
        {
            playerScore += 1;
            scoreText.text = playerScore.ToString();
            Debug.Log("Played Audio!");
            scoreAudio.Play();
        }
    }

    public void RestartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        endApp.SetActive(true);
    }

    private void Start()
    {
        Load();
    }

    public void Update()
    {
        if (scoreText == null || highscoreText == null)
        {
            return; 
        }
        else
        {
            scoreText.text = playerScore.ToString();
            highscoreText.text = playerHighscore.ToString();
        }

        if (playerScore > playerHighscore)
        {
            playerHighscore = playerScore;
            Save();
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("score", playerScore);
        PlayerPrefs.SetInt("highscore", playerHighscore);
    }
    public void Load()
    {
        //playerScore = PlayerPrefs.GetInt("score");
        playerHighscore = PlayerPrefs.GetInt("highscore");
    }

    public void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}

