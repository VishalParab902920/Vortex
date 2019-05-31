using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;

    public static int score;

    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        GameOverUI.SetActive(true);
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


    private bool isCoroutineExecuting = false;

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Time.timeScale = 0f;
    }
}
