using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextMode : MonoBehaviour
{
    public GameObject ChoosenDif;
    public ChoosenDifficulty CD;

    // Start is called before the first frame update
    void Start()
    {
        ChoosenDif = GameObject.Find("ChoosenDif");
        ChoosenDif = GameObject.Find("ChoosenDif");
        CD = ChoosenDif.GetComponent<ChoosenDifficulty>();

        if (CD.choosenDif == -1)
        {
            gameObject.GetComponent<Text>().text = "BABY MODE";
        } else
        {
            gameObject.GetComponent<Text>().text = "GAMER MODE";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
