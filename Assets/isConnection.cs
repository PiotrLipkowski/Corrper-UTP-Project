using UnityEngine;
using UnityEngine.UI;

public class isConnection : MonoBehaviour
{

    Text isConn;
    // Start is called before the first frame update
    void Start()
    {
        isConn = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
        
            isConn.text = "Brak połączenia z internetem, nie możesz dalej grać!";
        }
        else
        {
            isConn.text = "";

        }

    }
}
