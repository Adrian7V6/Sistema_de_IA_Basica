using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class controlador : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    [SerializeField] private Transform[] puntos;
    [SerializeField] private GameObject[] enemigos;
    [SerializeField] private float tiempoEnemigos;
    private float tiempoSiguienteEnemigo;


    // Start is called before the first frame update
    void Start()
    {
        maxX = puntos.Max(puntos => puntos.position.x);
        minX = puntos.Min(puntos => puntos.position.x);
        maxY = puntos.Max(puntos => puntos.position.y);
        minY = puntos.Min(puntos => puntos.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        tiempoSiguienteEnemigo += Time.deltaTime;

        if(tiempoSiguienteEnemigo >= tiempoEnemigos)
        {
            tiempoSiguienteEnemigo = 0;
            CrearEnemigo();
        }
    }

    private void CrearEnemigo()
    {
        int numeroEnemigo = Random.Range(0, enemigos.Length);
        Vector2 posicionAleatoria = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        Instantiate(enemigos[numeroEnemigo], posicionAleatoria, Quaternion.identity);


    }
}
