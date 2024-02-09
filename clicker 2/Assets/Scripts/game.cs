using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text scoreText;
    public float cScore;
    public float hitPower;
    public float CPS;
    public float x;

    public int shop1prize;
    public TMP_Text shop1text;

    public int shop2prize;
    public TMP_Text shop2text;

    public int shop3prize;
    public TMP_Text shop3text;

    public TMP_Text amount1Text;
    public int amount1;
    public float CPS1;

    public TMP_Text amount2Text;
    public int amount2;
    public float CPS2;

    public TMP_Text amount3Text;
    public int amount3;
    public float CPS3;

    public int upgradePrize;
    public TMP_Text upgradeText;



    void Start()
    {
        cScore = 0;
        hitPower = 1;
        CPS = 1;
        x = 0f;
        

        //
        shop1prize = 25;
        shop2prize = 125;
        shop3prize = 450;
        amount1 = 0;
        CPS1 = 0;
        amount2 = 0;
        CPS2 = 0;
        amount3 = 0;
        CPS3 = 0;

        //
        //

        // load

    }

    void Update()
    {
        scoreText.text = (int)cScore + " ";
        CPS = x * Time.deltaTime;
        cScore = cScore + CPS;

        shop1text.text = "Upgrade 1:\n" + shop1prize;
        shop2text.text = "Upgrade 2:\n" + shop2prize;
        shop3text.text = "Upgrade 3:\n" + shop3prize;

        amount1Text.text = "Lvl:" + amount1 + "\npoints/s:  " + CPS1;
        amount2Text.text = "Lvl:" + amount2 + "\npoints/s:  " + CPS2;
        amount3Text.text = "Lvl:" + amount3 + "\npoints/s:  " + CPS3;

        upgradeText.text = "Upgrade click " + upgradePrize;
    }
        public void Hit()
    {
        cScore += hitPower;
    }

    public void Shop1()
    {
        if (cScore>=shop1prize)
        {
            cScore -= shop1prize;
            amount1 += 1;
            CPS1 += 1;
            x += 1;
            shop1prize += 25;
        }
    }

    public void Shop2()
    {
        if (cScore >= shop2prize)
        {
            cScore -= shop2prize;
            amount2 += 1;
            CPS2 += 5;
            x += 5;
            shop2prize += 125;
        }
    }

    public void Shop3()
    {
        if (cScore >= shop3prize)
        {
            cScore -= shop3prize;
            amount3 += 1;
            CPS3 += 15;
            x += 15;
            shop3prize += 450;
        }
    }

    public void Upgrade()
    {
        if (cScore>=upgradePrize)
        {
            cScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 3;
        }
    }
}
