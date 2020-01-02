using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCtrl : MonoBehaviour
{
    int[] MenuArray = new int[3];
    Random rnd = new Random(); //產生亂數初始值
    int Satus;
    public GameObject Pizza;
    public GameObject[] Rolller;
    public int Sccore,Player_Picking;
    public float Roller_Speed;
    public GameObject[] Oder_01;
    public GameObject[] Oder_02;
    public GameObject[] Oder_03;

    //01=洋蔥
    //02=鳳梨
    //03=花椰菜
    //04=青椒
    //05=香腸
    //06=蝦子
    //07=香菇
    //08=橄欖
    //09=九層塔

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        switch (Satus)
        {
            case 0: // 開始遊戲
                Satus++;
                break;
            case 1: //生成訂單
                if (Satus == 1)
                {
                    Invoke("OderBuild", 0);
                }                            
                OderCheck();
                Satus = 2;
                break;
            case 2: //製作中
                break;
            case 3: //送出披薩
                break;
            case 4://丟棄披薩
                Rollerroad02();
                break;
            case 5://結算 (顯示總分，可以再來一次或離開遊戲)
                break;
        }
    }
    public void BUTEST()
    {
        Satus = 3;
    }
    public void FinishButoon()
    {

    }

    public void TrashcanButoon()
    {
        Sccore = Sccore - 200;
    }
    public void Rollerroad01()
    {
        Rolller[0].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[1].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[2].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[3].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[4].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[5].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[6].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[7].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[8].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[9].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[10].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[11].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[12].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[13].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[14].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[15].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[16].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[17].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[18].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[19].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[20].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[21].transform.Rotate(0, -Roller_Speed * Time.deltaTime, 0, Space.Self);
    }
    public void Rollerroad02()
    {
        Rolller[0].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[1].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[2].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[3].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[4].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[5].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[6].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[7].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[8].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[9].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[10].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[11].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[12].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[13].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[14].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[15].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[16].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[17].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[18].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[19].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[20].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
        Rolller[21].transform.Rotate(0, Roller_Speed * Time.deltaTime, 0, Space.Self);
    }

    public void Pick_01()
    {
        Player_Picking = 1;
    }
    public void Pick_02()
    {
        Player_Picking = 2;
    }
    public void Pick_03()
    {
        Player_Picking = 3;
    }
    public void Pick_04()
    {
        Player_Picking = 4;
    }
    public void Pick_05()
    {
        Player_Picking = 5;
    }
    public void Pick_06()
    {
        Player_Picking = 6;
    }
    public void Pick_07()
    {
        Player_Picking = 7;
    }
    public void Pick_08()
    {
        Player_Picking = 8;
    }
    public void Pick_09()
    {
        Player_Picking = 9;
    }
    public void Pick_release()
    {


        Player_Picking = 0;
    }

    public void OderCheck()
    {
        if (MenuArray[1] == 1)
        {
            Oder_01[0].SetActive(true);
        }
        if (MenuArray[1] == 2)
        {
            Oder_01[1].SetActive(true);
        }
        if (MenuArray[1] == 3)
        {
            Oder_01[2].SetActive(true);
        }
        if (MenuArray[1] == 4)
        {
            Oder_01[3].SetActive(true);
        }
        if (MenuArray[1] == 5)
        {
            Oder_01[4].SetActive(true);
        }
        if (MenuArray[1] == 6)
        {
            Oder_01[5].SetActive(true);
        }
        if (MenuArray[1] == 7)
        {
            Oder_01[6].SetActive(true);
        }
        if (MenuArray[1] == 8)
        {
            Oder_01[7].SetActive(true);
        }
        if (MenuArray[1] == 9)
        {
            Oder_01[8].SetActive(true);
        }

        if (MenuArray[2] == 1)
        {
            Oder_02[0].SetActive(true);
        }
        if (MenuArray[2] == 2)
        {
            Oder_02[1].SetActive(true);
        }
        if (MenuArray[2] == 3)
        {
            Oder_02[2].SetActive(true);
        }
        if (MenuArray[2] == 4)
        {
            Oder_02[3].SetActive(true);
        }
        if (MenuArray[2] == 5)
        {
            Oder_02[4].SetActive(true);
        }
        if (MenuArray[2] == 6)
        {
            Oder_02[5].SetActive(true);
        }
        if (MenuArray[2] == 7)
        {
            Oder_02[6].SetActive(true);
        }
        if (MenuArray[2] == 8)
        {
            Oder_02[7].SetActive(true);
        }
        if (MenuArray[2] == 9)
        {
            Oder_02[8].SetActive(true);
        }

        if (MenuArray[3] == 1)
        {
            Oder_03[0].SetActive(true);
        }
        if (MenuArray[3] == 2)
        {
            Oder_03[1].SetActive(true);
        }
        if (MenuArray[3] == 3)
        {
            Oder_03[2].SetActive(true);
        }
        if (MenuArray[3] == 4)
        {
            Oder_03[3].SetActive(true);
        }
        if (MenuArray[3] == 5)
        {
            Oder_03[4].SetActive(true);
        }
        if (MenuArray[3] == 6)
        {
            Oder_03[5].SetActive(true);
        }
        if (MenuArray[3] == 7)
        {
            Oder_03[6].SetActive(true);
        }
        if (MenuArray[3] == 8)
        {
            Oder_03[7].SetActive(true);
        }
        if (MenuArray[3] == 9)
        {
            Oder_03[8].SetActive(true);
        }
    }
    public void OderBuild()
    {
        for (int i = 0; i < 5; i++)
        {
            MenuArray[i] = Random.Range(1, 10);   //亂數產生，亂數產生的範圍是1~9

            for (int j = 0; j < i; j++)
            {
                while (MenuArray[j] == MenuArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                {
                    j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                    MenuArray[i] = Random.Range(1, 10);   //重新產生，存回陣列，亂數產生的範圍是1~9
                }
            }
        }
        Satus = 2;
    }

}
