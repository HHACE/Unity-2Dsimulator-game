using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSus : MonoBehaviour
{
    public GameObject stream;
    public StreamRunTime Stream;

    public SpriteRenderer HiTextArea;

    public GameObject TextArea;

    public Sprite TextHi;
    public Sprite TextHello;
    // Start is called before the first frame update
    void Start()
    {
        Stream = stream.GetComponent<StreamRunTime>();
        HiTextArea = TextArea.GetComponent<SpriteRenderer>();

        HiTextArea.sprite = TextHi;
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void AddBatterySus()
    {
        if (Stream.BatterySus > 0)
        {
            Stream.BatterySus -= 1;
        }

        if (HiTextArea.sprite == TextHi)
        {
            HiTextArea.sprite = TextHello;
        }
        else {
            HiTextArea.sprite = TextHi;
        }

    }
}
