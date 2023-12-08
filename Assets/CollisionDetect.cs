using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnCollisionEnter(Collision collider)
    {
        //if the name = sphere
        if(collider.gameObject.tag =="ball")
        {
            Destroy(this.gameObject);
        }

        Debug.Log(collider.gameObject.name)
    }
}
