using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public Material flick;
    float timer;
    float timerToGet = 0.5f;
    int timerToGet2 = 1;
    bool green;
    public GameObject light;

    // Update is called once per frame
    void Update()
    {

        if (timer > timerToGet2)
        {
            flick.color = new Color32(70, 70, 70, 255);
            timer = 0;
            light.SetActive(false);

        }

         else if (timer > timerToGet)
        {
            flick.color = Color.green;
            light.SetActive(true);

        }

        timer += 1 * Time.deltaTime;
    }
}
