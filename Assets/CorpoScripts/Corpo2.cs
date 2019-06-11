using UnityEngine;
using UnityEngine.SceneManagement;
public class Corpo2 : MonoBehaviour
{

    public Timer timer;

    public Corpo1 corpo1;
    public bool reachCorpo2 = false;
    public Corpo3 corpo3;
    public Corpo4 corpo4;

    public GameObject player3;
    public GameObject player2;
    public GameObject player1;
    public GameObject player4;


    private void Start()
    {
    corpo1 = GameObject.Find("Corpo1").GetComponent<Corpo1>();
    corpo3 = GameObject.Find("Corpo3").GetComponent<Corpo3>();
    corpo4 = GameObject.Find("Corpo4").GetComponent<Corpo4>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.tag == "Player2")
        {
            reachCorpo2 = true;
            player3.SetActive(true);
            timer.currentTime += 5f;
        }
        else if (collision.tag == "Player")
        {
            player1.transform.position = new Vector3(-23.32f, -16.32f, 0);
        }
        else if (collision.tag == "Player3")
        {
            player3.transform.position = new Vector3(11.9f, -16.64f, 0);
        }
        else if (collision.tag == "Player4")
        {
            player4.transform.position = new Vector3(11.9f, -16.64f, 0);
        }


        if (corpo1.reachCorpo1 && reachCorpo2 && corpo3.reachCorpo3 && corpo4.reachCorpo4)
        {
            Debug.Log("You reach all");
            LevelScript.levelValue += 1;
            Debug.Log(LevelScript.levelValue);
        }
        
    }
}
