

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonRetry : MonoBehaviour
{
    public GameObject clock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock = GameObject.Find("ClockFrame");
    }

    public void LoadGameScene() {
        Destroy(clock);
        SceneManager.LoadScene("Stage work");
    }

}
