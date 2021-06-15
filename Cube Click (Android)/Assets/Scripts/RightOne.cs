using UnityEngine;

public class RightOne : MonoBehaviour
{

    private GameObject mainCube;

    void Start()
    {
        mainCube = GameObject.Find("Main Cube");
    }

    void OnMouseDown()
    {
        if (this.GetComponent<RandNum>().right)
        {
            mainCube.GetComponent<GameCntrl>().lose = false;
            mainCube.GetComponent<GameCntrl>().next = true;
            mainCube.GetComponent<GameCntrl>().nextNums();
        }
        else
        {
            mainCube.GetComponent<GameCntrl>().next = false;
            mainCube.GetComponent<GameCntrl>().playerLose();
        }
    }
}