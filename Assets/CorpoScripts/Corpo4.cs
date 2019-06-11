using UnityEngine;
using UnityEngine.SceneManagement;

public class Corpo4 : MonoBehaviour
{
    public Timer timer;

    public Corpo1 corpo1;
    public Corpo2 corpo2;
    public Corpo3 corpo3;
    public bool reachCorpo4 = false;

    public GameObject player3;
    public GameObject player2;
    public GameObject player1;

    void Start()
    {
        corpo1 = GameObject.Find("Corpo1").GetComponent<Corpo1>();
        corpo2 = GameObject.Find("Corpo2").GetComponent<Corpo2>();
        corpo3 = GameObject.Find("Corpo3").GetComponent<Corpo3>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player4")
        {
            reachCorpo4 = true;
        }
        else if (collision.tag == "Player")
        {
            player1.transform.position = new Vector3(-23.32f, -16.32f, 0);
        }
        else if (collision.tag == "Player2")
        {
            player2.transform.position = new Vector3(-6.6f, -16.63f, 0);
        }
        else if (collision.tag == "Player3")
        {
            player3.transform.position = new Vector3(11.9f, -16.64f, 0);
        }

        if (corpo1.reachCorpo1 && corpo2.reachCorpo2 && corpo3.reachCorpo3 && reachCorpo4)
        {
            Debug.Log("You reach all");
            LevelScript.levelValue += 1;
            Debug.Log(LevelScript.levelValue);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }


}
