using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public GameObject canvas;
    public GameObject Stream;
    public GameObject StreamBG;
    public GameObject Transition;

    //public GameObject SpriteStar;

    public bool trigger = false;
    public Material Commaterial;
    private static bool HL = false;

    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();

        Commaterial = GetComponent<SpriteRenderer>().material;

      
    }

    // Update is called once per frame
    void Update()
    {
        //SpriteStar = GameObject.Find("SpriteStar(Clone)");
        if (trigger)
        {
            Simi.PCom = true;
            /*bbmaterial.SetFloat("_CHECK", 1f);*/
            if (Simi.Com_flag == false)
            {
                HL = true;
            }
            else
            {
                HL = false;
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (Simi.Com_flag == false)
                {

                    Transition.SetActive(true);
                    Stream.GetComponent<StreamRunTime>().TransitionAnim = true;
                    CancelInvoke("StopTransition");
                    Invoke("TransitionDone", 0.15f);

                    canvas.SetActive(false);
                    Simi.Com_flag = true;

                }
                else
                {
                    Stream.GetComponent<StreamRunTime>().TransitionAnim = true;
                    CancelInvoke("TransitionDone");
                    Invoke("StopTransition", 0.15f);

                    StreamBG.SetActive(false);
                    canvas.SetActive(true);
                    Simi.Com_flag = false;


                }
            }
        }
        else
        {
            HL = false;
            Simi.PCom = false;
        }
        Commaterial.SetInt("_Boolean", HL ? 0 : 1);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;
        
    }


    public void StopTransition() {
        Transition.SetActive(false);
    }


    public void TransitionDone()
    {
        StreamBG.SetActive(true);

    }

}
