using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public bool trigger = false;
    public Material Doormaterial;
    private static bool HL = false;

    public bool TempWifeSprite = false;


    public Sprite spriteCL;
    public Sprite spriteOP;
    public Sprite spriteHA;

    private SpriteRenderer spriteRenderer;

    public GameObject BabyPrefab;

    public GameObject clock;
    public ClockTimer Clock;

    public GameObject ObDifSet;
    public DifSetUp DifSet;

    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();

        Doormaterial = GetComponent<SpriteRenderer>().material;

        spriteRenderer = GetComponent<SpriteRenderer>();
        Clock = clock.GetComponent<ClockTimer>();

        DifSet = ObDifSet.GetComponent<DifSetUp>();
    }

    void Update()
    {

        if (Clock.ClockTime % (5 + DifSet.IntChoosenDifMoveOp) == 0 && Simi.BabyGone && Clock.TimeBabyPause == true)
        {
            Clock.RandomBabySpawn = Clock.GenerateRandomNumber(Clock.RandomBabySpawn);
            Clock.TimeBabyPause = false;

            if (Clock.RandomBabySpawn <= (Clock.DifficultState + DifSet.IntchoosenDif) && Clock.BabyWait == false)
            {

                //Debug.Log("Spawn");
                Simi.BabyGone = false;
                Invoke("BabySpawn", 0f);
                Clock.BabyWait = true;
                

            }
            else if (Clock.BabyWait == true)
            {

                Clock.BabyWait = false;

            } 

        }
        if (TempWifeSprite)
        {
            
      
                spriteRenderer.sprite = spriteHA;

            
        }


        if (trigger)
        {
            Simi.PDoor = true;
            HL = true;

            if (Input.GetKeyDown(KeyCode.Z))
            {
                    
                    Simi.Door_flag = true;
                    TempWifeSprite = false;
                  
                    spriteRenderer.sprite = spriteOP;
                    Invoke("DoorcloseBaby", 0.75f);

                    if (Simi.PBaby ==false && Simi.Wife_flag ) {
                        

                        CancelInvoke("DoorcloseBaby");
                        Invoke("DoorcloseWife", 0.75f);
                
                    }
              
                    
                

            }


        }
        else
        {
            HL = false;
            Simi.PDoor = false;
        }
        Doormaterial.SetInt("_Boolean", HL ? 0 : 1);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;

    }

    void DoorcloseWife()
    {


            Simi.Wife_flag = false;
           
        

            spriteRenderer.sprite = spriteCL;
        
        Simi.Door_flag = false;
    }

    void DoorcloseBaby()
    {
        if (Simi.Wife_flag)
        {

            spriteRenderer.sprite = spriteHA;
        }
        else
        {
            spriteRenderer.sprite = spriteCL;
        }
        Simi.Door_flag = false;
    }


    void BabySpawn()
    {
        Instantiate(BabyPrefab, new Vector3(0.8544793f, 0, 0), Quaternion.identity);
        spriteRenderer.sprite = spriteOP;
        Invoke("DoorcloseBaby", 0.75f);


    }



}
