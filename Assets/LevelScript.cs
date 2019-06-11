using UnityEngine;
using UnityEngine.UI;


public class LevelScript : MonoBehaviour
{
    public static int levelValue = 1;
    Text level;

    public AudioSource streetSound;

    void Start()
    {
        level = GetComponent<Text>();
        streetSound.Play(0);

    }

    // Update is called once per frame
    void Update()
    {

        level.text = "LVL: " + levelValue.ToString();
        
        if (Player.lost || Player2.lost || Player3.lost || Player4.lost || Timer.timeIsOver)
        {
            level.text = "FINISH ON LEVEL:" + levelValue.ToString().ToUpper();
            streetSound.Stop();
            
        }


    }
}
