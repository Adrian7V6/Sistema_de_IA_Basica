using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{
    public Transform punto_instancai;
    public GameObject bala;
    private float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo>=10)
        {
            Instantiate(bala, punto_instancai.position, Quaternion.identity);
            tiempo = 0;
        }
    }
}
