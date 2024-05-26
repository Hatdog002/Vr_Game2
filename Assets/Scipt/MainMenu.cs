using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameManager manager;

    public GameObject HealthUI;

    public GameObject ToDestroy;

    public GameObject WaveUi;
    public void Play()
    {
        manager.StartGame = true;
        HealthUI.gameObject.SetActive(true);
        ToDestroy.gameObject.SetActive(false);
        WaveUi.gameObject.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }
}
