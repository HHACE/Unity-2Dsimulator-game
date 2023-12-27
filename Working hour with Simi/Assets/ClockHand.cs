using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand : MonoBehaviour
{
    public GameObject GObject;
    public ClockTimer ClockTimer;

    public float Rotate=1;

    

    // Start is called before the first frame update
    void Start()
    {
        ClockTimer = GObject.GetComponent<ClockTimer>();
    }

    // Update is called once per frame
    void Update()
    {

       if (Rotate < 180) { 
            if (Rotate == ClockTimer.ClockTime)
            {
                Rotate += 1;
                ChangeRotation();
            }
        }
 


    }

    public void ChangeRotation() {
        gameObject.transform.Rotate(0.0f, 0.0f, -1, 0);
    }

}
