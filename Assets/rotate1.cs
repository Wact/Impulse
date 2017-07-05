using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    forw,
    backw
}
public class rotate1 : MonoBehaviour {

    // Use this for initialization
    void Start() {
            
        
    }
    public bool isRotating = false;
    public Direction direc = Direction.forw;
	// Update is called once per frame
	void Update () {
        if (isRotating)
        {
            if (direc == Direction.forw)
                gameObject.transform.Rotate(100 * Time.deltaTime, 0, 0);
            else
                gameObject.transform.Rotate(-100 * Time.deltaTime, 0, 0);
        }
    }
}
