using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
