using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public class StoryNode
    {
        public string titulo;
        public string historia;
        public string[] respuestas;
        public StoryNode[] siguienteNodo; // Debe tener la misma longitud que respuestas[].
        public string[] respuestasFinales; // Debe tener la misma longitud que respuestas[].
        public bool esFinal;
    }

    // Nodo Actual
    private StoryNode nodoActual;

    // Prefab de botones de acción.
    public GameObject botonPrefab;

    // Referencia al exto de la historia - HUD.
    public GameObject textoHistoria;

    // Referencia al panel de botones - HUD.
    public GameObject panelBotones;

    // Inicializa el juego.

    private void Start()
    {
        nodoActual = StoryFiller.RellenarHistoria();
        MostrarNodo(nodoActual);
    }

    private void MostrarNodo(StoryNode nodo)
    {
        // Escribir en el panel de la historia el texto del nodo actual.
        textoHistoria.GetComponent<TMPro.TextMeshProUGUI>().text = nodo.historia;

        // Eliminar botones ya existentes.
        BorrarBotones();

        // Mostrar cada una de las opciones del nodo actual.
        int contador = 0;
        foreach (string respuesta in nodo.respuestas)
        {
            Debug.Log(respuesta);

            GameObject boton = Instantiate(botonPrefab, panelBotones.transform);
            boton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = respuesta;

            // Asignar manejadores de eventos de los botones.
            boton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => AlResponder(respuesta));

            // Calcular el ancho para cada botón.
            float ancho = panelBotones.GetComponent<RectTransform>().rect.width / nodo.respuestas.Length;
            float alto = panelBotones.GetComponent<RectTransform>().rect.height;
            boton.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho * 0.8f, alto / 2);

            // Posicionamiento de los botones.
            boton.GetComponent<RectTransform>().anchoredPosition = new Vector2(ancho * (contador + 0.5f), alto * 0.5f);
            contador++;
        }
    }

    // Método que se ejecuta al pulsar un botón de respuesta.
    private void AlResponder(string respuesta)
    {
        int indice = System.Array.IndexOf(nodoActual.respuestas, respuesta);

        if (nodoActual.esFinal)
        {
            textoHistoria.GetComponent<TMPro.TextMeshProUGUI>().text += "\n\nMUERTO";
            AgregarBotonesSalirRestart();
        }
        else
        {
            nodoActual = nodoActual.siguienteNodo[indice];
            MostrarNodo(nodoActual);
        }
    }

    // Método para crear los botones de salir y reiniciar.
    private void AgregarBotonesSalirRestart()
    {
        BorrarBotones();

        // BOTON SALIR
        GameObject botonSalir = Instantiate(botonPrefab, panelBotones.transform);
        botonSalir.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Salir";

        // Asignar manejadores de eventos de los botones.
        botonSalir.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => MenuManager.MenuPrincipal());

        // Calcular el ancho para cada botón.
        float ancho = panelBotones.GetComponent<RectTransform>().rect.width / 2;
        float alto = panelBotones.GetComponent<RectTransform>().rect.height;
        botonSalir.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho * 0.8f, alto / 2);

        // Posicionamiento de los botones.
        botonSalir.GetComponent<RectTransform>().anchoredPosition = new Vector2(ancho * 0.5f, alto * 0.5f);

        // BOTON RESTART
        GameObject botonRestart = Instantiate(botonPrefab, panelBotones.transform);
        botonRestart.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Salir";

        // Asignar manejadores de eventos de los botones.
        botonRestart.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => MenuManager.IniciarPartida());

        // Calcular el ancho para cada botón.
        botonRestart.GetComponent<RectTransform>().sizeDelta = new Vector2(ancho * 0.8f, alto / 2);

        // Posicionamiento de los botones.
        botonRestart.GetComponent<RectTransform>().anchoredPosition = new Vector2(ancho * (1 + 0.5f), alto * 0.5f);
    }

    // Método que borra los botones.
    private void BorrarBotones()
    {
        foreach (Transform botonHijo in panelBotones.transform)
        {
            if (botonHijo.GetComponent<UnityEngine.UI.Button>() != null)
            {
                Destroy(botonHijo.gameObject);
            }
        }
    }
}
