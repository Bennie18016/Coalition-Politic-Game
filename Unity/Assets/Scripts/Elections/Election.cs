using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class Election : MonoBehaviour
{
    public List<Opposition> Opp = new List<Opposition>();
    public PlayerElection player;
    public Currency bank;
    public int one, two, three;
    public Slider electionBudget;
    public TMP_Text moneyText;

    #region Start   
    private void Start()
    {
        while (one + two + three != 100)
        {
            one = Random.Range(0, 100) + 1;
            two = Random.Range(0, 100) + 1;
            three = Random.Range(0, 100) + 1;
        }
        foreach (Opposition op in Opp)
        {
            int funding = Random.Range(10000, 100000);
            op.initFunding = funding;
            op.funding = funding;
        }
        int pFunding = Random.Range(10000, 100000);
        player.initFunding = pFunding;
        player.funding = pFunding;
        for (int i = 0; i != 3; i++)
        {
            if (Opp[0].initFunding > Opp[1].initFunding)
            {
                if (Opp[0].initFunding > player.initFunding)
                {
                    if (one > two)
                    {
                        if (one > three)
                        {
                            Opp[0].votePercentage = one;
                            one = 0;
                        }
                        else
                        {
                            Opp[0].votePercentage = three;
                            three = 0;
                        }
                    }
                    else if (two > three)
                    {
                        Opp[0].votePercentage = two;
                        two = 0;
                    }
                    else
                    {
                        Opp[0].votePercentage = three;
                        three = 0;
                    }
                    Opp[0].initFunding = 0;
                }
                else
                {
                    if (one > two)
                    {
                        if (one > three)
                        {
                            player.votePercentage = one;
                            one = 0;
                        }
                        else
                        {
                            player.votePercentage = three;
                            three = 0;
                        }
                    }
                    else if (two > three)
                    {
                        player.votePercentage = two;
                        two = 0;
                    }
                    else
                    {
                        player.votePercentage = three;
                        three = 0;
                    }
                    player.initFunding = 0;
                }
            }
            else if (Opp[1].initFunding > player.initFunding)
            {
                if (one > two)
                {
                    if (one > three)
                    {
                        Opp[1].votePercentage = one;
                        one = 0;
                    }
                    else
                    {
                        Opp[1].votePercentage = three;
                        three = 0;
                    }
                }
                else if (two > three)
                {
                    Opp[1].votePercentage = two;
                    two = 0;
                }
                else
                {
                    Opp[1].votePercentage = three;
                    three = 0;
                }
                Opp[1].initFunding = 0;
            }
            else
            {
                if (one > two)
                {
                    if (one > three)
                    {
                        player.votePercentage = one;
                        one = 0;
                    }
                    else
                    {
                        player.votePercentage = three;
                        three = 0;
                    }
                }
                else if (two > three)
                {
                    player.votePercentage = two;
                    two = 0;
                }
                else
                {
                    player.votePercentage = three;
                    three = 0;
                }
                player.initFunding = 0;
            }
        }
    }

    #endregion

    #region Update
    private void Update()
    {
        electionBudget.maxValue = (int)bank.Bank();
        moneyText.text = electionBudget.value.ToString();
    }
    #endregion

    #region NewDay
    public void NewDay()
    {
        Opp[0].initFunding = Opp[0].funding;
        Opp[1].initFunding = Opp[1].funding;
        player.initFunding = player.funding;

        while (one + two + three != 100)
        {
            one = Random.Range(0, 100) + 1;
            two = Random.Range(0, 100) + 1;
            three = Random.Range(0, 100) + 1;
        }

        for (int i = 0; i != 3; i++)
        {
            if (Opp[0].initFunding > Opp[1].initFunding)
            {
                if (Opp[0].initFunding > player.initFunding)
                {
                    if (one > two)
                    {
                        if (one > three)
                        {
                            Opp[0].votePercentage = one;
                            one = 0;
                        }
                        else
                        {
                            Opp[0].votePercentage = three;
                            three = 0;
                        }
                    }
                    else if (two > three)
                    {
                        Opp[0].votePercentage = two;
                        two = 0;
                    }
                    else
                    {
                        Opp[0].votePercentage = three;
                        three = 0;
                    }
                    Opp[0].initFunding = 0;
                }
                else
                {
                    if (one > two)
                    {
                        if (one > three)
                        {
                            player.votePercentage = one;
                            one = 0;
                        }
                        else
                        {
                            player.votePercentage = three;
                            three = 0;
                        }
                    }
                    else if (two > three)
                    {
                        player.votePercentage = two;
                        two = 0;
                    }
                    else
                    {
                        player.votePercentage = three;
                        three = 0;
                    }
                    player.initFunding = 0;
                }
            }
            else if (Opp[1].initFunding > player.initFunding)
            {
                if (one > two)
                {
                    if (one > three)
                    {
                        Opp[1].votePercentage = one;
                        one = 0;
                    }
                    else
                    {
                        Opp[1].votePercentage = three;
                        three = 0;
                    }
                }
                else if (two > three)
                {
                    Opp[1].votePercentage = two;
                    two = 0;
                }
                else
                {
                    Opp[1].votePercentage = three;
                    three = 0;
                }
                Opp[1].initFunding = 0;
            }
            else
            {
                if (one > two)
                {
                    if (one > three)
                    {
                        player.votePercentage = one;
                        one = 0;
                    }
                    else
                    {
                        player.votePercentage = three;
                        three = 0;
                    }
                }
                else if (two > three)
                {
                    player.votePercentage = two;
                    two = 0;
                }
                else
                {
                    player.votePercentage = three;
                    three = 0;
                }
                player.initFunding = 0;
            }
        }
    }
    #endregion

    #region ElectionDay
    public void ElectionDay()
    {
        if (player.votePercentage! > Opp[0].votePercentage && player.votePercentage! > Opp[1].votePercentage)
        {
            Debug.Log("End Game");
        }
    }
    #endregion

    #region AddMoney
    public void AddMoneyToFunding()
    {
        player.funding += (int)electionBudget.value;
        bank.MoneyManager(-electionBudget.value);
    }
    #endregion
}