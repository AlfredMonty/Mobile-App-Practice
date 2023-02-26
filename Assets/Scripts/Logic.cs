using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class Logic : MonoBehaviour
{
    public int playerScore;
    public AudioSource scoreAudio;
    public Scene scene; 
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript birdScript; 

    [ContextMenu("Increase Score")]
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
    }
}
