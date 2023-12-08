using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
       // Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          Destroy(this.gameObject);   
        }
    }

//     void OnMouseDown()
//     {
//        Destroy(this.gameObject);
//     }
 }
