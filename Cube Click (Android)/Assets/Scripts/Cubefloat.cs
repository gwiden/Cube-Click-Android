using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubefloat : MonoBehaviour {

    public float speed, tilt;
    private Vector3 target = new Vector3 (0, 1.4f, 0);
    private void Start()
    {
        Screen.SetResolution(720, 1280, false);
    }
    private void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != -0.57f)
            target.y = -0.57f;
        else if (transform.position == target && target.y == -0.57f)
            target.y = 1.4f;

        transform.Rotate(Vector3.up * tilt);
    }
}
