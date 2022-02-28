using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRobyImage : MonoBehaviour
{
    public Sprite Hanul;
    public Sprite Juwon;
    Image thisImg;
    // Start is called before the first frame update
    void Start()
    {
        thisImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void ChangeImg()
    {
        if(thisImg.sprite = Juwon)
        {
            thisImg.sprite = Hanul;
        }
    }
}
