using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Opposition : MonoBehaviour
{
    [Header("Opposition Settings")]
    [Tooltip("The name of the opposition")]
    public string Name;
    [Tooltip("The int values of their percentage, funding and inital funding. ")]
    public int votePercentage, funding, initFunding;
    [Tooltip("Text components for their: name, vote% and funding")]
    public TMP_Text tName, tVote, tFunding;
    [Tooltip("Their slider that shows them their vote percentage")]
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
