using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{
    float _money;

    [Tooltip("The amount of money you have in a string format.")]
    [ContextMenuItem("Add Money", "DebugAddMoney")]
    public string moneyStr;

    [Tooltip("The text component to show money")]
    public TMP_Text moneyText;

    //Adds or subtracts money.
    public void MoneyManager(float additon)
    {
        _money += additon;
    }

    //Gives you the money value
    public float Bank()
    {
        return _money;
    }

    //Add money from the editor
    private void DebugAddMoney()
    {
        _money += 100000;
    }

    private void Update()
    {
        //Creates the string to always show how much money you have
        moneyStr = _money.ToString();

        //If money is over 1m, round to 2dp.
        if (_money / 1000000 >= 1)
        {
            var money = _money / 1000000;
            moneyStr = Math.Round(money, 2) + " m";
        }

        //Sets the text to how much money you have
        moneyText.text = moneyStr;
    }
}
