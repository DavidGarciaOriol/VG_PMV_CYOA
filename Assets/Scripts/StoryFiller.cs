using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryFiller
{
    public static GameManager.StoryNode RellenarHistoria()
    {

        // Cargar las imágenes.
        Sprite imagenPlaya = Resources.Load<Sprite>("Imagenes/playa");
        Sprite imagenBosque = Resources.Load<Sprite>("Imagenes/bosque");
        Sprite imagenColinas = Resources.Load<Sprite>("Imagenes/colinas");

        // Playa.
        GameManager.StoryNode nodo1 = new GameManager.StoryNode();
        nodo1.titulo = "La Playa";
        nodo1.historia = "La cálida brisa marina acaricia tu rostro mientras te encuentras en una playa desierta, donde las olas rompen suavemente contra la orilla. A tu alrededor, la arena brilla bajo el sol, y el sonido de los pájaros se mezcla con el murmullo del océano. Sin embargo, sientes un inexplicable tirón en tu pecho, una urgencia de explorar más allá de la costa. A lo lejos, el bosque oscuro y las colinas se dibujan en el horizonte, misteriosos y llenos de promesas.";
        nodo1.respuestas = new string[] { "Entrar al bosque oscuro.", "Ir hacia las colinas."};
        nodo1.siguienteNodo = new GameManager.StoryNode[nodo1.respuestas.Length];
        nodo1.imagenNodo = imagenPlaya;
        nodo1.esFinal = false;

        // Bosque Oscuro.
        GameManager.StoryNode nodo2 = new GameManager.StoryNode();
        nodo2.titulo = "Bosque Oscuro";
        nodo2.historia = "Al ingresar al bosque, la luz del sol se filtra débilmente a través de las copas de los árboles, creando sombras alargadas y misteriosas en el suelo cubierto de hojas. El aire es fresco y, aunque parece tranquilo, sientes que el bosque está vivo con secretos ocultos. Un susurro apenas audible parece guiarte, y la sensación de que algo te observa te pone alerta. Te preguntas si debes seguir adelante hacia el templo que viste en la distancia.";
        nodo2.respuestas = new string[] { "Avanzar al templo.", "Ir al santuario.", "Explorar las catacumbas." };
        nodo2.siguienteNodo = new GameManager.StoryNode[nodo2.respuestas.Length];
        nodo2.imagenNodo = imagenBosque;
        nodo2.esFinal = false;

        // Colinas.
        GameManager.StoryNode nodo3 = new GameManager.StoryNode();
        nodo3.titulo = "Colinas";
        nodo3.historia = "Las suaves colinas se extienden ante ti, cubiertas de una hierba verde brillante. A medida que caminas, te das cuenta de que las colinas son más que simples formaciones naturales; están llenas de vida. Mariposas de colores brillantes revolotean a tu alrededor, y el canto de los pájaros resuena en el aire. A lo lejos, una serie de cuevas oscurece el paisaje, y un impulso irresistible te invita a explorarlas.";
        nodo3.respuestas = new string[] { "Explorar las cuevas.", "Ir a las cataratas."};
        nodo3.siguienteNodo = new GameManager.StoryNode[nodo3.respuestas.Length];
        nodo3.imagenNodo = imagenColinas;
        nodo3.esFinal = false;

        // Santuario.
        GameManager.StoryNode nodo4 = new GameManager.StoryNode();
        nodo4.titulo = "Santuario";
        nodo4.historia = "Al llegar al santuario, sientes una energía poderosa que emana de sus antiguos muros de piedra. El lugar está adornado con símbolos de protección y antiguos rituales. En el altar, un amuleto resplandece con luz propia, prometiendo poder y sabiduría a quien lo posea. Sin embargo, el aire está impregnado de una advertencia: el poder siempre tiene un precio.\nAun así decides hacerte con el amuleto con la firme convicción de que te será útil en algún punto del camino.";
        nodo4.respuestas = new string[] { "Avanzar al templo.", "Rodear el templo."};
        nodo4.siguienteNodo = new GameManager.StoryNode[nodo4.respuestas.Length];
        nodo4.imagenNodo = null;
        nodo4.esFinal = false;

        // Templo.
        GameManager.StoryNode nodo5 = new GameManager.StoryNode();
        nodo5.titulo = "Templo";
        nodo5.historia = "El templo se erige majestuosamente ante ti, su arquitectura es impresionante, con columnas talladas que se elevan hacia el cielo. El interior está envuelto en un silencio reverente, y las sombras parecen danzar en las paredes. Sin embargo, la salida no está clara. Un sentido de urgencia crece dentro de ti al contemplar las salidas posibles, y sabes que cada elección tiene sus consecuencias.";
        nodo5.respuestas = new string[] { "Salida por los jardines.", "Salida principal.", "Salida trasera."};
        nodo5.siguienteNodo = new GameManager.StoryNode[nodo5.respuestas.Length];
        nodo5.imagenNodo = null;
        nodo5.esFinal = false;

        // Catacumbas.
        GameManager.StoryNode nodo6 = new GameManager.StoryNode();
        nodo6.titulo = "Catacumbas";
        nodo6.historia = "Las catacumbas son un laberinto de pasillos oscuros y húmedos. La luz de tu antorcha parpadea, proyectando sombras en las paredes cubiertas de musgo. El sonido del agua fluyendo se hace más fuerte a medida que te adentras, guiándote hacia un río subterráneo que parece ocultar secretos antiguos. El ambiente es opresivo, y un escalofrío recorre tu espalda al sentir que no estás solo.";
        nodo6.respuestas = new string[] { "Explorar el río subterráneo.", "Seguir hacia las cuevas." };
        nodo6.siguienteNodo = new GameManager.StoryNode[nodo6.respuestas.Length];
        nodo6.imagenNodo = null;
        nodo6.esFinal = false;

        // Cataratas mortales.
        GameManager.StoryNode nodo7 = new GameManager.StoryNode();
        nodo7.titulo = "Cataratas mortales";
        nodo7.historia = "Las cataratas son un espectáculo impresionante y aterrador. El agua cae con fuerza, creando un estruendo ensordecedor. Te sientes pequeño y vulnerable ante la magnitud de la naturaleza, pero algo te impulsa a acercarte. Tienes que decidir si cruzar el peligroso paso de las cataratas o retirarte antes de que sea demasiado tarde.";
        nodo7.respuestas = new string[] { "Cruzar las cataratas." };
        nodo7.respuestasFinales = new string[] { "Al intentar cruzar las traicioneras cataratas, el jugador pierde pie y es arrastrado por la fuerza del agua. Las rocas afiladas lo golpean mientras lucha por mantenerse a flote. Sin embargo, la corriente es implacable, y pronto desaparece en las profundidades, dejando solo un eco de su último grito." };
        nodo7.siguienteNodo = null;
        nodo7.imagenNodo = null;
        nodo7.esFinal = true;

        // Cuevas.
        GameManager.StoryNode nodo8 = new GameManager.StoryNode();
        nodo8.titulo = "Cuevas";
        nodo8.historia = "Las cuevas son frías y misteriosas, con estalactitas que cuelgan del techo como colmillos afilados. A medida que te adentras más, te das cuenta de que cada rincón tiene su propia historia. Ecos de pasos lejanos resuenan en el silencio, y sientes la presión de los secretos que guardan. Puedes regresar a las colinas o aventurarte más profundamente en el misterio.";
        nodo8.respuestas = new string[] { "Seguir explorando las cuevas.", "Buscar el sonido de las cataratas." };
        nodo8.siguienteNodo = new GameManager.StoryNode[nodo8.respuestas.Length];
        nodo8.imagenNodo = null;
        nodo8.esFinal = false;

        // Trampa mortal.
        GameManager.StoryNode nodo9 = new GameManager.StoryNode();
        nodo9.titulo = "Trampa mortal";
        nodo9.historia = "Has caído en una trampa mortal, un mecanismo antiguo que se ha activado. El tiempo es crucial mientras buscas una forma de escapar. El aire se vuelve pesado y la presión aumenta, lo que te lleva a actuar rápidamente. Tienes que decidir si luchar para desactivar la trampa o intentar escapar antes de que sea demasiado tarde.";
        nodo9.respuestas = new string[] { "Desactivar la trampa.", "Intentar escapar." };
        nodo9.respuestasFinales = new string[] 
            {
                "Tus intentos por desactivar la trampa han decidido tu destino, has acelerado el mecanísmo de la trampo... los muros comienzan a cerrarse mucho más rápidamente, tu muerte es inminente !!!",
                "Los muros comienzan a cerrarse lentamente, mientras el suelo cede bajo sus pies. A pesar de sus intentos por escapar, la trampa cumple su cometido. La oscuridad lo envuelve para siempre, y su aventura termina en el silencio de la tumba."
            };
        nodo9.siguienteNodo = null;
        nodo9.imagenNodo = null;
        nodo9.esFinal = true;

        // Embarcadero.
        GameManager.StoryNode nodo10 = new GameManager.StoryNode();
        nodo10.titulo = "Embarcadero";
        nodo10.historia = "Te encuentras en un embarcadero oculto, con un bote pequeño meciéndose suavemente en las aguas oscuras. La atmósfera está impregnada de un aire de aventura y peligro, y una decisión crucial debe tomarse. ¿Deberías embarcarte en el bote hacia la libertad o quedarte y descubrir más sobre este lugar misterioso?";
        nodo10.respuestas = new string[] { "Tomar el bote.", "Quedarse en el embarcadero." };
        nodo10.respuestasFinales = new string[] 
            {
                 "El jugador encuentra un viejo bote en el embarcadero secreto, su única oportunidad de huir. Con determinación, empuja el bote al agua y rema hacia la luz al final de la cueva. El viento fresco y la promesa de nuevas tierras llenan sus pulmones. Ha escapado, libre para continuar su travesía por el vasto mundo.",
                 "El jugador, intrigado por las sombras que rodean el embarcadero, decide quedarse. Tras inspeccionar el área, descubre un cofre antiguo oculto bajo una pila de piedras. Dentro, relucen joyas y monedas de oro de un reino olvidado. Su búsqueda ha terminado, pero su vida cambiará para siempre con esta fortuna inesperada."
            };
        nodo10.siguienteNodo = null;
        nodo10.imagenNodo = null;
        nodo10.esFinal = true;


        // Enlaces entre nodos.

        nodo1.siguienteNodo[0] = nodo2;
        nodo1.siguienteNodo[1] = nodo3;

        nodo2.siguienteNodo[0] = nodo5;
        nodo2.siguienteNodo[1] = nodo4;
        nodo2.siguienteNodo[2] = nodo6;

        nodo3.siguienteNodo[0] = nodo8;
        nodo3.siguienteNodo[1] = nodo7;

        nodo4.siguienteNodo[0] = nodo5;
        nodo4.siguienteNodo[1] = nodo9;

        nodo5.siguienteNodo[0] = nodo4;
        nodo5.siguienteNodo[1] = nodo9;
        nodo5.siguienteNodo[2] = nodo2;

        nodo6.siguienteNodo[0] = nodo10;
        nodo6.siguienteNodo[1] = nodo8;

        nodo8.siguienteNodo[0] = nodo3;
        nodo8.siguienteNodo[1] = nodo7;

        return nodo1;
    }
}
