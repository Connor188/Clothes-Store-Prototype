using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    [SerializeField] int pounds;
    [SerializeField] TextMeshProUGUI money;
    [SerializeField] TextMeshProUGUI RedShirtBuy;
    [SerializeField] TextMeshProUGUI OrangeShirtBuy;
    [SerializeField] TextMeshProUGUI BlueShirtBuy;
    [SerializeField] TextMeshProUGUI BrownTrousersBuy;
    [SerializeField] TextMeshProUGUI GreenTrousersBuy;
    [SerializeField] TextMeshProUGUI RedTrousersBuy;



    private int shirtEquipped;
    private bool RedShirtOwned;
    private bool OrangeShirtOwned;
    private bool BlueShirtOwned;

    private SpriteRenderer playerShirt;
    private SpriteRenderer playerTrousers;
    private void Awake()
    {
        playerShirt = GameObject.Find("Character Torso").GetComponent<SpriteRenderer>();
        playerTrousers = GameObject.Find("Character Legs").GetComponent<SpriteRenderer>();

        pounds = 1200;
    }
    private void Update()
    {
        Money();

        OwnedClothes();
    }
    private void Money()
    {
        money.SetText("£" + pounds);
    }



    public void BuyRedShirt()
    {

        if(pounds >= 200 && !RedShirtOwned)
        {
            pounds -= 200;

            RedShirtOwned = true;

            playerShirt.color = new Color(0.7f, 0.25f, 0.25f, 1f);

            shirtEquipped = 1;

            RedShirtBuy.SetText("Equipped");
        }else if (RedShirtOwned && shirtEquipped != 1)
        {
            playerShirt.color = new Color(0.7f, 0.25f, 0.25f, 1f);

            shirtEquipped = 1;
            RedShirtBuy.SetText("Equipped");
        }

    }
    public void BuyOrangeShirt()
    {
        if (pounds >= 200 && !OrangeShirtOwned)
        {
            pounds -= 200;

            OrangeShirtOwned = true;

            playerShirt.color = new Color(0.8f, 0.5f, 0.25f, 1f);

            shirtEquipped = 2;

            OrangeShirtBuy.SetText("Equipped");
        }
        else if (OrangeShirtOwned && shirtEquipped != 2)
        {
            playerShirt.color = new Color(0.8f, 0.5f, 0.25f, 1f);

            shirtEquipped = 2;
            OrangeShirtBuy.SetText("Equipped");
        }

    }
    public void BuyBlueShirt()
    {
        if (pounds >= 200 && !BlueShirtOwned)
        {
            pounds -= 200;

            BlueShirtOwned = true;

            playerShirt.color = new Color(0.2f, 0.8f, 0.8f, 1f);

            shirtEquipped = 3;

            BlueShirtBuy.SetText("Equipped");
        }
        else if (BlueShirtOwned && shirtEquipped != 3)
        {
            playerShirt.color = new Color(0.2f, 0.8f, 0.8f, 1f);

            shirtEquipped = 3;
            BlueShirtBuy.SetText("Equipped");
        }
    }






    private void OwnedClothes()
    {
        if(RedShirtOwned && shirtEquipped != 1)
        {
            RedShirtBuy.SetText("Equip");
        }
        if(OrangeShirtOwned && shirtEquipped != 2)
        {
            OrangeShirtBuy.SetText("Equip");
        }
        if(BlueShirtOwned && shirtEquipped != 3)
        {
            BlueShirtBuy.SetText("Equip");
        }

    }
}
