using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    [Header("Fundermentals")]
    public GameManager GM;
    public TMP_Text Day, Election, NextDay;
    private void Update()
    {
        Day.text = string.Format("Day {0}", GM.day);
        Election.text = string.Format("Days till Election: {0}", GM.electionDay);
        NextDay.text = string.Format("{0} hours till next day", GM.HoursPerDay - GM.hour);
    }
}