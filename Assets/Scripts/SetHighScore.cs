using TMPro;
using UnityEngine;

public class SetHighScore : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI coins;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        coins.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    }

}
