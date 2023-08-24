using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarRange : MonoBehaviour
{
    [SerializeField]
    Slider _slider;    
    public float[] _range = new float[]{0,
        0.92f,
        0.81f,
        0.71f,
        0.6f,
        0.5f,
        0.4f,
        0.29f,
        0.19f,
        0.08f };

    void Start()
    {
        _slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBar(int Dummy)
    {
        _slider.value = _range[Dummy];
    }

}
