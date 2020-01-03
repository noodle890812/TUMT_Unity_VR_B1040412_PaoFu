using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
public class MainCtrl : MonoBehaviour
{
    int[] MenuArray = new int[9];
    Random rnd = new Random(); //產生亂數初始值
    int Satus;
    public GameObject Pizza;
    public GameObject[] Rolller;
    public int Player_Picking;
    public float Roller_Speed;
    public GameObject[] Oder_01;
    public GameObject[] Oder_02;
    public GameObject[] Oder_03;
    public Camera MyCam;
    public Image TimerImage;
    public float Gametime;
    GameObject TemObject;
    int a;
    public int Score;
    public GameObject OderUI, ScoreUI, FinshUI;
    public Text ScoreText;

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
        if (Input.GetKey(KeyCode.F1)) {
            if (Satus == 3)
            {
                Debug.Log("123");
                TemObject.GetComponent<Pizza>().PizzaDelete();
                Satus = 5;
                Score = Score - 200;
            }
        }

        switch (Satus)
        {

            case 0: // 開始遊戲
                Satus++;
                break;
            case 1: //生成訂單
                if (a < 1)
                {
                    for (int i = 0; i < 10; i++)
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
                        a++;
                    }
                }
                else
                {                  
                    a = 0;
                    OderCheck();
                    Satus = 2;
                }                
                break;
            case 2: //生成披薩
                TemObject = Instantiate(Pizza, new Vector3(0, 3.37f, -1.75f), new Quaternion(0, 0, 0, 0));
                TemObject.SetActive(true);
                Satus = 3;
                break;
            case 3: //製作中
                break;
            case 4: //送出披薩
                Rollerroad01();
                break;
            case 5://丟棄披薩
                Rollerroad02();
                break;
            case 6://結算 (顯示總分，可以再來一次或離開遊戲)
                OderUI.SetActive(false);
                ScoreUI.SetActive(true);
                FinshUI.SetActive(true);
                ScoreText.text = Score.ToString();
                break;
        }
        if (Satus==1|| Satus == 2|| Satus == 3|| Satus == 4 || Satus == 5)
        {
            TimerImage.fillAmount = 1 - (Gametime / 120);
            Gametime = Gametime + Time.deltaTime;

        }
        //if (TimerImage.fillAmount <= 0)
        //{
        //    Satus = 6;
        //}

    }
    public void BUTEST()
    {
        Satus = 1;
    }
    public void FinishButoon()
    {
        Debug.Log("321");
    }

    public void TrashcanButoon()
    {
        if (Satus == 3)
        {
            Debug.Log("123");
            TemObject.GetComponent<Pizza>().PizzaDelete();
            Satus = 5;
            Score = Score - 200;
        }
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

    public void Pick_release01()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn01();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release02()
    {
        if(MyCam.transform.rotation.y>-5&& MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn02();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release03()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn03();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release04()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn04();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release05()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn05();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release06()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn06();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release07()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn07();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release08()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn08();
        }
        else
        {
            Player_Picking = 0;
        }
    }
    public void Pick_release09()
    {
        if (MyCam.transform.rotation.y > -5 && MyCam.transform.rotation.y < 5)
        {
            TemObject.GetComponent<Pizza>().PutOn09();
        }
        else
        {
            Player_Picking = 0;
        }
    }

    public void OderCheck()
    {
        if (MenuArray[1] == 1)
        {
            Oder_01[0].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);
            Oder_01[9].SetActive(false);
        }
        if (MenuArray[1] == 2)
        {
            Oder_01[1].SetActive(true);
            Oder_01[0].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);
        }
        if (MenuArray[1] == 3)
        {
            Oder_01[2].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[0].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);
        }
        if (MenuArray[1] == 4)
        {
            Oder_01[3].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[0].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);
        }
        if (MenuArray[1] == 5)
        {
            Oder_01[4].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[0].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);
        }
        if (MenuArray[1] == 6)
        {
            Oder_01[5].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[0].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);

        }
        if (MenuArray[1] == 7)
        {
            Oder_01[6].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[0].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[8].SetActive(false);

        }
        if (MenuArray[1] == 8)
        {
            Oder_01[7].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[0].SetActive(false);
            Oder_01[8].SetActive(false);
        }
        if (MenuArray[1] == 9)
        {
            Oder_01[8].SetActive(true);
            Oder_01[1].SetActive(false);
            Oder_01[2].SetActive(false);
            Oder_01[3].SetActive(false);
            Oder_01[4].SetActive(false);
            Oder_01[5].SetActive(false);
            Oder_01[6].SetActive(false);
            Oder_01[7].SetActive(false);
            Oder_01[0].SetActive(false);
        }

        if (MenuArray[2] == 1)
        {
            Oder_02[0].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 2)
        {
            Oder_02[1].SetActive(true);
            Oder_02[0].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 3)
        {
            Oder_02[2].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[0].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 4)
        {
            Oder_02[3].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[0].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 5)
        {
            Oder_02[4].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[0].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 6)
        {
            Oder_02[5].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[0].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 7)
        {
            Oder_02[6].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[0].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 8)
        {
            Oder_02[7].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[0].SetActive(false);
            Oder_02[8].SetActive(false);
        }
        if (MenuArray[2] == 9)
        {
            Oder_02[8].SetActive(true);
            Oder_02[1].SetActive(false);
            Oder_02[2].SetActive(false);
            Oder_02[3].SetActive(false);
            Oder_02[4].SetActive(false);
            Oder_02[5].SetActive(false);
            Oder_02[6].SetActive(false);
            Oder_02[7].SetActive(false);
            Oder_02[0].SetActive(false);
        }

        if (MenuArray[0] == 1)
        {
            Oder_03[0].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 2)
        {
            Oder_03[1].SetActive(true);
            Oder_03[0].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 3)
        {
            Oder_03[2].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[0].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 4)
        {
            Oder_03[3].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[0].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 5)
        {
            Oder_03[4].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[0].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 6)
        {
            Oder_03[5].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[0].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 7)
        {
            Oder_03[6].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[0].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 8)
        {
            Oder_03[7].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[0].SetActive(false);
            Oder_03[8].SetActive(false);
        }
        if (MenuArray[0] == 9)
        {
            Oder_03[8].SetActive(true);
            Oder_03[1].SetActive(false);
            Oder_03[2].SetActive(false);
            Oder_03[3].SetActive(false);
            Oder_03[4].SetActive(false);
            Oder_03[5].SetActive(false);
            Oder_03[6].SetActive(false);
            Oder_03[7].SetActive(false);
            Oder_03[0].SetActive(false);
        }
    }

    public void PizzaDesory()
    {
        Satus = 2;
    }

}
