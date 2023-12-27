using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ShowSongTitile : MonoBehaviour
{
    public float TransitionValue;

    public float TempY;
    public float TempZ;

    public bool Direction;

    // Start is called before the first frame update
    void Start()
    {
        TransitionValue = 8.0f;
        UpdatePosition();
        Direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Direction == true)
        {

            if (TransitionValue > 0f)
            {

                TransitionValue -= Time.deltaTime * 10;
                UpdatePosition();
            }
            else
            {
                Invoke("CloseSongTitle", 3f);
                TransitionValue = -0.243519f;
                UpdatePosition();
            }
        }
        else if (Direction == false)
        {

            if (TransitionValue < 8.0f)
            {

                TransitionValue += Time.deltaTime * 10;
                UpdatePosition();
            }
            else
            {

                gameObject.SetActive(false);
                TransitionValue = 8.0f;
                UpdatePosition();
            }
        }
    }

    public void CloseSongTitle() {
        Direction = false;   
    }

    public void UpdatePosition()
    {
        gameObject.GetComponent<RectTransform>().position = new Vector3(TransitionValue,(float) TempY, (float)TempZ);
    }
}
