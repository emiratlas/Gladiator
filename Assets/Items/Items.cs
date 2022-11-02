using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Items", menuName = "Items", order = 1)]
public class Items : ScriptableObject
{   
    public int Attackpower;
    public int MagicPower;
    public int DefancePower;
    public string ItemName;
    public GameObject ItemObject;
    public GameObject ShopObject;

}
