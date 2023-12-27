using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsPanelClose : MonoBehaviour
{

    public GameObject MenuPanel;
    public GameObject CreditsPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreditsPanelX()
    {
        CreditsPanel.SetActive(false);
        MenuPanel.SetActive(true);

    }
}
