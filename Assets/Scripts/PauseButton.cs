using Unity.VisualScripting;
using UnityEngine;

public class PauseButton : MonoBehaviour
{

    float previousTimeScale = 1;
    public static bool isPaused;
    public GameObject pauseScreen;

    public GameObject draggin;

    void Start()
    {
        isPaused= false;
        Time.timeScale = 1f;
    }

    public void TogglePause()
    {
        if (Time.timeScale > 0)
        {
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0;
            AudioListener.pause = true;
            isPaused = true;
            pauseScreen.SetActive(true);
            draggin.SetActive(false);
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = previousTimeScale;
            AudioListener.pause = false;
            isPaused = false;
            pauseScreen.SetActive(false);
            draggin.SetActive(true);
        }
    }

    void OnApplicationPause()
    {
        isPaused= true;
        Time.timeScale = 0f;
    }
}
