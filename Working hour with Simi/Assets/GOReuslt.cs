using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOReuslt : MonoBehaviour
{
    public GameObject Clock;
    public GameObject Music;
    public GameObject Art;

    public Sprite ArtTime;
    public Sprite ArtWife;
    public Sprite ArtChat;

    // Start is called before the first frame update
    void Start()
    {
        Clock = GameObject.Find("ClockFrame");
        Music = GameObject.Find("Music");
        Destroy(Music);
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (Clock.GetComponent<ClockTimer>().GOState) {
            case 1:
                gameObject.GetComponent<Text>().text = "You ran out of time :(((";
                Art.GetComponent<SpriteRenderer>().sprite = ArtTime;
                break;
            case 2:
                gameObject.GetComponent<Text>().text = "Give your wife some love!";
                Art.GetComponent<SpriteRenderer>().sprite = ArtWife;
                break;
            case 3:
                gameObject.GetComponent<Text>().text = "Youtube didn't like what chat did...";
                Art.GetComponent<SpriteRenderer>().sprite = ArtChat;
                break;
            default:
                gameObject.GetComponent<Text>().text = "Too much ending happen";
                Art.GetComponent<SpriteRenderer>().sprite = ArtTime;
                break;
        }
        Clock.SetActive(false);

    }
}
