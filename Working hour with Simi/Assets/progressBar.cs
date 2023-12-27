using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class progressBar : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public Slider slider;

    public GameObject fill;

    public GameObject clock;


    public float progessValue = 0f;

    public float red;
    public float green;
    public float blue;
    public float maxColor = 255;


    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Simi.Tablet_flag && Simi.BabyGone)
        {
            red = 46f;
            green = 143f;
            blue = 226f;
            progessValue += Time.deltaTime * 3;
            UpdateFillColor();
            UpdateSlider();

        }
        else if (Simi.BabyGone == false) {
            red = 227f;
            green = 41f;
            blue = 40f;
            UpdateFillColor();
        }

        else {
            red = 46f;
            green = 70;
            blue = 91f;
            UpdateFillColor();
        }

        if (progessValue > 100) {
            clock.GetComponent<ClockTimer>().StopRunning = true;
            SceneManager.LoadScene("Win Screen");
        }

    }

    public void UpdateSlider() { 
        slider.value = progessValue;
       
    }



    public void UpdateFillColor()
    {
        fill.GetComponent<Image>().color = new Color(red/maxColor, green/maxColor , blue/maxColor );
    }

}
