using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patullador : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float distanciaMinima;

    private int numeroAleatorio;
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        numeroAleatorio = Random.Range(0, puntosMovimiento.Length);
        sprite = GetComponent<SpriteRenderer>();
        Girar();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[numeroAleatorio].position, velocidadMovimiento * Time.deltaTime);
        if(Vector2.Distance(transform.position, puntosMovimiento[numeroAleatorio].position) < distanciaMinima)
        {
            numeroAleatorio = Random.Range(0, puntosMovimiento.Length);
            Girar();
        }


    }

    private void Girar()
    {
        if (transform.position.x < puntosMovimiento[numeroAleatorio].position.x)
        {
            sprite.flipX = true;

        }
        else
        {
            sprite.flipX = false;
        }
    }
}
