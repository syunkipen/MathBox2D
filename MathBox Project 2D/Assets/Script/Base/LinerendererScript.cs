using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinerendererScript : MonoBehaviour
{
    [SerializeField]
    LineRenderer linerend;
    [Header("ラインタイプ")]
    public int _type = 0;
    [Header("色の指定")]
    public Vector3 _HSV = new Vector3(1.0f,1.0f,1.0f);
    [Header("ラインの幅")]
    public float _width = 10.0f;
    void Start()
    {
        linerend = GetComponent<LineRenderer>();
        //マテリアルの設定
        linerend.material = new Material(Shader.Find("Sprites/Default"));
        //始点と終点を結ぶ
        linerend.loop = true;

        //始点、終点の幅を変更
        linerend.startWidth = _width;
        linerend.endWidth = _width;

        //色を指定する
        //linerend.startColor = Color.HSVToRGB(_HSV.x, _HSV.y, _HSV.z);
        //linerend.endColor = Color.HSVToRGB(_HSV.x, _HSV.y, _HSV.z);


        switch (_type)
        {
            case 0:
                Vector3[] positions = new Vector3[]{
                new Vector3(322, 540, -50),
                new Vector3(422, 540, -50),
                new Vector3(422, 96, -50),
                new Vector3(322, 96, -50),
                };
                
                // 点の数を指定する
                linerend.positionCount = positions.Length;

                // 線を引く場所を指定する
                linerend.SetPositions(positions);
                break;
            case 1:
                Vector3[] positions1 = new Vector3[]{
                new Vector3(56, 540, -50),
                new Vector3(322, 540, -50),
                new Vector3(322, 96, -50),
                new Vector3(56, 96, -50),
                };
                
                // 点の数を指定する
                linerend.positionCount = positions1.Length;

                // 線を引く場所を指定する
                linerend.SetPositions(positions1);
                break;
        }

        
    }
}