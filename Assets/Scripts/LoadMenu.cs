using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    public void LoadLevelNumber(int _index)
    {
        SceneManager.LoadScene(_index);
    }
}
