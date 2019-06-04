using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject shop;

    public void Play()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        GameManager.score = 0;
    }

    public void openShop()
    {
        shop.SetActive(true);
    }
    public void closeShop()
    {
        shop.SetActive(false);
    }

    public void Exit()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }
}
