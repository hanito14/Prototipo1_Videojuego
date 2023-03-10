using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHolder : MonoBehaviour
{

    [Header("Navigation Buttons")]
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;

    [Header("Play/Buy Buttons")]
    [SerializeField] private Button save;
    [SerializeField] private Button buy;
    [SerializeField] private TextMeshProUGUI priceText;

    [Header("Character Attributes")]
    [SerializeField] private int[] chPrices;
    private int currentCH = 0;

    public int coins = 0;

    void Start()
    {
        currentCH = PlayerPrefs.GetInt("Character", 0);
        SelectCharacter(currentCH);
        coins = PlayerPrefs.GetInt("Coins", 0);
    }

    private void SelectCharacter(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.SetActive(i == _index);

        UpdateUI();
    }

    private void UpdateUI()
    {
        //If current car unlocked show the play button
        if (SaveManager.instance.chUnlocked[currentCH])
        {
            save.gameObject.SetActive(true);
            buy.gameObject.SetActive(false);
        }
        //If not show the buy button and set the price
        else
        {
            save.gameObject.SetActive(false);
            buy.gameObject.SetActive(true);
            priceText.text = "$" + chPrices[currentCH];
        }
    }

    private void Update()
    {
        //Check if we have enough money
        if (buy.gameObject.activeInHierarchy)
            buy.interactable = (PlayerPrefs.GetInt("Coins", 0) >= chPrices[currentCH]);
    }

    public void ChangeCharacter(int _change)
    {
        currentCH += _change;

        if (currentCH > transform.childCount - 1)
            currentCH = 0;
        else if (currentCH < 0)
            currentCH = transform.childCount - 1;

        SaveManager.instance.currentCH = currentCH;
        SaveManager.instance.Save();
        SelectCharacter(currentCH);
    }
    public void BuyCharacter()
    {
        PlayerPrefs.SetInt("Coins", coins -= chPrices[currentCH]);
        SaveManager.instance.chUnlocked[currentCH] = true;
        SaveManager.instance.Save();
        UpdateUI();
    }

    public void SaveCharacter()
    {
        PlayerPrefs.SetInt("Character", currentCH);
    }
}
