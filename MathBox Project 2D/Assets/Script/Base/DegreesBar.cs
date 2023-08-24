using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DegreesBar : MonoBehaviour
{
    int maxBar;
    int currentBar;
    [SerializeField]
    Text text_A;
    [SerializeField]
    Text text_B;
    [SerializeField]
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
    }

    public void BarAction(int Max, int Current)
    {
        maxBar = Max;
        currentBar = Max - Current;
        float Dummy = (float)currentBar / (float)maxBar;
        slider.value = Dummy;
        text_A.text = Current.ToString();
        text_B.text = maxBar.ToString();
    }
}
