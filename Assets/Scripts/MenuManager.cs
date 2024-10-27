using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static void Salir()
    {
        Debug.Log("Cerrando Aplicación...");
        Application.Quit();
    }

    public static void IniciarPartida()
    {
        Debug.Log("Iniciando partida...");
        SceneManager.LoadScene("PlayScene");
    }

    public static void MenuPrincipal()
    {
        Debug.Log("Volviendo al menú principal...");
        SceneManager.LoadScene("MainScene");
    }
}
