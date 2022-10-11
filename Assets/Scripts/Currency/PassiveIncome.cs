using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveIncome : MonoBehaviour
{
    [Tooltip("How many irl seconds = 1 hour. Get money every in game hour")]
    [Range(0, 60)]
    [SerializeField] int hour;
    float _second;

    [Tooltip("The currency manager")]
    public Currency bank;

    //[HideInInspector]
    public int moneyToAdd;

    private void Update()
    {
        //Every in game hour
        if(_second >= hour){
            //Add money from Currency script
            bank.MoneyManager(moneyToAdd);
            //Reset the time
            _second = 0;
        }
        //Every second, + 1 to seconds
        _second += 1 * Time.deltaTime;
    }
}
