using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LegislationManager : MonoBehaviour
{
    [Header("Legislation")]
    public string legislation;
    public int vPublic, opposition, military, WHS;
    public bool Legislation;
    public LegislationList LL;
    public TMP_Text LegislationText;
    public GameObject LegislationCanvas;
    public Reputation rPublic, rOpposition, rMilitary, rWHS;

    private void Update()
    {
        LegislationText.text = legislation;
    }
    public void NewLegislation()
    {
        Legislation = true;
        LegislationCanvas.SetActive(true);
        legislation = "New Law Idea";

        var num = Random.Range(0, 4) + 1;

        switch (num)
        {
            case 1:
                //Public likes
                vPublic = 25;
                opposition = Random.Range(-21, 10) + 1;
                military = Random.Range(-11, 15) + 1;
                WHS = Random.Range(0, 20) + 1;
                legislation = string.Format("The public want: \n{0}", LL.Public[Random.Range(0, LL.Public.Count)]);
                break;
            case 2:
                //Opposition Likes
                opposition = 25;
                vPublic = Random.Range(-21, 10) + 1;
                military = Random.Range(0, 20) + 1;
                WHS = Random.Range(-11, 15) + 1;
                legislation = string.Format("The Opposition want: \n{0}", LL.Opposition[Random.Range(0, LL.Opposition.Count)]);
                break;
            case 3:
                //Military Likes
                military = 25;
                opposition = WHS = Random.Range(0, 20) + 1;
                vPublic = Random.Range(-21, 10) + 1;
                WHS = Random.Range(-11, 15) + 1;
                legislation = string.Format("The Military want: \n{0}", LL.Military[Random.Range(0, LL.Military.Count)]);
                break;
            case 4:
                //WHS Likes
                WHS = 25;
                opposition = Random.Range(-11, 15) + 1;
                military = Random.Range(-21, 10) + 1;
                vPublic = Random.Range(0, 20) + 1;
                legislation = string.Format("The World Health Service    want: \n{0}", LL.WHS[Random.Range(0, LL.WHS.Count)]);
                break;
        }
    }

    public void Accept()
    {
        rPublic.ReputationManager(vPublic);
        rOpposition.ReputationManager(opposition);
        rMilitary.ReputationManager(military);
        rWHS.ReputationManager(WHS);

        Legislation = false;
        LegislationCanvas.SetActive(false);
    }

    public void Decline()
    {
        rPublic.ReputationManager(-vPublic);
        rOpposition.ReputationManager(-opposition);
        rMilitary.ReputationManager(-military);
        rWHS.ReputationManager(-WHS);

        Legislation = false;
        LegislationCanvas.SetActive(false);
    }
}