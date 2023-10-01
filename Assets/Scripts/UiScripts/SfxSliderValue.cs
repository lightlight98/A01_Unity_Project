using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SfxSliderValue : MonoBehaviour
{
    Text valueText;



    // Start is called before the first frame update
    void Start()
    {
        valueText = GetComponent<Text>();
    }

    public void valueUpdate(float value)
    {
        valueText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
