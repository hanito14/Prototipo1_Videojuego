using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void ComenzarJuego()
    {
        SceneManager.LoadScene("Juego");
        AudioListener.pause = false;
    }

    public void Pesonalizar()
    {
        SceneManager.LoadScene("Personalizar");
    }

    public void Configuracion()
    {
        SceneManager.LoadScene("Configuración");
    }

    public void ComoJugar()
    {
        SceneManager.LoadScene("ComoJugar");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
