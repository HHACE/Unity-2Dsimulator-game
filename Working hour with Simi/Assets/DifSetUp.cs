using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifSetUp : MonoBehaviour
{
    public GameObject Difficulty;

    public ChoosenDifficulty ChoosenDifficulty;


    public int IntchoosenDif;
    public int IntChoosenDifMoveOp;

    // Start is called before the first frame update
    void Start()
    {
        Difficulty = GameObject.Find("ChoosenDif");
        ChoosenDifficulty = Difficulty.GetComponent<ChoosenDifficulty>();

        IntchoosenDif = ChoosenDifficulty.choosenDif;

        switch (IntchoosenDif) {
            case -1:
                IntChoosenDifMoveOp = 3; break;
            case 0:
                IntChoosenDifMoveOp = 0; break;
            default:
                IntChoosenDifMoveOp = 0; break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
