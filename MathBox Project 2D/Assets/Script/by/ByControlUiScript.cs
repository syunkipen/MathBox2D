using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;

public class ByControlUiScript : MonoBehaviour
{
    [SerializeField] ByTileControlScript b_TC;
    [SerializeField, Header("〇記号")]GameObject _maru;
    [SerializeField, Header("×記号")]GameObject _batu;
    [Header("進行度")]public DegreesBar _degreesBar;
    [Header("進行度")]public Text _degreesText;
    [SerializeField]public List<GameObject> _tileIconList;
    [SerializeField]public List<GameObject> _buttonList;
    [Header("回答欄＿一の位")] public Dropdown _drop_A;
    [Header("回答欄＿十の位")]public Dropdown _drop_B;
    [Header("クリア表示")] public GameObject _clearUi;

    [SerializeField]public BarRange _slider_A;    //1あたりの数
    [SerializeField]public BarRange _slider_B;    //いくつ分の数
    [SerializeField] public TMPro.TMP_Text _text_A;
    [SerializeField] public TMPro.TMP_Text _text_B;

    //[SerializeField]
    //List<GameObject> _navigationList;
    // Start is called before the first frame update

    void Start()
    {
        b_TC = GetComponent<ByTileControlScript>();
        _maru.SetActive(false);
        _batu.SetActive(false);
        _buttonList[0].gameObject.SetActive(true);
        _buttonList[1].gameObject.SetActive(false);
        _clearUi.SetActive(false);
    }

    public async void ClearEffect()
    {
        if (b_TC.formulaStorageLevel == 8 && b_TC.questionNumber == 8)
        {
            _maru.SetActive(true);
            await Task.Delay(1000);
            _maru.SetActive(false);
            _clearUi.SetActive(true);
        }
        else
        {
            _maru.SetActive(true);
            await Task.Delay(1000);
            _maru.SetActive(false);
        }
    }
    public async void UnClearEffect()
    {
        _batu.SetActive(true);
        await Task.Delay(1000);
        _batu.SetActive(false);
    }
}
