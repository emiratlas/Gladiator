using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopSystem : MonoBehaviour
{
    [SerializeField] private Items []WitchItem;
    [SerializeField] int WitchItemInt;
    public GameObject SelectedItem;
    public GameObject Position;
    public GameObject Createdobje;
    public Text text;

    public Image adimage,apimage,defanceimage;
    void Start()
    {
        SelectedItem = WitchItem[WitchItemInt].ShopObject;
        Createdobje = Instantiate(SelectedItem,Position.transform);
        Createdobje.AddComponent<ObjectExamine>();
    }
    void Update()
    {
        adimage.fillAmount = (WitchItem[WitchItemInt].Attackpower / 100f);
        apimage.fillAmount = (WitchItem[WitchItemInt].MagicPower / 100f);
        defanceimage.fillAmount = (WitchItem[WitchItemInt].DefancePower / 100f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeWeapon();
        }

        text.text = $"Silah İsmi {WitchItem[WitchItemInt].ItemName}";
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
