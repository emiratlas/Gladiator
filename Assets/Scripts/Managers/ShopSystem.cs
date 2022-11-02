using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopSystem : MonoBehaviour
{
    [SerializeField] private Item []WitchItem;
    [SerializeField] int WitchItemInt;
    public GameObject SelectedItem;
    public GameObject Position;
    public GameObject Createdobje;
    public Text text;
    void Start()
    {
        SelectedItem = WitchItem[WitchItemInt].ShopObject;
        Createdobje = Instantiate(SelectedItem,Position.transform);
        Createdobje.AddComponent<ObjectExamine>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeWeapon();
        }

        text.text = $"Silah İsmi {WitchItem[WitchItemInt].ItemName} Gücü {WitchItem[WitchItemInt].Attackpower}";
    }
    void ChangeWeapon()
    {
        Destroy(Createdobje);
        WitchItemInt++;
        SelectedItem = WitchItem[WitchItemInt].ShopObject;
        Createdobje = Instantiate(SelectedItem,Position.transform);
        Position.transform.rotation = Quaternion.identity;
        Createdobje.AddComponent<ObjectExamine>();
    }
}
