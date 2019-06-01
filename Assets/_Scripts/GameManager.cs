using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public Text scoreText;
    public Text highScoreText;

    public static int score;

    private void Start()
    {
        score = 0;
        highScoreText.text= PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
    private void Update()
    {
        Scoring();
    }

    public void GameOver()
    {
        StartCoroutine(ExecuteAfterTime(1));
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Scoring()
    {
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Debug.Log("GameOver");
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    
}