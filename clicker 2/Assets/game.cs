using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public TMP_Text scoreText;
    public float cScore;
    public float hitPower;
    public float CPS;
    public float x;

    public int shop1price;
    public TMP_Text shop1text;

    public int shop2price;
    public TMP_Text shop2text;

    public int shop3price;
    public TMP_Text shop3text;

    public int shop4price;
    public TMP_Text shop4text;

    public int finalprice;
    public TMP_Text finaltext;

    public TMP_Text amount1Text;
    public int amount1;
    public float CPS1;

    public TMP_Text amount2Text;
    public int amount2;
    public float CPS2;

    public TMP_Text amount3Text;
    public int amount3;
    public float CPS3;

    public TMP_Text amount4Text;
    public int amount4;
    public float CPS4;

    public int upgradePrize;
    public TMP_Text upgradeText;

    void Start()
    {
        cScore = 0;
        hitPower = 1;
        CPS = 1;
        x = 0f;

        //

        shop1price = 25;
        shop2price = 125;
        shop3price = 500;
        shop4price = 2000;
        finalprice = 9000;
        amount1 = 0;
        CPS1 = 1;
        amount2 = 0;
        CPS2 = 5;
        amount3 = 0;
        CPS3 = 10;
        amount4 = 0;
        CPS4 = 20;

        // load

    }

    void Update()
    {
        scoreText.text = (int)cScore + " ";
        CPS = x * Time.deltaTime;
        cScore = cScore + CPS;

        shop1text.text = "Building 1: " + shop1price;
        shop2text.text = "Building 2: " + shop2price;
        shop3text.text = "Building 3: " + shop3price;
        shop4text.text = "Building 4: " + shop4price;
        finaltext.text = "End this nightmare: " + finalprice;


        amount1Text.text = "Lvl 1: " + amount1 + "x, points/s:  " + CPS1;
        amount2Text.text = "Lvl 2: " + amount2 + "x, points/s:  " + CPS2;
        amount3Text.text = "Lvl 3: " + amount3 + "x, points/s:  " + CPS3;
        amount4Text.text = "Lvl 4: " + amount4 + "x, points/s:  " + CPS4;

        upgradeText.text = "Upgrade click " + upgradePrize;
    }
        public void Hit()
    {
        cScore += hitPower;
    }

    public void Shop1()
    {
        if (cScore>=shop1price)
        {
            cScore -= shop1price;
            amount1 += 1;
            CPS1 += 1;
            x += 1;
            shop1price += 25;
        }
    }

    public void Shop2()
    {
        if (cScore >= shop2price)
        {
            cScore -= shop2price;
            amount2 += 1;
            CPS2 += 5;
            x += 5;
            shop2price += 125;
        }
    }

    public void Shop3()
    {
        if (cScore >= shop3price)
        {
            cScore -= shop3price;
            amount3 += 1;
            CPS3 += 10;
            x += 10;
            shop3price += 500;
        }
    }

    public void Shop4()
    {
        if (cScore >= shop4price)
        {
            cScore -= shop4price;
            amount4 += 1;
            CPS4 += 20;
            x += 20;
            shop4price += 2000;
        }
    }

    public void Final()
    {
        if (cScore >= finalprice)
        {
            cScore -= finalprice;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Upgrade()
    {
        if (cScore>=upgradePrize)
        {
            cScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 12;
        }
    }
}
