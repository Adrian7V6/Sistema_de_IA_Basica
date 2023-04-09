using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañadores : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    internal class CombateJugador
    {
        internal void TomarDaño(int v)
        {
            throw new NotImplementedException();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<CombateJugador>().TomarDaño(5);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }
}
