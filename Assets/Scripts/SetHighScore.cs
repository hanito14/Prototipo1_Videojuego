using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetHighScore : MonoBehaviour
{
    private TextMeshProUGUI highScore;

    void Start()
    {
        highScore = GetComponent<TextMeshProUGUI>();
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

}
