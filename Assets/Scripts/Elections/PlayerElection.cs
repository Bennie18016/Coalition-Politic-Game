using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerElection : MonoBehaviour
{
    public int votePercentage, funding, initFunding;
    public TMP_Text tVote, tFunding;
    public Slider sVote;

    private void Start()
    {
        funding = initFunding;
    }

    private void Update()
    {
        tVote.text = string.Format("{0}%", votePercentage);
        sVote.value = votePercentage;
        tFunding.text = funding.ToString();
    }
}