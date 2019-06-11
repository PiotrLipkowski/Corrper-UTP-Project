using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public static bool showResumeButton = true;
    public static bool usedAd = false;


    public void PlayGame()
    {
        LevelScript.levelValue = 1;
        Player.lost = false;
        Player2.lost = false;
        Player3.lost = false;
        Player4.lost = false;
        Timer.timeIsOver = false;
        Time.timeScale = 1f;
        showResumeButton = false;
        usedAd = false;
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
