using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private barraVida barraDeVida;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);
    }

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        barraDeVida.CambiarVidaActual(vida);
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Curar(float curacion)
    {
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
