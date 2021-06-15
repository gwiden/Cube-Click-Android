using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameCntrl : MonoBehaviour
{
    public GameObject colBlock;
    public Vector3[] positions;
    private GameObject block;
    public GameObject[] blocks = new GameObject[16];

    private int rand;
    public int count;
    public Text score;

    [SerializeField] bool fake;
    [HideInInspector]
    public bool next, lose;


    void Start()
    {
        count = 0;
        next = false;
        lose = false;
        rand = Random.Range(0, positions.Length);

            for (int i = 0; i < positions.Length; i++)
                {
                    blocks[i] = Instantiate(colBlock, positions[i], Quaternion.identity) as GameObject;
                    if (GetComponent<RandNum>().Num == i && !fake)
                        {
                            block = blocks[i-1];
                        }
                    
                }
        if (!fake)
        {
            block.GetComponent<RandNum>().right = true;
        }
            
    }


    internal void nextNums()
    {
        block.GetComponent<RandNum>().right = false;
        GetComponent<AudioSource> ().Play ();
        count++;
        score.text = "score" + "\n" + count;
        GetComponent<RandNum>().Num = Random.Range(1, 16);
        GetComponent<RandNum>().RanNum.text = GetComponent<RandNum>().Num.ToString();
        Next();
    }

    void Next()
    {
        for(int i = 0; i < positions.Length; i++)
        {
            if (GetComponent<RandNum>().Num == i)
            {
                block = blocks[i - 1];
                block.GetComponent<RandNum>().right = true;
            }
        }
    }

    internal void playerLose()
    {
        if (PlayerPrefs.GetInt("Score") < count)
            PlayerPrefs.SetInt("Score", count);
        Application.LoadLevel("lose");
    }
}
