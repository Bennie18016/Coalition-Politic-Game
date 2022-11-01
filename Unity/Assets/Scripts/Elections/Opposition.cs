using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Opposition : MonoBehaviour
{
    public string Name;
    public int votePercentage, funding, initFunding;
    public TMP_Text tName, tVote, tFunding;
    public Slider sVote;

    private void Start()
    {
        tName.text = Name;
    }

    private void Update()
    {
        tVote.text = string.Format("{0}%", votePercentage);
        sVote.value = votePercentage;
        tFunding.text = funding.ToString();
    }
}
