using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerMenu : MonoBehaviour
{
    public GameObject mainGame, election, stats;

    private void Start()
    {
        election.SetActive(false);
        stats.SetActive(false);
    }
    public void MainGame()
    {
        mainGame.SetActive(true);
        election.SetActive(false);
        stats.SetActive(false);
    }

    public void Election()
    {
        mainGame.SetActive(false);
        election.SetActive(true);
        stats.SetActive(false);
    }

    public void Stats()
    {
        mainGame.SetActive(false);
        election.SetActive(false);
        stats.SetActive(true);
    }
}
