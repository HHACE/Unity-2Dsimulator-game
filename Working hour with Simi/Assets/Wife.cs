using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wife : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public GameObject clock;
    public ClockTimer Clock;

    public GameObject door;
    public Door Door;

    public GameObject jumpsace;
  
    public Sprite wife0;
    public Sprite wife1;
    public Sprite wife2;
    public Sprite wife3;

    private SpriteRenderer spriteRenderer;

    public GameObject ObDifSet;
    public DifSetUp DifSet;


    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();
        Clock = clock.GetComponent<ClockTimer>();
        Door = door.GetComponent<Door>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        
        DifSet = ObDifSet.GetComponent<DifSetUp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Clock.ClockTime % (2 + DifSet.IntChoosenDifMoveOp) == 0 && Simi.Wife_flag == false && Clock.TimeWifePause == true)
        {
            Clock.RandomWifeSpawn = Clock.GenerateRandomNumber(Clock.RandomWifeSpawn);
            Clock.TimeWifePause = false;

            if (Clock.RandomWifeSpawn <= (Clock.DifficultState + DifSet.IntchoosenDif) && Clock.WifeWait == false)
            {
                spriteRenderer.sprite = wife1;

                Simi.Wife_flag = true;

                Door.TempWifeSprite = true;
                Clock.WifeWait = true;


            }
            else if (Clock.WifeWait == true)
            {

                Clock.WifeWait = false;

            }
        }
        
        
        if (Simi.Wife_flag == false) {
            spriteRenderer.sprite = wife0;
        }


        if (Clock.ClockTime % (5 + DifSet.IntChoosenDifMoveOp) == 0 && Simi.Wife_flag && Clock.TimeWifePause == true)
        {
            Clock.RandomWifeSpawn = Clock.GenerateRandomNumber(Clock.RandomWifeSpawn);
            Clock.TimeWifePause = false;

            if (Clock.RandomWifeSpawn <= (Clock.DifficultState + DifSet.IntchoosenDif) && Door.TempWifeSprite)
            {
                if (spriteRenderer.sprite == wife2)
                {
                    spriteRenderer.sprite = wife3;
                }
                else if (spriteRenderer.sprite == wife1) {
                    spriteRenderer.sprite = wife2;
                }
                else if (spriteRenderer.sprite == wife3) {
                    jumpsace.SetActive(true);
                    Invoke("EndGame", 0.75f);
                }


               
                Door.TempWifeSprite = true;
                Clock.WifeWait = true;


            }

              

        }


    }


    void EndGame()
    {
        Clock.GOState = 2;
        Clock.StopRunning = true;

        SceneManager.LoadScene("GameOver Screen");


    }

}
