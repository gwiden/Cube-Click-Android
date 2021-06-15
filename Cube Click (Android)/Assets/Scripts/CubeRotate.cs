using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour {

    public float tilt;
    private Vector3 target = new Vector3 (0, 3.7f, 0);

    private void Update ()
    {
        transform.Rotate(Vector3.up * tilt);
    }
}
