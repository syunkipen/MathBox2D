using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class ControlUiScript : MonoBehaviour
{
    [SerializeField]
    TileControlScript TC;
    [Header("�񓚗��Q�\�̈�")]
    public Dropdown dd_10;
    [Header("�񓚗��Q��̈�")]
    public Dropdown dd_1;
    [SerializeField, Header("�Z�L��")]
    GameObject maru;
    [SerializeField, Header("�~�L��")]
    GameObject batu;
    [Header("�i�s�x")]
    public DegreesBar degreesBar;
    [SerializeField]
    List<GameObject> gauIconList;
    [SerializeField]
    public List<GameObject> buttonList;
    [SerializeField]
    GameObject gomiBox;
    [SerializeField]
    List<GameObject> navigationList;
    private void Start()
    {
        TC = GetComponent<TileControlScript>();
        gomiBox.gameObject.SetActive(false);
        
        switch (TC.GauType)
        {
            case 1:
                gomiBox.gameObject.SetActive(true);
                break;
        }
        maru.SetActive(false);
        batu.SetActive(false);
        for (int i = 0; i < gauIconList.Count; i++)
        {
            gauIconList[i].gameObject.SetActive(false);
        }
        for (int l = 0; l < navigationList.Count; l++)
        {
            navigationList[l].gameObject.SetActive(false);
        }

        gauIconList[TC.GauType].gameObject.SetActive(true);
        buttonList[0].gameObject.SetActive(true);
        buttonList[1].gameObject.SetActive(false);
    }

    public async void ClearEffect()
    {
        maru.SetActive(true);
        await Task.Delay(1000);
        maru.SetActive(false);
    }
    public async void UnClearEffect()
    {
        batu.SetActive(true);
        await Task.Delay(1000);
        batu.SetActive(false);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Dummy">�G�t�F�N�g�̔ԍ�</param>
    public async void SetNavigation(int Dummy)
    {
        navigationList[Dummy].SetActive(true);
        await Task.Delay(4000);
        navigationList[Dummy].SetActive(false);
    }
}
