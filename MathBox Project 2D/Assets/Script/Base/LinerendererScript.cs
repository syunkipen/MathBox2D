using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinerendererScript : MonoBehaviour
{
    [SerializeField]
    LineRenderer linerend;
    [Header("���C���^�C�v")]
    public int _type = 0;
    [Header("�F�̎w��")]
    public Vector3 _HSV = new Vector3(1.0f,1.0f,1.0f);
    [Header("���C���̕�")]
    public float _width = 10.0f;
    void Start()
    {
        linerend = GetComponent<LineRenderer>();
        //�}�e���A���̐ݒ�
        linerend.material = new Material(Shader.Find("Sprites/Default"));
        //�n�_�ƏI�_������
        linerend.loop = true;

        //�n�_�A�I�_�̕���ύX
        linerend.startWidth = _width;
        linerend.endWidth = _width;

        //�F���w�肷��
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
                
                // �_�̐����w�肷��
                linerend.positionCount = positions.Length;

                // ���������ꏊ���w�肷��
                linerend.SetPositions(positions);
                break;
            case 1:
                Vector3[] positions1 = new Vector3[]{
                new Vector3(56, 540, -50),
                new Vector3(322, 540, -50),
                new Vector3(322, 96, -50),
                new Vector3(56, 96, -50),
                };
                
                // �_�̐����w�肷��
                linerend.positionCount = positions1.Length;

                // ���������ꏊ���w�肷��
                linerend.SetPositions(positions1);
                break;
        }

        
    }
}