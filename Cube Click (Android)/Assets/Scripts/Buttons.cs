using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Sprite layer_blue, layer_red;
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_red;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }

    void OnMouseUpAsButton ()
    {
        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("play");
                break;
            case "Replay":
                Application.LoadLevel("play");
                break;
            case "Home":
                Application.LoadLevel("main");
                break;
            case "Close":
                Application.LoadLevel("main");
                break;
            case "How":
                Application.LoadLevel("how");
                break;

        }
    }

}
