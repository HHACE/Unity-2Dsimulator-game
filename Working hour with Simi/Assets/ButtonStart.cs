

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{

    public GameObject MenuPanel;
    public GameObject ModePanel;


    public GameObject ChoosenDif;
    public ChoosenDifficulty ChoosenDifficulty;

    // Start is called before the first frame update
    void Start()
    {
        ChoosenDifficulty = ChoosenDif.GetComponent<ChoosenDifficulty>();

       

    }

    // Update is called once per frame
    void Update()
    {
        //clock = GameObject.Find("ClockFrame");
    }

    public void EasyMode() {
       
        ChoosenDifficulty.choosenDif = -1;
        LoadGameScene();
    }
    public void HardMode()
    {
        ChoosenDifficulty.choosenDif = 0;
        LoadGameScene();
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Stage work");
    }


    public void ModePanelOn()
    {
        
        ModePanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

}

