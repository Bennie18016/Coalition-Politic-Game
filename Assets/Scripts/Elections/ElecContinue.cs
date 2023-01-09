using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecContinue : MonoBehaviour
{
    public GameManager gm;
    public GameObject UI;

    public void Continue()
    {
        gm.day++;
        Time.timeScale = 1;
        UI.SetActive(false);
    }
}
