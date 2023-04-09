using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class posicionP : MonoBehaviour
{
    public TMP_Text posicionText;
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posicionText.text = "Posicion del jugador: " + targetObject.transform.position.ToString();

        
    }
}
