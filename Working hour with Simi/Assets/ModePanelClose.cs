using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModePanelClose : MonoBehaviour
{

    public GameObject MenuPanel;
    public GameObject ModePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModePanelX()
    {
        ModePanel.SetActive(false);
        MenuPanel.SetActive(true);

    }

}
