using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PassiveIncome : MonoBehaviour
{
    [Header("Fundermentals")]
    [Tooltip("How many irl seconds = 1 hour. Get money every in game hour")]
    [Range(0, 60)]
    [SerializeField] int hour;
    float _second;
    [Tooltip("The currency manager")]
    public Currency bank;
    [Tooltip("ALl of the other peoples reputation script")]
    public List<Reputation> reputation = new List<Reputation>();
    [Tooltip("The Legislation Manager")]
    public LegislationManager LM;
    [Tooltip("The manager of the game!")]
    public GameManager GM;

    [Header("Debug")]
    public TMP_Text timer;

    private int moneyToAdd;

    private void Update()
    {
        //Every in game hour
        if (_second >= hour)
        {
            Calculate();
            Hour();
            repChange();
        }

        if (!LM.Legislation)
        {
            //Every real life second, + 1 to seconds
            _second += 1 * Time.deltaTime;
        }

        //DEBUG
        //Shows us how long until next income in game as an int
        timer.text = (hour - (int)_second).ToString();
    }

    private void Calculate()
    {
        //For each of the reputation scripts
        foreach (Reputation item in reputation)
        {
            //Add their money to give to the money we recieve
            moneyToAdd += item.toGive;
        }
    }

    private void repChange()
    {
        //For each of the reputation scripts
        foreach (Reputation item in reputation)
        {
            //Change their reputation randomly
            item.ReputationManager(Random.Range(-21, 20) + 1);
        }
    }

    private void Hour()
    {
        //Adds one to the games hour
        GM.hour++;
        //Starts a new Legislation
        LM.NewLegislation();
        //Add money from Currency script
        bank.MoneyManager(moneyToAdd);
        //Reset the time
        _second = 0;
        //Reset money to give
        moneyToAdd = 0;
    }
}
