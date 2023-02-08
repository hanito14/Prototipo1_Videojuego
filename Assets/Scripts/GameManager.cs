using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int vidas = 3;
    public int score = 0;
    public TextMeshProUGUI vidaText;
    public TextMeshProUGUI scoreText;


    void Update()
    {
        vidaText.text = vidas.ToString();
        scoreText.text = score.ToString();

        if (vidas <= 0)
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
        CheckHighScore();
    }

    void CheckHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

}
