using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempNextScene : MonoBehaviour
{
    public GameObject clock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clock.GetComponent<ClockTimer>().GOState == 1) {
            SceneManager.LoadScene("GameOver Screen");
            
        }
    }
}
