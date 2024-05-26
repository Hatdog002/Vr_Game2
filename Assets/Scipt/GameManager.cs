using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public float WaveAt = 1;

    public bool StartGame = false;

    public GameObject Win;

    public GameObject Lose;

    public GameObject WaveUI;

    public GameObject HealthUI1;

    public DestroyGameObj destroy;

    public float baseHealth = 1000;
    public float currentHealth;

    public TextMeshProUGUI HealthUI;


    public float currentScore;
    public float HighScore;

    public Damage data;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        HighScore = data.CurrentDamageScoreTaken;
        currentHealth = baseHealth;
       
    }
    public void Update()
    {
        if(currentScore >= HighScore)
        {
            HighScore = currentScore;
            data.CurrentDamageScoreTaken = HighScore;
        }
        HealthUI.text = "Base Health:" + currentHealth.ToString();

        if (currentHealth <= 0)
        {
            NextWaveLose();
            Debug.Log("Lose");
        }

        if (WaveAt == 1)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave2", 1f);
            }
        }
        if (WaveAt == 2)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave3", 1f);
            }
        }
        if (WaveAt == 3)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave4", 1f);
            }
        }
        if (WaveAt == 4)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave5", 2f);
            }
        }
        if (WaveAt == 5)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave6", 2f);
            }
        }
        if (WaveAt == 6)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave7", 2f);
            }
        }
        if (WaveAt == 7)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave8", 2f);
            }
        }
        if (WaveAt == 8)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave9", 2f);
            }
        }
        if (WaveAt == 9)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWave10", 2f);
            }
        }
        if (WaveAt == 10)
        {
            if (Spawnner.instance.SpawnKill == 0)
            {
                Invoke("NextWaveWin", 2f);
            }
        }
    }

    public void NextWave2()
    {
        WaveAt = 2;
        Spawnner.instance.SpawnKill = 10;
        Spawnner.instance.spawnCount = 0 ;
    }
    public void NextWave3()
    {
        WaveAt = 3;
        Spawnner.instance.SpawnKill = 10;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave4()
    {
        WaveAt = 4;
        Spawnner.instance.SpawnKill = 15;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave5()
    {
        WaveAt = 5;
        Spawnner.instance.SpawnKill = 20;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave6()
    {
        WaveAt = 6;
        Spawnner.instance.SpawnKill = 25;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave7()
    {
        WaveAt = 7;
        Spawnner.instance.SpawnKill = 25;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave8()
    {
        WaveAt = 8;
        Spawnner.instance.SpawnKill = 30;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave9()
    {
        WaveAt = 9;
        Spawnner.instance.SpawnKill = 35;
        Spawnner.instance.spawnCount = 0;
    }
    public void NextWave10()
    {
        WaveAt = 10;
        Spawnner.instance.SpawnKill = 40;
        Spawnner.instance.spawnCount = 0;
    }

    public void NextWaveWin()
    {
        Lose.gameObject.SetActive(true);

        WaveUI.gameObject.SetActive(false);

        HealthUI1.gameObject.SetActive(false);

        StartGame = false;

        destroy.DestroyObjectsWithTag();
    }

    public void NextWaveLose()
    {
        Lose.gameObject.SetActive(true);

        WaveUI.gameObject.SetActive(false);

        HealthUI1.gameObject.SetActive(false);

        StartGame = false;

        destroy.DestroyObjectsWithTag();
    }

    public void Scenewin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit()
    {
        Application.Quit();
    }
}
