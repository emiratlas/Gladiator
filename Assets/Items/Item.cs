using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Items", menuName = "AttackItem", order = 1)]
public class Item : ScriptableObject
{   
    public int Attackpower;
    public string ItemName;
    public GameObject ItemObject;
    public GameObject ShopObject;

}
