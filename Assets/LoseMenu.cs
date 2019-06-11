using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;



public class LoseMenu : MonoBehaviour
{

    public GameObject loseMenuUI;
    public Timer timer;
    public GameObject resumeButton;


    void Update()
    {
        
        if (Player.lost || Player2.lost || Player3.lost || Player4.lost || Timer.timeIsOver)
        {
            Pause();
        }
 
    }


    void Pause()
    {

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            MainMenu.showResumeButton = false;
        }
        else if(Advertisement.IsReady()  && !(Application.internetReachability == NetworkReachability.NotReachable) && !MainMenu.usedAd)
        {
            MainMenu.showResumeButton = true;
        }

        if (MainMenu.showResumeButton)
        {
            resumeButton.SetActive(true);
        }

        if (!MainMenu.showResumeButton)
        {
            resumeButton.SetActive(false);
        }

        loseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void WatchAndPlay()
    {
        //watch ad and play
        Debug.Log("Show res" + MainMenu.showResumeButton);
        if (MainMenu.showResumeButton)
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult});
            MainMenu.usedAd = true;
        }
        
        
        
        
    }


    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("Finished");
                Player.lost = false;
                Player2.lost = false;
                Player3.lost = false;
                Player4.lost = false;
                loseMenuUI.SetActive(false);


                Timer.timeIsOver = false;
                timer.Start();

                Time.timeScale = 1f;
                MainMenu.showResumeButton = false;
                MainMenu.usedAd = true;
                SceneManager.LoadScene("Game");

                break;
            case ShowResult.Skipped:
                Debug.Log("Skipped");
                SceneManager.LoadScene("Menu");
                MainMenu.showResumeButton = true;
                MainMenu.usedAd = false;

                break;
            case ShowResult.Failed:
                Debug.Log("Failed");
                MainMenu.showResumeButton = true;
                SceneManager.LoadScene("Menu");
                MainMenu.usedAd = false;
                break;
        }
    }

   

}
