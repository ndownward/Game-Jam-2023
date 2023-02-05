using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    public Rigidbody2D hook;
   // public GameObject[] prefabRootSegs; // middle seg = 0, final seg = 1 


    // Start is called before the first frame update
    void Start()
    {
       // GenerateRope();
    }


    void GenerateRope()
    {
        /*
        Rigidbody2D prevBod = hook;
        GameObject middleSeg = Instantiate(prefabRootSegs[0]);
        middleSeg.transform.parent = transform;
        middleSeg.transform.position = transform.position;
        HingeJoint2D hj = middleseg.GetComponent;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
