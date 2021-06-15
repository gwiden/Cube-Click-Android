using UnityEngine;
using UnityEngine.UI;

public class RandNum : MonoBehaviour
{
    public Text RanNum;
    public bool main = false, right = false, fake = false;
    public int Num;

    private void Awake()
    {
        if (main && !fake)
        {
            Num = Random.Range(1, 16);
            RanNum.text = Num.ToString();
            //Screen.SetResolution(720, 1280, false);
        }
        
    }
}
