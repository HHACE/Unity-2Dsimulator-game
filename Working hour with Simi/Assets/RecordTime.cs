using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordTime : MonoBehaviour
{
    public GameObject clock;
    public ClockTimer Clock;

    public GameObject Music;

    public int minute;
    public int second;
    //public int microsecond;


    // Start is called before the first frame update
    void Start()
    {
        clock = GameObject.Find("ClockFrame");
        Clock = clock.GetComponent<ClockTimer>();

        minute =  (90 - ((int) Clock.GameTime))/60;
        second = (90 - ((int)Clock.GameTime)) % 60;

        Music = GameObject.Find("Music");
        Destroy(Music);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = string.Format("{0:00}:{1:00}",minute, second);


        clock.SetActive(false);
    }
}
