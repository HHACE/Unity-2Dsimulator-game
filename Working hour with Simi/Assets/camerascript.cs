using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public SpriteRenderer rink;

    // Start is called before the first frame update
    void Start()
    {
        /*        float screenRatio = (float)Screen.width / (float)Screen.height;
                float targetRatio = rink.bounds.size.x / rink.bounds.size.x;

                if (targetRatio < screenRatio)
                {
                    Camera.main.orthographicSize = rink.bounds.size.y / 2;
                }
                else {
                    float differenveInSize = targetRatio / screenRatio;
                    Camera.main.orthographicSize = rink.bounds.size.y / 2 * differenveInSize;
                }*/

        float orthoSize = rink.bounds.size.x * Screen.height / Screen.width * 0.5f;

        Camera.main.orthographicSize = orthoSize;
    }


}
