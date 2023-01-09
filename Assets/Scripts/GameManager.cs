using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Fundermentals")]
    public List<Reputation> Reputations = new List<Reputation>();
    [Tooltip("How many days till another election")]
    public int DaysPerElection;
    [Tooltip("How many hours in a day")]
    [Range(1, 24)]
    public int HoursPerDay;
    [Tooltip("The currency manager")]
    public Currency bank;
    [Tooltip("Election Manager")]
    public Election election;
    [Header("Values")]
    public int day = 1;
    public int hour, dayTillElection, electionDay;

    private void Start()
    {
        dayTillElection = DaysPerElection;
    }


    private void Update()
    {
        if (hour >= HoursPerDay)
        {
            hour = 0;
            day++;
            election.NewDay();
        }
        ElectionDay();
        FailGame();
    }

    private void ElectionDay()
    {
        electionDay = dayTillElection - day;
        if (electionDay <= 0)
        {
            Debug.Log("Election Day");
            election.ElectionDay();
            dayTillElection += DaysPerElection + 1;
            electionDay = DaysPerElection + 1;
            Time.timeScale = 0;
        }
    }

    private void FailGame()
    {
        foreach (Reputation rep in Reputations)
        {
            if (rep._reputation <= 0)
            {
                //Game End
                Debug.Log("End Game");
            }
        }
        if (bank.Bank() < 0)
        {
            //Ends Game
            Debug.Log("End Game");
        }
    }
}
