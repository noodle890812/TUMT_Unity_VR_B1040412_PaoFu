using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public GameObject Olive_08, Leaves_09, Broccoli_03, Mushroom_07, Shrimp_06, Pineapple_02, Pepper_04, Onion_01, Sausage_05;
    public bool Olive_OnPizza, Leaves_OnPizza, Broccoli_OnPizza, Mushroom_OnPizza, Shrimp_OnPizza, Pineapple_OnPizza, Pepper_OnPizza, Onion_OnPizza, Sausage_OnPizza;
    public bool[] OnPizza=new bool[9];
    int Satus;
    public GameObject Main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Satus)
        {
            case 0: //生成
                if (this.transform.position.y > -0.025f)
                {
                    this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(0f, -0.025f, -0.62f), 2f*Time.deltaTime);
                }
                else
                {
                    Satus = 1;
                }
                break;
            case 1: //製作
                break;
            case 2: //送出
                if (this.transform.position.x < 1.4f)
                {
                    this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(1.4f, -0.025f, -0.62f), 2f * Time.deltaTime);
                }
                else
                {
                    Main.GetComponent<MainCtrl>().PizzaSend();
                    Destroy(gameObject);
                }
                break;
            case 3: //刪除
                if (this.transform.position.x > -0.85f)
                {
                    this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(-0.85f, -0.025f, -0.62f), 2f * Time.deltaTime);
                }
                else
                {
                    Main.GetComponent<MainCtrl>().PizzaDesory();
                    Destroy(gameObject);
                    
                }
                break;
        }
    }

    public void PutOn01()
    {
        this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        Onion_OnPizza = true;
        OnPizza[0] = true;
    }
    public void PutOn02()
    {
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        Pineapple_OnPizza = true;
        OnPizza[1] = true;
    }
    public void PutOn03()
    {
        this.gameObject.transform.GetChild(3).gameObject.SetActive(true);
        Broccoli_OnPizza = true;
        OnPizza[2] = true;
    }
    public void PutOn04()
    {
        this.gameObject.transform.GetChild(4).gameObject.SetActive(true);
        Pepper_OnPizza = true;
        OnPizza[3] = true;
    }
    public void PutOn05()
    {
        this.gameObject.transform.GetChild(5).gameObject.SetActive(true);
        Sausage_OnPizza = true;
        OnPizza[4] = true;
    }
    public void PutOn06()
    {
        this.gameObject.transform.GetChild(6).gameObject.SetActive(true);
        Shrimp_OnPizza = true;
        OnPizza[5] = true;
    }
    public void PutOn07()
    {
        this.gameObject.transform.GetChild(7).gameObject.SetActive(true);
        Mushroom_OnPizza = true;
        OnPizza[6] = true;
    }
    public void PutOn08()
    {
        this.gameObject.transform.GetChild(8).gameObject.SetActive(true);
        Olive_OnPizza = true;
        OnPizza[7] = true;
    }
    public void PutOn09()
    {
        this.gameObject.transform.GetChild(9).gameObject.SetActive(true);
        Leaves_OnPizza = true;
        OnPizza[8] = true;
    }
    
    public void PizzaComplete()
    {
        Satus = 2;
    }

    public void PizzaDelete()
    {
        Satus=3;
    }
}
