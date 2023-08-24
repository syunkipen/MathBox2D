using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;


public class TileAreaScript : MonoBehaviour
{
    [Header("�G���AID")]
    public string areaID;
    [Header("�S���̌�")]
    public int areaType;
    [SerializeField]
    BoxCollider2D type1;
    [SerializeField]
    BoxCollider2D type10;
    [Header("�^�C���i�[�ʒu-Type1")]
    public List<Transform> stoList1;
    [Header("�^�C���i�[�ʒu-Type10")]
    public List<Transform> stoList10;
    [Header("�G���A���̃^�C��")]
    public List<Tile> areaTileList;
    [Header("5Tile�̈ʒu")]
    public int pos5;
    [Header("10Tile�̈ʒu")]
    public int pos10;
    [Header("50Tile�̈ʒu")]
    public int pos50 = 2;
    [Header("�G���A���̃^�C���p���[")]
    public int areaTilePower = 0;
    public TextMeshPro textMesh;
    [Header("�|���Z�t���O")]
    public bool _onBy;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < stoList1.Count; i++)
        {
            if (stoList1[i].tag == "ActiveTile5")
            {
                pos5 = i;
            }
            if (stoList1[i].tag == "ActiveTile10")
            {
                pos10 = i;
            }
        }

        //�G���A�̐؂�ւ�
        if (areaType == 1)
        {
            type1.enabled = true;
            type10.enabled = false;
        }
        else if (areaType == 10)
        {
            type1.enabled = false;
            type10.enabled = true;
        }
        //textMesh.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (areaType == 1)
        {
            if (_onBy)
            {
                //��ȏ����Ȃ�
                if (areaTileList.Count >= 2) return;


                if (areaTileList.Count != 0)
                {
                    //����^�C���͈��������Ȃ�
                    for (int i = 0; i < areaTileList.Count; i++)
                    {
                        if (areaTileList[i].tag == "ActiveTile5")
                        {
                            if (collision.tag == "ActiveTile5") return;
                        }
                        else if (areaTileList[i].tag == "ActiveTile4")
                        {
                            if (collision.tag == "ActiveTile4") return;
                        }
                        else if (areaTileList[i].tag == "ActiveTile3")
                        {
                            if (collision.tag == "ActiveTile3") return;
                        }
                        else if (areaTileList[i].tag == "ActiveTile2")
                        {
                            if (collision.tag == "ActiveTile2") return;
                        }
                        else if (areaTileList[i].tag == "ActiveTile")
                        {
                            if (collision.tag == "ActiveTile") return;
                        }
                    }
                }
            }

            Tile t = collision.gameObject.GetComponent<Tile>();
            areaTilePower += t.myTilePower;
            if (collision.tag == "ActiveTile5")
            {
                areaTileList.Insert(0, t);
            }
            else
            {
                areaTileList.Add(t);
            }
        }
        else if(areaType == 10)
        {
            if(collision.tag == "ActiveTile10" || collision.tag == "ActiveTile50")
            {
                Tile t = collision.gameObject.GetComponent<Tile>();
                areaTilePower += t.myTilePower;
                if(collision.tag == "ActiveTile50")
                {
                    areaTileList.Insert(0, t);
                }
                else
                {
                    areaTileList.Add(t);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if(areaType == 1)
        {
            Tile t = collision.gameObject.GetComponent<Tile>();
            areaTilePower -= t.myTilePower;
            areaTileList.Remove(t);
        }
        else if(areaType == 10)
        {
            if (collision.tag == "ActiveTile10" || collision.tag == "ActiveTile50")
            {
                Tile t = collision.gameObject.GetComponent<Tile>();
                areaTilePower -= t.myTilePower;
                areaTileList.Remove(t);
            }
        }
        if(areaTilePower < 0)
        {
            areaTilePower = 0;
        }
    }
}
