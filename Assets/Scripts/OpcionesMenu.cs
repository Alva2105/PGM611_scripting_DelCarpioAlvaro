using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcionesMenu : MonoBehaviour
{
    public void vamosAjugar()
    {
        SceneManager.LoadScene(1);
    }

    public void salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
