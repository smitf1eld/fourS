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

    public int Building1Cost;
    public TMP_Text shop1text;

    public int shop2prize;
    public TMP_Text shop2text;

    public TMP_Text amount1Text;
    public int amount1;
    public float CPS1;

    public TMP_Text amount2Text;
    public int amount2;
    public float CPS2;

    public int upgradePrize;
    public TMP_Text upgradeText;

    void Start()
    {
        cScore = 0;
        hitPower = 1;
        CPS = 1;
        x = 0f;

        //
        Building1Cost = 25;
        shop2prize = 125;
        amount1 = 0;
        CPS1 = 1;
        amount2 = 0;
        CPS2 = 5;

        //
        //

        // load

    }

    void Update()
    {
        scoreText.text = (int)cScore + " ";
        CPS = x * Time.deltaTime;
        cScore = cScore + CPS;

        shop1text.text = "Building 1: " + Building1Cost;
        shop2text.text = "Building 2: " + shop2prize;

        amount1Text.text = "Lvl 1: " + amount1 + "x, points/s:  " + CPS1;
        amount2Text.text = "Lvl 2: " + amount2 + "x, points/s:  " + CPS2;

        upgradeText.text = "Upgrade click " + upgradePrize;
    }
        public void Hit()
    {
        cScore += hitPower;
    }

    public void Shop1()
    {
        if (cScore>=Building1Cost)
        {
            cScore -= Building1Cost;
            amount1 += 1;
            CPS1 += 1;
            x += 1;
            Building1Cost += 25;
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
