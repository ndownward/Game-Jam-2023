using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoot : MonoBehaviour
{

    public Transform target;
    private bool isMouseDragging;
    private Vector3 mousePos;
    private Vector3 segmentPos;
    private float angle;
    private Vector3 initialMousePos;
    private Vector3 newMousePos;
    private HingeJoint2D hingeJoint;
    private Vector2 anchor;
    private float distA;
    private float distB;
    private float distC;
    private float newAngle;

    public void OnMouseDown() {
            isMouseDragging = true;
            initialMousePos = Input.mousePosition;

    }

    public void OnMouseUp() {
            isMouseDragging = false;
    }

    private void Start() {
        hingeJoint = GetComponent<HingeJoint2D>();
        anchor = hingeJoint.anchor;
    }

    void Update() {

        // roots respond to user click and drag
        if (isMouseDragging) {
            // Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            // transform.Translate(mousePosition);

            // newMousePos = Input.mousePosition;

            // distA = Mathf.Pow(((hingeJoint.x - initialMousePos.x) + (hingeJoint.y - initialMousePos.y)), 0.5f);
            // distB = Mathf.Pow(((hingeJoint.x - newMousePos) + (hingeJoint.y - newMousePos.y)), 0.5f);
            // distC = Mathf.Pow(((initialMousePos.x - newMousePos.x) + (initialMousePos.y - newMousePos.y)), 0.5f);

            // newAngle = Mathf.Acos((Mathf.Pow(distA, 2f) + Mathf.Pow(distB, 2f) - Mathf.Pow(distC, 2f)) / (2f * distA * distB));

            




            // _hingeJoint.transform.position

            // find angle beteern initial cursor, current cursor and hinge
            // _hingeJoint.angle = 0; whatever




            mousePos = Input.mousePosition;
            //mousePos.z = -20;
            segmentPos = Camera.main.WorldToScreenPoint(target.position);
            float xDiff = mousePos.x - segmentPos.x;
            float yDiff = mousePos.y - segmentPos.y;
            angle = Mathf.Atan2(yDiff, xDiff) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0,0,angle);

        }

        //set pivot point for roots

            // make sure roots are always touching

        // check if overlapping

            // add collider to segment with trigger enabled

            // OnTriggerEntered function

            //check if the segment is intersecting with another




        // no overlap? level complete!

        
    }
}
