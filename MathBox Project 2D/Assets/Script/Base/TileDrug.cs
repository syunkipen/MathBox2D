using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDrug : MonoBehaviour
{

    [SerializeField] Camera _cam;
    private Vector3 offset;
    private void Start()
    {
            _cam = Camera.main;
    }
    private void OnMouseDown()
    {
        offset = gameObject.transform.position - GetMousePos();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + offset;
    }
    private Vector3 GetMousePos()
    {
        return _cam.ScreenToWorldPoint(Input.mousePosition);
    }
}