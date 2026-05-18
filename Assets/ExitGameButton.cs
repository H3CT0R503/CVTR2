using UnityEngine;

public class ExitGameButton : MonoBehaviour
{
    public void SalirDelJuego()
    {
        Debug.Log("Saliendo del juego...");
        
        // Si está en el Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // Si es build final
        Application.Quit();
        #endif
    }
}
