using UnityEngine;
using UnityEngine.SceneManagement;
public class Corpo1 : MonoBehaviour
{
    public bool reachCorpo1 = false;
    public Corpo2 corpo2;
    public Corpo3 corpo3;
    public Corpo4 corpo4;

    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public Timer timer;


    private void Start()
    {
        corpo2 = GameObject.Find("Corpo2").GetComponent<Corpo2>();
        corpo3 = GameObject.Find("Corpo3").GetComponent<Corpo3>();
        corpo4 = GameObject.Find("Corpo4").GetComponent<Corpo4>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            reachCorpo1 = true;
            player2.SetActive(true);
            timer.currentTime += 7f;
        }
        else if(collision.tag == "Player2")
        {
            player2.transform.position = new Vector3(-6.6f, -16.63f, 0);
        }
        else if (collision.tag == "Player3")
        {
            player3.transform.position = new Vector3(11.9f, -16.64f, 0);
        }
        else if (collision.tag == "Player4")
        {
            player4.transform.position = new Vector3(11.9f, -16.64f, 0);
        }



        if (reachCorpo1 && corpo2.reachCorpo2 && corpo3.reachCorpo3 && corpo4.reachCorpo4)
        {
            Debug.Log("You reach all");
            LevelScript.levelValue += 1;
            Debug.Log(LevelScript.levelValue);
        }

    }



}
