using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    public Color col, defCol;
    public GameObject mCube;
    private int lastNum;
    
    private void Start()
    {
        lastNum = mCube.GetComponent<RandNum>().Num;
    }

    private void Update()
    {

        float n = mCube.GetComponent<GameCntrl>().count * 0.002f;

        if (!mCube.GetComponent<GameCntrl>().lose)
        {
            if (transform.position.x < -8.5f)
                Destroy(gameObject);
            if (transform.position.x < -1.5f)
                GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, col, Time.deltaTime);
                transform.position -= new Vector3(0.03f + n, 0, 0);
            
            if (transform.position.x < -8.5f)
                mCube.GetComponent<GameCntrl>().playerLose();
        }

        if (mCube.GetComponent<RandNum>().Num != lastNum)
        {
            lastNum = mCube.GetComponent<RandNum>().Num;
            transform.position = new Vector3(0, transform.position.y, 0);
            GetComponent<Renderer>().material.color = defCol;
        }
    }

    private void OnDestroy()
    {
        if (mCube)
            mCube.GetComponent<GameCntrl>().lose = true;
    }
}