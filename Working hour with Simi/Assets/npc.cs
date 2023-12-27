using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public bool left = true;
    public Transform baby;
    //public bool pickup = false;

    public Material bbmaterial;
    private static bool HL = false;

    public GameObject Player;

    public player Simi;

    public Rigidbody2D babybody;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Simi walking sprite");

        baby = GetComponent<Transform>();
        Simi = Player.GetComponent<player>();

        bbmaterial = GetComponent<SpriteRenderer>().material;


        gameObject.AddComponent<Animator>();
        gameObject.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("baby") as RuntimeAnimatorController;
                                                                                         

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Simi.Babypickup_flag && Simi.PBaby) {
            HL = false;
            moveSpeed = 0f;
            CancelInvoke("dropdone");
            animator.SetFloat("pickup", 1);
            Vector3 temp = new Vector3(0,0,0);
            if (Simi.sprite.flipX)
            {
                 temp = new Vector3(Simi.transform.position.x - 0.15f, Simi.transform.position.y + 0.05f, 0f);
            }
            else {
                 temp = new Vector3(Simi.transform.position.x + 0.15f, Simi.transform.position.y + 0.05f, 0f);
            }
            
            gameObject.transform.position = temp;
        }
        else if (Simi.Babypickup_flag == false && Simi.PBaby)
        {
            HL = true;
            
            Invoke("dropdone", 0.75f);
            if (baby.transform.position.x < -0.8)
            {
                animator.SetFloat("flipX", 0);
                left = false;
            }
            if (baby.transform.position.x > 0.6)
            {
        
                animator.SetFloat("flipX", 1);
                left = true;
            }

            directionMove();
        }
        else if (Simi.PBaby == false) {
            animator.SetFloat("pickup", 0);
            HL = false;
            if (baby.transform.position.x < -0.8)
            {
     
                animator.SetFloat("flipX", 0);
                left = false;
            }
            if (baby.transform.position.x > 0.6)
            {
     
                animator.SetFloat("flipX",1);
                left = true;
            }

            directionMove();
        }

        bbmaterial.SetInt("_Boolean", HL ? 0 : 1);
    }

    void directionMove() {
        if (left == true)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            
        }
        else {
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

        }

    }

    void dropdone()
    {
        moveSpeed = 0.5f;
        animator.SetFloat("pickup", 0);
    }


}
