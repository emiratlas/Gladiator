using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stats : MonoBehaviour
{
    
    public int ad;
    public int ap;
    public int df;
    public int arrow;
    public  static int maxhp;
    public static int maxstam;
    [Header("Texts")]
    [Space(10)]
    public Text adtx,aptx,dftx,arrowtx,maxhptx,maxstamtx;
    [Header("Other")]
    [Space(10)]
    public GameObject buttons;

    void Start()
    {
        adtx.text = $"Attack Power {ad}";
        aptx.text = $"Magic Power {ap}";
        dftx.text = $"Deffance Power {df}";
        arrowtx.text = $"Arrow Power {arrow}";
        maxhptx.text = $"Max Healt {maxhp}";
        maxstamtx.text = $"Max Stamina {maxstam}";
    }
    void FixedUpdate()
    {
        if (GameManager.statspoint >= 1)
        {
            buttons.SetActive(true);
        }
        else
        {
            buttons.SetActive(false);
        }
    }
    public void adlevelup()
    {
        if ((ad < 10) && (GameManager.statspoint >= 1))
        {
            GameManager.statspoint--;
            ad++;
            adtx.text = $"Attack Power {ad}";
        }
    }
        public void aplevelup()
    {
        if ((ap < 10) && (GameManager.statspoint >= 1))
        {
            GameManager.statspoint--;
            ap++;
            aptx.text = $"Magic Power {ap}";
        }
    }
    public void dflevelup()
    {
        if ((df < 10) && (GameManager.statspoint >= 1))
        {
            GameManager.statspoint--;
            df++;
            dftx.text = $"Deffance Power {df}";
        }
    }
    public void arrowlevelup()
    {
        if ((arrow < 10) && (GameManager.statspoint >= 1))
        {
            GameManager.statspoint--;
            arrow++;
            arrowtx.text = $"Arrow Power {arrow}";
        }
    }
        public void maxhplevelup()
    {
        if ((maxhp < 10) && (GameManager.statspoint >= 1))
        {
            GameManager.statspoint--;
            maxhp++;
            maxhptx.text = $"Max Healt {maxhp}";
        }
    }
    public void maxstamlevelup()
    {
        if ((maxstam < 10) && (GameManager.statspoint >= 1))
        {
            GameManager.statspoint--;
            maxstam++;
            maxstamtx.text = $"Max Stamina {maxstam}";
        }
    }
}