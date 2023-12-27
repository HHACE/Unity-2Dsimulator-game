using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHTP : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject HTPPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HTPPanelOn() { 
            HTPPanel.SetActive(true);
            MenuPanel.SetActive(false);
    }

}
