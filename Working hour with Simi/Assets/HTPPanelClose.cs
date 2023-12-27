using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPPanelClose : MonoBehaviour
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


    public void HTPPanelX()
    {
        HTPPanel.SetActive(false);
        MenuPanel.SetActive(true);

    }

}
