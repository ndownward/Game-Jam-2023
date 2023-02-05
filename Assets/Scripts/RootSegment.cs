using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSegment : MonoBehaviour
{
    public GameObject connectedAbove, connectedBelow;
    // Start is called before the first frame update
    void Start()
    {
     /*   connectedAbove = GetComponent<HingeJoint2D>().connectedBody.GameObject;
        RootSegment aboveSegment = connectedAbove.GetComponent<RootSegment>();

        if(aboveSegment != null)
        {
            aboveSegment.connectedBelow = gameObject;
            float spriteButton = connectedAbove.GetComponent<SpriteRenderer>().bounds.size.y;
            GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(0, spriteBottom*-1);
        }
        else
        {
            GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(0,0);
        }
        */
    }

    // hinge joint 2d prefabs connected anchor set to 0,0,0 to make them drop. if we don't want that, modify that number

    // Update is called once per frame
    void Update()
    {
        
    }
}
