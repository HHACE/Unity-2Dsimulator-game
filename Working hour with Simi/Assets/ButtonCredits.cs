using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCredits : MonoBehaviour
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

    public void CreditsPanelOn()
    {
        CreditsPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }


}
