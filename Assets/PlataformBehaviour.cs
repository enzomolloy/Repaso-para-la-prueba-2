using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformBehaviour : MonoBehaviour
{
    public float speed;
    public bool toRight;

    public GameObject baseDerecha;
    public GameObject baseIzq;

    public GameObject prefab1;
    public GameObject prefab2;

    int yOffset;

    void Start()
    {
        toRight = true;
        yOffset = 1;
    }

    
    void Update()
    {
        if (toRight == true)  
        {
            transform.position += new Vector3(speed, 0, 0); 
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0); 
        }

        if (transform.position.x > baseDerecha.transform.position.x - 1)  
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDerecha.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }
        if (transform.position.x < baseIzq.transform.position.x + 1)  
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseIzq.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }

    }
}
