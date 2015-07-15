using UnityEngine;
using System.Collections;

public class RotationType : MonoBehaviour {

    public string forceGravityType = "-x";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public string getRotationType()
    {
        return forceGravityType;
    }
}
