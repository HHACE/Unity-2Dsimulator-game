using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StreamRunTime : MonoBehaviour
{

    public GameObject Player;
    public player Simi;



    public GameObject clock;
    public ClockTimer Clock;

    public GameObject Sign;

    public int BatteryStar;
    public int BatterySus;

    public int SpeedState;

    public bool TransitionAnim=false;

    public GameObject ObDifSet;
    public DifSetUp DifSet;


    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();
        Clock = clock.GetComponent<ClockTimer>();

        DifSet = ObDifSet.GetComponent<DifSetUp>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Simi.PBowl)
        {
            SpeedState = 5;
        }
        else {
            SpeedState = 0;
        }

        if (Clock.ClockTime % (10 - SpeedState + DifSet.IntChoosenDifMoveOp) == 0 && Clock.TimeStreamPause) {
            Clock.TimeStreamPause = false;

            BatteryStar += 1;
            BatterySus += 1;
        }

        if (BatteryStar == 5 || BatterySus == 5) {
            Clock.GOState = 3;
            Clock.StopRunning = true;

            SceneManager.LoadScene("GameOver Screen");
        }

        if (BatteryStar >= 3 || BatterySus >= 3)
        {
            Sign.SetActive(true);
        }
        else {
            Sign.SetActive(false);
        }


    }
}
