using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D mybody;
    public float walkspeed;

    public SpriteRenderer sprite;

    public Animator animator;

    public GameObject baby;

    // priority falg
    public bool PBaby = false;
    public bool PTablet = false;
    public bool PCom = false;
    public bool PDoor = false;
    public bool PBowl = false;
    

    // flag
    public bool Babypickup_flag = false;
    public bool Babypickup_flag_temp = false;
    public bool BabyGone = false; // check baby
    public bool Tablet_flag = false;
    public bool Com_flag = false;
    public bool Door_flag = false;
    public bool Wife_flag = false;

    public bool Temp_flag =false;



    public bool StopGameTime = false;


    // Start is called before the first frame update
    void Start()
    {
        BabyGone = true; 
    }

    public float inputHorizon;

    // Update is called once per frame
    void Update()
    {
       // baby = GameObject.Find("baby");
        baby = GameObject.Find("baby(Clone)");
        if (Tablet_flag)
        {
            sprite.flipX = true;
            gameObject.transform.position = new Vector3(-0.4077608f, -0.173258f, 0f);
            animator.SetFloat("walk", 0);
        }
        else if (Com_flag)
        {
            sprite.flipX = true;
            gameObject.transform.position = new Vector3(-0.6923564f, -0.173258f, 0f);
            animator.SetFloat("walk", 0);
        }
        else if (Door_flag && Babypickup_flag)
        {
            Destroy(baby);
            PBaby = false;
            Babypickup_flag = false;
            BabyGone = true;
        }
        else if (Babypickup_flag) 
        {
            animator.SetFloat("Pick", 1);

            inputHorizon = Input.GetAxisRaw("Horizontal");

            if (inputHorizon != 0)
            {
                mybody.velocity = new Vector2(inputHorizon * walkspeed, 0f);
                animator.SetFloat("walk", 1);
                
                if (inputHorizon == 1)
                {
                    sprite.flipX = false;
                }
                else
                {
                    sprite.flipX = true;
                }

            }
            else
            {
                animator.SetFloat("walk", 0);
            }

        }
        else
        {
            animator.SetFloat("Pick", 0);

            inputHorizon = Input.GetAxisRaw("Horizontal");

            if (inputHorizon != 0)
            {
                mybody.velocity = new Vector2(inputHorizon * walkspeed, 0f);
                animator.SetFloat("walk", 1);
                if (inputHorizon == 1)
                {
                    sprite.flipX = false;
                }
                else
                {
                    sprite.flipX = true;
                }

            }
            else
            {
                animator.SetFloat("walk", 0);
            }

        }

    }

}
