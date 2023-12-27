using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapChap_trigger : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public bool trigger = false;
    public Material Bowlmaterial;
    private static bool HL = false;

    public Sprite spriteEmpty;
    public Sprite spriteFull;

    private SpriteRenderer spriteRenderer;


    public GameObject clock;
    public ClockTimer Clock;



    public GameObject ObDifSet;
    public DifSetUp DifSet;


    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();


        Bowlmaterial = GetComponent<SpriteRenderer>().material;

        spriteRenderer = GetComponent<SpriteRenderer>();

        Clock = clock.GetComponent<ClockTimer>();

        DifSet = ObDifSet.GetComponent<DifSetUp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Clock.ClockTime % (6 + DifSet.IntChoosenDifMoveOp)  == 0 && Simi.PBowl == false && Clock.TimeChapPause == true)
        {
            Clock.RandomChapHungry = Clock.GenerateRandomNumber(Clock.RandomChapHungry);
            Clock.TimeChapPause = false;

            if (Clock.RandomChapHungry <= (Clock.DifficultState + DifSet.IntchoosenDif) && Clock.ChapWait == false)
            {

                //Debug.Log("Spawn");
                Simi.PBowl = true;
                Clock.ChapWait = true;


            }
            else if (Clock.ChapWait == true)
            {

                Clock.ChapWait = false;

            }
        }


            if (Simi.PBowl)
        {
            spriteRenderer.sprite = spriteEmpty;
            if (trigger)
            {
                HL = true;

                if (Input.GetKeyDown(KeyCode.Z))
                {
                    
                    Simi.PBowl = false;



                }
            }
            else
            {
                HL = false;
            }
            
        }
        else {
            HL = false;
            spriteRenderer.sprite = spriteFull;
        }

        Bowlmaterial.SetInt("_Boolean", HL ? 0 : 1);

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;

    }



}
