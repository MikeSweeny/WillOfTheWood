//FILE: ShopKeeperNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 12/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME: ShopKeeperNpc
//PURPOSE: this class will outline what is supposed to happen with the shop NPCs
public class ShopKeeperNpc : BaseInteractableNpc
{
    private bool firstUpdate = true;
    public AudioSource source;

    private Sword sword;
    private ShortSword shortSword;
    private ShortSpear shortSpear;
    private Mace mace;
    private LongSpear longSpear;
    private GreatSword greatSword;
    private Club club;
    private BlackBlade blackBlade;
    private PaddedShirt paddedShirt;
    private Mail mail;
    private LeatherCuirass leatherCuirass;
    private ElvenArmour elvenArmour;
    private DarkPrincesDeathShroud darkPrincesDeathShroud;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if(firstUpdate)
        {
            inventory = new Inventory();
            inventory.AddItem(new Mace());
            inventory.AddItem(new ShortSword());
            inventory.AddItem(new BlackBlade());
            inventory.AddItem(new LeatherCuirass());
            inventory.AddItem(new Mail());
            firstUpdate = false;     
        }                            
    }
    //Function: OnInteract
    //DESCRIPTION: this function is an override from the parent class so that this npc knows what to do when its interacted with
    //PARAMETERS: None
    //RETURNS: None
    public override void OnInteract()
    {
        if (source)
            source.Play();
        UIEventManager.TriggerOpenShop();
    }

    public override void NextDialogue() { }
    public void BuySword()
    {
        sword.isBought = true;
        sword.isSold = false;
        player.SubtractCoins(sword.ItemCost);
    }
    public void SellSword()
    {
        sword.isBought = false;
        sword.isSold = true;
        player.AddCoins(sword.ItemCost);
    }
    public void BuyShortSword()
    {
        shortSword.isBought = true;
        shortSword.isSold = false;
        player.SubtractCoins(shortSword.ItemCost);
    }
    public void SellShortSword()
    {
        shortSword.isBought = false;
        shortSword.isSold = true;
        player.AddCoins(shortSword.ItemCost);
    }
    public void BuyShortSpear()
    {
        shortSpear.isBought = true;
        shortSpear.isSold = false;
        player.SubtractCoins(shortSpear.ItemCost);
    }
    public void SellShortSpear()
    {
        shortSpear.isBought = false;
        shortSpear.isSold = true;
        player.AddCoins(shortSpear.ItemCost);
    }
    public void BuyMace()
    {
        mace.isBought = true;
        mace.isSold = false;
        player.SubtractCoins(mace.ItemCost);
    }
    public void SellMace()
    {
        mace.isBought = false;
        mace.isSold = true;
        player.AddCoins(mace.ItemCost);
    }
    public void BuyLongSpear()
    {
        longSpear.isBought = true;
        longSpear.isSold = false;
        player.SubtractCoins(longSpear.ItemCost);
    }
    public void SellLongSpear()
    {
        longSpear.isBought = false;
        longSpear.isSold = true;
        player.AddCoins(longSpear.ItemCost);
    }
    public void BuyGreatSword()
    {
        greatSword.isBought = true;
        greatSword.isSold = false;;
        player.SubtractCoins(greatSword.ItemCost);
    }
    public void SellGreatSword()
    {
        greatSword.isBought = false;
        greatSword.isSold = true;
        player.AddCoins(greatSword.ItemCost);
    }
    public void BuyClub()
    {
        club.isBought = true;
        club.isSold = false;
        player.SubtractCoins(club.ItemCost);
    }
    public void SellClub()
    {
        club.isBought = false;
        club.isSold = true;
        player.AddCoins(club.ItemCost);
    }
    public void BuyBlackBlade()
    {
        blackBlade.isBought = true;
        blackBlade.isSold = false;
        player.SubtractCoins(blackBlade.ItemCost);
    }
    public void SellBlackBlade()
    {
        blackBlade.isBought = false;
        blackBlade.isSold = true;
        player.AddCoins(blackBlade.ItemCost);
    }
    public void BuyPaddedShirt()
    {
        paddedShirt.isBought = true;
        paddedShirt.isSold = false;
        player.SubtractCoins(paddedShirt.ItemCost);
    }
    public void SellPaddedShirt()
    {
        paddedShirt.isBought = false;
        paddedShirt.isSold = true;
        player.AddCoins(paddedShirt.ItemCost);
    }
    public void BuyMail()
    {
        mail.isBought = true;
        mail.isSold = false;
        player.SubtractCoins(mail.ItemCost);
    }
    public void SellMail()
    {
        mail.isBought = false;
        mail.isSold = true;
        player.AddCoins(mail.ItemCost);
    }
    public void BuyLeatherCuirass()
    {
        leatherCuirass.isBought = true;
        leatherCuirass.isSold = false;
        player.SubtractCoins(leatherCuirass.ItemCost);
    }
    public void SellLeatherCuirass()
    {
        leatherCuirass.isBought = false;
        leatherCuirass.isSold = true;
        player.AddCoins(leatherCuirass.ItemCost);
    }
    public void BuyElvenArmour()
    {
        elvenArmour.isBought = true;
        elvenArmour.isSold = false;
        player.SubtractCoins(elvenArmour.ItemCost);
    }
    public void SellElvenArmour()
    {
        elvenArmour.isBought = false;
        elvenArmour.isSold = true;
        player.AddCoins(elvenArmour.ItemCost);
    }
    public void BuyDarkPrincesDeathShroud()
    {
        darkPrincesDeathShroud.isBought = true;
        darkPrincesDeathShroud.isSold = false;
        player.SubtractCoins(darkPrincesDeathShroud.ItemCost);
    }
    public void SellDarkPrincesDeathShroud()
    {
        darkPrincesDeathShroud.isBought = false;
        darkPrincesDeathShroud.isSold = true;
        player.AddCoins(darkPrincesDeathShroud.ItemCost);
    }
}
