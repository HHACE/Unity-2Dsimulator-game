using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReturn : MonoBehaviour
{

    public GameObject clock;

    public GameObject ChoosenDif;

    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("ClockFrame");
        ChoosenDif = GameObject.Find("ChoosenDif");
    }

    // Update is called once per frame
    void Update()
    {

        
    }


    public void LoadStartScene()
    {
        Destroy(clock);
        Destroy(ChoosenDif);
        SceneManager.LoadScene("Start Screen");
    }

}
