using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormulaStorageScript : MonoBehaviour
{
    [Header("ñ‚ëËÉäÉXÉg")]
    public List<Vector2> formulaStorageList;

    /// <summary>
    /// ñ‚ëËê∂ê¨
    /// </summary>
    /// <param name="GT">élë™ââéZÇÃêÿÇËë÷Ç¶</param>
    /// <param name="FSL">ñ‚ëËÉåÉxÉã</param>
    public void SetFormulaStorage(int GT, int FSL)
    {
        formulaStorageList.Clear();
        switch (GT)
        {
            //òa
            case 0:
                switch (FSL)
                {
                    case 0:
                        formulaStorageList.Add(new Vector2(8, 4));
                        formulaStorageList.Add(new Vector2(7, 5));
                        formulaStorageList.Add(new Vector2(9, 6));
                        formulaStorageList.Add(new Vector2(8, 7));
                        formulaStorageList.Add(new Vector2(9, 4));
                        formulaStorageList.Add(new Vector2(3, 7));
                        formulaStorageList.Add(new Vector2(8, 8));
                        formulaStorageList.Add(new Vector2(4, 9));
                        formulaStorageList.Add(new Vector2(6, 7));
                        formulaStorageList.Add(new Vector2(9, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 1:
                        formulaStorageList.Add(new Vector2(46, 52));
                        formulaStorageList.Add(new Vector2(13, 84));
                        formulaStorageList.Add(new Vector2(73, 21));
                        formulaStorageList.Add(new Vector2(36, 22));
                        formulaStorageList.Add(new Vector2(43, 23));
                        formulaStorageList.Add(new Vector2(45, 41));
                        formulaStorageList.Add(new Vector2(31, 57));
                        formulaStorageList.Add(new Vector2(23, 46));
                        formulaStorageList.Add(new Vector2(62, 23));
                        formulaStorageList.Add(new Vector2(52, 24));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 2:
                        formulaStorageList.Add(new Vector2(36, 20));
                        formulaStorageList.Add(new Vector2(42, 20));
                        formulaStorageList.Add(new Vector2(18, 30));
                        formulaStorageList.Add(new Vector2(54, 10));
                        formulaStorageList.Add(new Vector2(30, 28));
                        formulaStorageList.Add(new Vector2(50, 15));
                        formulaStorageList.Add(new Vector2(73, 5));
                        formulaStorageList.Add(new Vector2(17, 8));
                        formulaStorageList.Add(new Vector2(50, 30));
                        formulaStorageList.Add(new Vector2(40, 20));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 3:
                        formulaStorageList.Add(new Vector2(13, 28));
                        formulaStorageList.Add(new Vector2(59, 17));
                        formulaStorageList.Add(new Vector2(26, 27));
                        formulaStorageList.Add(new Vector2(47, 27));
                        formulaStorageList.Add(new Vector2(13, 29));
                        formulaStorageList.Add(new Vector2(35, 16));
                        formulaStorageList.Add(new Vector2(45, 28));
                        formulaStorageList.Add(new Vector2(17, 58));
                        formulaStorageList.Add(new Vector2(24, 28));
                        formulaStorageList.Add(new Vector2(37, 45));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 4:
                        formulaStorageList.Add(new Vector2(28, 2));
                        formulaStorageList.Add(new Vector2(11, 39));
                        formulaStorageList.Add(new Vector2(46, 14));
                        formulaStorageList.Add(new Vector2(35, 55));
                        formulaStorageList.Add(new Vector2(54, 11));
                        formulaStorageList.Add(new Vector2(8, 36));
                        formulaStorageList.Add(new Vector2(9, 47));
                        formulaStorageList.Add(new Vector2(9, 71));
                        formulaStorageList.Add(new Vector2(70, 0));
                        formulaStorageList.Add(new Vector2(18, 50));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                }
                break;
            //ç∑
            case 1:
                switch (FSL)
                {
                    case 0:
                        formulaStorageList.Add(new Vector2(15, 3));
                        formulaStorageList.Add(new Vector2(17, 5));
                        formulaStorageList.Add(new Vector2(12, 4));
                        formulaStorageList.Add(new Vector2(15, 8));
                        formulaStorageList.Add(new Vector2(17, 9));
                        formulaStorageList.Add(new Vector2(14, 7));
                        formulaStorageList.Add(new Vector2(13, 6));
                        formulaStorageList.Add(new Vector2(11, 9));
                        formulaStorageList.Add(new Vector2(21, 7));
                        formulaStorageList.Add(new Vector2(26, 8));
                        formulaStorageList.Add(new Vector2(23, 4));
                        formulaStorageList.Add(new Vector2(25, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 1:
                        formulaStorageList.Add(new Vector2(65, 21));
                        formulaStorageList.Add(new Vector2(44, 32));
                        formulaStorageList.Add(new Vector2(85, 32));
                        formulaStorageList.Add(new Vector2(38, 26));
                        formulaStorageList.Add(new Vector2(67, 25));
                        formulaStorageList.Add(new Vector2(76, 30));
                        formulaStorageList.Add(new Vector2(56, 40));
                        formulaStorageList.Add(new Vector2(44, 20));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 2:
                        formulaStorageList.Add(new Vector2(73, 53));
                        formulaStorageList.Add(new Vector2(45, 35));
                        formulaStorageList.Add(new Vector2(24, 14));
                        formulaStorageList.Add(new Vector2(88, 68));
                        formulaStorageList.Add(new Vector2(51, 21));
                        formulaStorageList.Add(new Vector2(90, 80));
                        formulaStorageList.Add(new Vector2(30, 10));
                        formulaStorageList.Add(new Vector2(50, 30));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 3:
                        formulaStorageList.Add(new Vector2(45, 42));
                        formulaStorageList.Add(new Vector2(24, 21));
                        formulaStorageList.Add(new Vector2(38, 32));
                        formulaStorageList.Add(new Vector2(73, 70));
                        formulaStorageList.Add(new Vector2(17, 10));
                        formulaStorageList.Add(new Vector2(45, 44));
                        formulaStorageList.Add(new Vector2(60, 30));
                        formulaStorageList.Add(new Vector2(20, 20));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 4:
                        formulaStorageList.Add(new Vector2(58, 6));
                        formulaStorageList.Add(new Vector2(48, 7));
                        formulaStorageList.Add(new Vector2(47, 0));
                        formulaStorageList.Add(new Vector2(62, 2));
                        formulaStorageList.Add(new Vector2(35, 3));
                        formulaStorageList.Add(new Vector2(24, 4));
                        formulaStorageList.Add(new Vector2(90, 0));
                        formulaStorageList.Add(new Vector2(63, 0));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 5:
                        formulaStorageList.Add(new Vector2(43, 25));
                        formulaStorageList.Add(new Vector2(41, 19));
                        formulaStorageList.Add(new Vector2(52, 52));
                        formulaStorageList.Add(new Vector2(53, 14));
                        formulaStorageList.Add(new Vector2(71, 48));
                        formulaStorageList.Add(new Vector2(42, 17));
                        formulaStorageList.Add(new Vector2(34, 16));
                        formulaStorageList.Add(new Vector2(63, 35));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 6:
                        formulaStorageList.Add(new Vector2(50, 19));
                        formulaStorageList.Add(new Vector2(80, 46));
                        formulaStorageList.Add(new Vector2(60, 41));
                        formulaStorageList.Add(new Vector2(50, 47));
                        formulaStorageList.Add(new Vector2(23, 15));
                        formulaStorageList.Add(new Vector2(21, 15));
                        formulaStorageList.Add(new Vector2(70, 62));
                        formulaStorageList.Add(new Vector2(30, 22));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 7:
                        formulaStorageList.Add(new Vector2(65, 8));
                        formulaStorageList.Add(new Vector2(30, 5));
                        formulaStorageList.Add(new Vector2(38, 9));
                        formulaStorageList.Add(new Vector2(52, 5));
                        formulaStorageList.Add(new Vector2(41, 2));
                        formulaStorageList.Add(new Vector2(50, 9));
                        formulaStorageList.Add(new Vector2(20, 6));
                        formulaStorageList.Add(new Vector2(36, 8));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                }
                break;
            //êœ
            case 2:
                switch (FSL)
                {
                    case 0:
                        formulaStorageList.Add(new Vector2(1, 1));
                        formulaStorageList.Add(new Vector2(1, 2));
                        formulaStorageList.Add(new Vector2(1, 3));
                        formulaStorageList.Add(new Vector2(1, 4));
                        formulaStorageList.Add(new Vector2(1, 5));
                        formulaStorageList.Add(new Vector2(1, 6));
                        formulaStorageList.Add(new Vector2(1, 7));
                        formulaStorageList.Add(new Vector2(1, 8));
                        formulaStorageList.Add(new Vector2(1, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 1:
                        formulaStorageList.Add(new Vector2(2, 1));
                        formulaStorageList.Add(new Vector2(2, 2));
                        formulaStorageList.Add(new Vector2(2, 3));
                        formulaStorageList.Add(new Vector2(2, 4));
                        formulaStorageList.Add(new Vector2(2, 5));
                        formulaStorageList.Add(new Vector2(2, 6));
                        formulaStorageList.Add(new Vector2(2, 7));
                        formulaStorageList.Add(new Vector2(2, 8));
                        formulaStorageList.Add(new Vector2(2, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 2:
                        formulaStorageList.Add(new Vector2(3, 1));
                        formulaStorageList.Add(new Vector2(3, 2));
                        formulaStorageList.Add(new Vector2(3, 3));
                        formulaStorageList.Add(new Vector2(3, 4));
                        formulaStorageList.Add(new Vector2(3, 5));
                        formulaStorageList.Add(new Vector2(3, 6));
                        formulaStorageList.Add(new Vector2(3, 7));
                        formulaStorageList.Add(new Vector2(3, 8));
                        formulaStorageList.Add(new Vector2(3, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 3:
                        formulaStorageList.Add(new Vector2(4, 1));
                        formulaStorageList.Add(new Vector2(4, 2));
                        formulaStorageList.Add(new Vector2(4, 3));
                        formulaStorageList.Add(new Vector2(4, 4));
                        formulaStorageList.Add(new Vector2(4, 5));
                        formulaStorageList.Add(new Vector2(4, 6));
                        formulaStorageList.Add(new Vector2(4, 7));
                        formulaStorageList.Add(new Vector2(4, 8));
                        formulaStorageList.Add(new Vector2(4, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 4:
                        formulaStorageList.Add(new Vector2(5, 1));
                        formulaStorageList.Add(new Vector2(5, 2));
                        formulaStorageList.Add(new Vector2(5, 3));
                        formulaStorageList.Add(new Vector2(5, 4));
                        formulaStorageList.Add(new Vector2(5, 5));
                        formulaStorageList.Add(new Vector2(5, 6));
                        formulaStorageList.Add(new Vector2(5, 7));
                        formulaStorageList.Add(new Vector2(5, 8));
                        formulaStorageList.Add(new Vector2(5, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 5:
                        formulaStorageList.Add(new Vector2(6, 1));
                        formulaStorageList.Add(new Vector2(6, 2));
                        formulaStorageList.Add(new Vector2(6, 3));
                        formulaStorageList.Add(new Vector2(6, 4));
                        formulaStorageList.Add(new Vector2(6, 5));
                        formulaStorageList.Add(new Vector2(6, 6));
                        formulaStorageList.Add(new Vector2(6, 7));
                        formulaStorageList.Add(new Vector2(6, 8));
                        formulaStorageList.Add(new Vector2(6, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 6:
                        formulaStorageList.Add(new Vector2(7, 1));
                        formulaStorageList.Add(new Vector2(7, 2));
                        formulaStorageList.Add(new Vector2(7, 3));
                        formulaStorageList.Add(new Vector2(7, 4));
                        formulaStorageList.Add(new Vector2(7, 5));
                        formulaStorageList.Add(new Vector2(7, 6));
                        formulaStorageList.Add(new Vector2(7, 7));
                        formulaStorageList.Add(new Vector2(7, 8));
                        formulaStorageList.Add(new Vector2(7, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 7:
                        formulaStorageList.Add(new Vector2(8, 1));
                        formulaStorageList.Add(new Vector2(8, 2));
                        formulaStorageList.Add(new Vector2(8, 3));
                        formulaStorageList.Add(new Vector2(8, 4));
                        formulaStorageList.Add(new Vector2(8, 5));
                        formulaStorageList.Add(new Vector2(8, 6));
                        formulaStorageList.Add(new Vector2(8, 7));
                        formulaStorageList.Add(new Vector2(8, 8));
                        formulaStorageList.Add(new Vector2(8, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 8:
                        formulaStorageList.Add(new Vector2(9, 1));
                        formulaStorageList.Add(new Vector2(9, 2));
                        formulaStorageList.Add(new Vector2(9, 3));
                        formulaStorageList.Add(new Vector2(9, 4));
                        formulaStorageList.Add(new Vector2(9, 5));
                        formulaStorageList.Add(new Vector2(9, 6));
                        formulaStorageList.Add(new Vector2(9, 7));
                        formulaStorageList.Add(new Vector2(9, 8));
                        formulaStorageList.Add(new Vector2(9, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    
                }
                break;
            //è§
            case 3:
                switch (FSL)
                {
                    case 0:
                        formulaStorageList.Add(new Vector2(8, 4));
                        formulaStorageList.Add(new Vector2(7, 5));
                        formulaStorageList.Add(new Vector2(9, 6));
                        formulaStorageList.Add(new Vector2(8, 7));
                        formulaStorageList.Add(new Vector2(9, 4));
                        formulaStorageList.Add(new Vector2(3, 7));
                        formulaStorageList.Add(new Vector2(8, 8));
                        formulaStorageList.Add(new Vector2(4, 9));
                        formulaStorageList.Add(new Vector2(6, 7));
                        formulaStorageList.Add(new Vector2(9, 9));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 1:
                        formulaStorageList.Add(new Vector2(46, 52));
                        formulaStorageList.Add(new Vector2(13, 84));
                        formulaStorageList.Add(new Vector2(73, 21));
                        formulaStorageList.Add(new Vector2(36, 22));
                        formulaStorageList.Add(new Vector2(43, 23));
                        formulaStorageList.Add(new Vector2(45, 41));
                        formulaStorageList.Add(new Vector2(31, 57));
                        formulaStorageList.Add(new Vector2(23, 46));
                        formulaStorageList.Add(new Vector2(62, 23));
                        formulaStorageList.Add(new Vector2(52, 24));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 2:
                        formulaStorageList.Add(new Vector2(36, 20));
                        formulaStorageList.Add(new Vector2(42, 20));
                        formulaStorageList.Add(new Vector2(18, 30));
                        formulaStorageList.Add(new Vector2(54, 10));
                        formulaStorageList.Add(new Vector2(30, 28));
                        formulaStorageList.Add(new Vector2(50, 15));
                        formulaStorageList.Add(new Vector2(73, 5));
                        formulaStorageList.Add(new Vector2(17, 8));
                        formulaStorageList.Add(new Vector2(50, 30));
                        formulaStorageList.Add(new Vector2(40, 20));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 3:
                        formulaStorageList.Add(new Vector2(13, 28));
                        formulaStorageList.Add(new Vector2(59, 17));
                        formulaStorageList.Add(new Vector2(26, 27));
                        formulaStorageList.Add(new Vector2(47, 27));
                        formulaStorageList.Add(new Vector2(13, 29));
                        formulaStorageList.Add(new Vector2(35, 16));
                        formulaStorageList.Add(new Vector2(45, 28));
                        formulaStorageList.Add(new Vector2(17, 58));
                        formulaStorageList.Add(new Vector2(24, 28));
                        formulaStorageList.Add(new Vector2(37, 45));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                    case 4:
                        formulaStorageList.Add(new Vector2(28, 2));
                        formulaStorageList.Add(new Vector2(11, 39));
                        formulaStorageList.Add(new Vector2(46, 14));
                        formulaStorageList.Add(new Vector2(35, 55));
                        formulaStorageList.Add(new Vector2(54, 11));
                        formulaStorageList.Add(new Vector2(8, 36));
                        formulaStorageList.Add(new Vector2(9, 47));
                        formulaStorageList.Add(new Vector2(9, 71));
                        formulaStorageList.Add(new Vector2(70, 0));
                        formulaStorageList.Add(new Vector2(18, 50));
                        formulaStorageList.Add(new Vector2(999, 999));
                        break;
                }
                break;
        }
    }
}
