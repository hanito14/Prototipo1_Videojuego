using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void ComenzarJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Pesonalizar()
    {
        SceneManager.LoadScene("Personalizar");
    }
}
