
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockTimer : MonoBehaviour
{
    public float GameTime;
    public float BaseTime;
    public int ClockTime = 0;

    public int DifficultState;

    

    //public int DifficultyBaby = 0;

    public int RandomBabySpawn;
    public bool BabyWait = false;

    public bool TimeBabyPause = false;

    public int RandomChapHungry;

    public bool ChapWait = false;
    public bool TimeChapPause = false;


    public int RandomWifeSpawn;

    public bool WifeWait = false;
    public bool TimeWifePause = false;


    public bool TimeStreamPause = false;


    // Result flag
    public bool StopRunning =false;

    public int GOState = 0; // 1 time, 2 Wife, 3 Chat


    // Start is called before the first frame update
    void Start()
    {
        BaseTime = GameTime / 180;
        DifficultState = 1;


        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (StopRunning == false)
        {
            //countdown
            if (GameTime > 0)
            {
                GameTime -= Time.deltaTime;
            }
            else
            {
                GameTime = 0;

            }

            if (ClockTime < 180)
            {
                if (GameTime < BaseTime * (180 - ClockTime))
                {
                    ClockTime += 1;

                    TimeBabyPause = true;

                    TimeChapPause = true;

                    TimeWifePause = true;

                    TimeStreamPause = true;

                    if (ClockTime == 36 * DifficultState)
                    {
                        DifficultState += 1;
                    }

                }
            }

            if (ClockTime == 180)
            {
                GOState = 1;
                StopRunning = true;
                
            }
        }

    }

    public int GenerateRandomNumber(int chance) { 
        chance = Random.Range(0, 6);
        return chance;
    }

}
