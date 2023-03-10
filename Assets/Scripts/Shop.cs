using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public TextMeshProUGUI coins;

    void Update()
    {
        coins.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    }

    
}
