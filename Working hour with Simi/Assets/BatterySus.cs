using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySus : MonoBehaviour
{
    public GameObject stream;
    public StreamRunTime Stream;

    private SpriteRenderer spriteRenderer;

    public Sprite Battery0;
    public Sprite Battery1;
    public Sprite Battery2;
    public Sprite Battery3;
    public Sprite Battery4;


    // Start is called before the first frame update
    void Start()
    {
        Stream = stream.GetComponent<StreamRunTime>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (Stream.BatterySus)
        {
            case 0:
                spriteRenderer.sprite = Battery0;
                break;
            case 1:
                spriteRenderer.sprite = Battery1;
                break;
            case 2:
                spriteRenderer.sprite = Battery2;
                break;
            case 3:
                spriteRenderer.sprite = Battery3;
                break;
            case 4:
                spriteRenderer.sprite = Battery4;
                break;

        }


    }
}

