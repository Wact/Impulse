using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        transform.parent.GetComponent<rotate1>().isRotating = false;
        other.transform.parent.GetComponent<rotate1>().isRotating = true;
        //other.gameObject.GetC<rotate1>().isRotating = false;
        //other.gameObject.GetComponent<rotate1>().isRotating = false;
        Debug.Log("Пересеклись");
    }
}
