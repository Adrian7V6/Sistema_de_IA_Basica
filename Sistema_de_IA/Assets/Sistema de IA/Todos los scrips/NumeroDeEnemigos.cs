using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumeroDeEnemigos : MonoBehaviour
{
    public string tagToCount = "NumeroDeEnemigos"; // Etiqueta a contar
    public Text counterText; // Texto donde se mostrará el contador


    // Update is called once per frame
    void Update()
    {
        // Obtener la cantidad de objetos con la etiqueta especificada
        int count = GameObject.FindGameObjectsWithTag(tagToCount).Length;

        // Actualizar el texto del contador
        counterText.text = "El numero de objetos generados es: " + count.ToString();
    }
}
