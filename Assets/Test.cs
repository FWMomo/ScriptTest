using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Midboss
{
    private int hp = 100;
    private int atk = 20;

    public void atack()
    {
        Debug.Log("You dealt" + this.atk + "damage!");
    }

    public void defend(int defence)
    {
        hp -= defence;
        Debug.Log(defence + "�_���[�W�󂯂�");
    }
}
public class Test : MonoBehaviour
{
    int hello(int day)
    {
        Debug.Log("����ɂ���"+ day) ;
        int c = day + 3;
        return c;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("����ɂ����I");
        int score;
        score = 150;
        Debug.Log(score);

        int money = 200;
        if(money >= 200)
        {
            Debug.Log("�|�[�V�������w������");
        }
        else if(money >= 100)
        {
            Debug.Log("�Ȃ߂����𔃂���");
        }
        else
        {
            Debug.Log("����𔄂���");
        }
        int sanko = (money >= 100) ? 100 : 200;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        int[] hairetu = new int[4] {2,55,2,5};
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("�z��̒l" + i + "��" + hairetu[i]);
        }
        int[] ani = { 33, 44, 55, 22, 66, 77 };
        for (int i = 0; i < 6; i++)
        {
            if(ani[i]>= 50)
            {
                Debug.Log(ani[i]);
            }
        }
        Debug.Log(hello(30));

        Midboss boss = new Midboss();
        boss.atack();
        boss.defend(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
