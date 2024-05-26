using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayUi : MonoBehaviour
{
    public TextMeshProUGUI txtcurrentScore;
    public TextMeshProUGUI txtHighScore;

    public TextMeshProUGUI txtIngameCurrentScore;

    public void Start()
    {
       
    }

    public void Update()
    {
        txtHighScore.text = GameManager.instance.HighScore.ToString();
        Debug.Log(GameManager.instance.HighScore);
        txtcurrentScore.text = GameManager.instance.currentScore.ToString();
        txtIngameCurrentScore.text = "Score: " + GameManager.instance.currentScore.ToString();
    }
}
