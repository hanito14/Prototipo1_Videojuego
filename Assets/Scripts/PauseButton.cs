using UnityEngine;

public class PauseButton : MonoBehaviour
{
    bool isPaused;

    void Start()
    {
        isPaused= false;
        Time.timeScale = 1;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        
        if (!isPaused)
        {
            Time.timeScale = 1;
        }
    }

    void OnApplicationPause()
    {
        isPaused= true;
        Time.timeScale = 0;
    }
}
