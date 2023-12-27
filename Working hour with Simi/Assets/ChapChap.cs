using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapChap : MonoBehaviour
{
    public GameObject Player;
    public player Simi;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        Simi = Player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Simi.PBowl)
        {
            animator.SetFloat("Hungry", 1);

        }
        else
        {
            animator.SetFloat("Hungry", 0);
        }
    }
}
