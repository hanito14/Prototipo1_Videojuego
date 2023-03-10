using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int vidas = 3;
    public int score = 0;

    public int coins = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinsText;

    public Image[] healthImages;
    public Sprite healthSprite;

    public GameObject deathScreen;
    public GameObject draggin;

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
    }

    
    void Update()
    {

        scoreText.text = score.ToString();
        coinsText.text = coins.ToString();

        if(vidas == 3)
        {
            coins = (int)(score / 4) + PlayerPrefs.GetInt("Coins", 0);
        }

        if (vidas == 2)
        {
            coins = (int)(score / 4) + PlayerPrefs.GetInt("Coins", 0);
            healthImages[0].sprite= healthSprite;
        }

        if (vidas == 1)
        {
            coins = (int)(score / 4) + PlayerPrefs.GetInt("Coins", 0);
            healthImages[1].sprite = healthSprite;
        }

        if (vidas <= 0)
        {
            healthImages[2].sprite = healthSprite;
            PlayerPrefs.SetInt("Coins", coins);
            deathScreen.SetActive(true);
            AudioListener.pause = true;
            Time.timeScale = 0;
            draggin.SetActive(false);
            CheckHighScore();
        }
        
        
    }

    void CheckHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
