using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void shiftLeft()
    {

    }

    void shiftForward(GameObject go, Quaternion rotation)
    {
        if (315f < rotation.y || rotation.y < 45f)
        {
            Debug.Log("Red Wall");
        }
        if (rotation.y >= 45f && rotation.y < 135f)
        {
            Debug.Log("Blue Wall");
        }
        if (rotation.y >= 135f && rotation.y < 225f)
        {
            Debug.Log("Black Wall");
        }
        if (rotation.y >= 225f && rotation.y < 215f)
        {
            Debug.Log("Green Wall");
        }
    }

    void shiftBackward()
    {

    }

    void shiftRight()
    {

    }

    void shiftUp()
    {

    }
}
