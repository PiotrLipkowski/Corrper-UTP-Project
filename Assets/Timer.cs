using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;
    public static bool timeIsOver = false;

    [SerializeField] Text timerText;

    
    public void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {


        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString().Replace(",","");
        if (currentTime <= 10.0f)
        {
            timerText.text = currentTime.ToString().Substring(0,1);
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            timeIsOver = true;
        }

    }


}
