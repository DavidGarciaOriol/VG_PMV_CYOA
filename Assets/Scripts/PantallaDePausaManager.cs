using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaDePausaManager : MonoBehaviour
{

    public static void ReiniciarPartida()
    {
        SceneManager.UnloadSceneAsync("PlayScene");
        Debug.Log("Reiniciando partida...");
        SceneManager.LoadScene("PlayScene");
    }

    public static void MenuPrincipal()
    {
        Debug.Log("Volviendo al menú principal...");
        SceneManager.LoadScene("MainScene");
    }
}
