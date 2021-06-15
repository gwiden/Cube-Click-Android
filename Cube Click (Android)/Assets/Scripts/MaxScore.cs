using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{

    private void Start ()
    {
        GetComponent<Text>().text = "Max Score" + "\n" + PlayerPrefs.GetInt("Score").ToString();
	}

}
