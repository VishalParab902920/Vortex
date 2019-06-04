using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Toggle[] ballSelectors;

    float highScore;
    int ballToUse;

    private void Update()
    {
        BallUnlocker();
        chooseBallToUse();
    }

    public void chooseBallToUse()
    {
        for (int i = 0; i < ballSelectors.Length; i++)
        {
            if (ballSelectors[i].isOn)
                ballToUse = i;
        }
        PlayerPrefs.SetInt("BallToUse", ballToUse);
    }

    public void BallUnlocker()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);

        if (highScore > 10)
            ballSelectors[1].interactable = true;
        if (highScore > 50)
            ballSelectors[2].interactable = true;
        if (highScore > 100)
            ballSelectors[3].interactable = true;
        if (highScore > 150)
            ballSelectors[4].interactable = true;
        if (highScore > 250)
            ballSelectors[5].interactable = true;
        if (highScore > 350)
            ballSelectors[6].interactable = true;
    }
}
