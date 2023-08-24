using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownNumberScript : MonoBehaviour
{
    //�h���b�v�_�E���I�u�W�F�N�g
    public Dropdown ddtmp;

    public List<string> optionlist = new List<string>();
    public string selectedvalue = null;

    //�I�����ꂽ�l
    [Header("�I�𒆂̒l")]
    public int valueNumber = 0;
    [Header("�ʃ^�C�v")]
    public int Type = 0;

    void Start()
    {
        switch (Type)
        {
            case 1:
                //�I������ǉ�
                optionlist.Add("0");
                optionlist.Add("1");
                optionlist.Add("2");
                optionlist.Add("3");
                optionlist.Add("4");
                optionlist.Add("5");
                optionlist.Add("6");
                optionlist.Add("7");
                optionlist.Add("8");
                optionlist.Add("9");
                break;


            case 10:
                optionlist.Add("0");
                optionlist.Add("1");
                break;
        }


        //Dropdown�R���|�[�l���g��Options�Ƃ������ڂ̃��X�g
        //��ҏW���邽�߂�Dropdown�R���|�[�l���g���擾
        ddtmp = GetComponent<Dropdown>();

        //Options���N���A
        ddtmp.ClearOptions();

        //���X�g��ǉ�
        ddtmp.AddOptions(optionlist);
    }

    public void Update()
    {
        valueNumber = ddtmp.value;

    }

    public void AddTile()
    {
    }

    public void GetType()
    {
        //DropDown�R���|�[�l���g��options����I������ĂĂ���value��index�Ŏw�肵�A
        //�I������Ă��镶��������
        selectedvalue = ddtmp.options[ddtmp.value].text;
    }
}