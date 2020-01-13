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
    private List<Item> items;
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

    private IPlayerInventory playerInventory;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if(firstUpdate)
        {
            items = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                items.Add(new Sword());
                items.Add(new ShortSword());
                items.Add(new ShortSpear());
                items.Add(new Mace());
                items.Add(new LongSpear());
                items.Add(new GreatSword());
                items.Add(new Club());
                items.Add(new BlackBlade());
                items.Add(new PaddedShirt());
                items.Add(new Mail());
                items.Add(new LeatherCuirass());
                items.Add(new ElvenArmour());
                items.Add(new DarkPrincesDeathShroud());
                print(items);
            }
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
        items.Remove(new Sword());
        playerInventory.AddItem(new Sword());
        player.SubtractCoins(sword.ItemCost);
    }
    public void SellSword()
    {
        sword.isBought = false;
        sword.isSold = true;
        items.Add(new Sword());
        playerInventory.RemoveItem(new Sword());
        player.AddCoins(sword.ItemCost);
    }
    public void BuyShortSword()
    {
        shortSword.isBought = true;
        shortSword.isSold = false;
        playerInventory.AddItem(new ShortSword());
        player.SubtractCoins(shortSword.ItemCost);
    }
    public void SellShortSword()
    {
        shortSword.isBought = false;
        shortSword.isSold = true;
        playerInventory.RemoveItem(new ShortSword());
        player.AddCoins(shortSword.ItemCost);
    }
    public void BuyShortSpear()
    {
        shortSpear.isBought = true;
        shortSpear.isSold = false;
        shortSword.isBought = true;
        shortSword.isSold = false;
        playerInventory.AddItem(new ShortSpear());
        player.SubtractCoins(shortSpear.ItemCost);
    }
    public void SellShortSpear()
    {
        shortSpear.isBought = false;
        shortSpear.isSold = true;
        playerInventory.RemoveItem(new ShortSpear());
        player.AddCoins(shortSpear.ItemCost);
    }
    public void BuyMace()
    {
        mace.isBought = true;
        mace.isSold = false;
        playerInventory.AddItem(new Mace());
        player.SubtractCoins(mace.ItemCost);
    }
    public void SellMace()
    {
        mace.isBought = false;
        mace.isSold = true;
        playerInventory.RemoveItem(new Mace());
        player.AddCoins(mace.ItemCost);
    }
    public void BuyLongSpear()
    {
        longSpear.isBought = true;
        longSpear.isSold = false;
        playerInventory.AddItem(new LongSpear());
        player.SubtractCoins(longSpear.ItemCost);
    }
    public void SellLongSpear()
    {
        longSpear.isBought = false;
        longSpear.isSold = true;
        playerInventory.RemoveItem(new LongSpear());
        player.AddCoins(longSpear.ItemCost);
    }
    public void BuyGreatSword()
    {
        greatSword.isBought = true;
        greatSword.isSold = false;
        playerInventory.AddItem(new GreatSword());
        player.SubtractCoins(greatSword.ItemCost);
    }
    public void SellGreatSword()
    {
        greatSword.isBought = false;
        greatSword.isSold = true;
        playerInventory.RemoveItem(new GreatSword());
        player.AddCoins(greatSword.ItemCost);
    }
    public void BuyClub()
    {
        club.isBought = true;
        club.isSold = false;
        playerInventory.AddItem(new Club());
        player.SubtractCoins(club.ItemCost);
    }
    public void SellClub()
    {
        club.isBought = false;
        club.isSold = true;
        playerInventory.RemoveItem(new Club());
        player.AddCoins(club.ItemCost);
    }
    public void BuyBlackBlade()
    {
        blackBlade.isBought = true;
        blackBlade.isSold = false;
        playerInventory.AddItem(new BlackBlade());
        player.SubtractCoins(blackBlade.ItemCost);
    }
    public void SellBlackBlade()
    {
        blackBlade.isBought = false;
        blackBlade.isSold = true;
        playerInventory.RemoveItem(new BlackBlade());
        player.AddCoins(blackBlade.ItemCost);
    }
    public void BuyPaddedShirt()
    {
        paddedShirt.isBought = true;
        paddedShirt.isSold = false;
        playerInventory.AddItem(new PaddedShirt());
        player.SubtractCoins(paddedShirt.ItemCost);
    }
    public void SellPaddedShirt()
    {
        paddedShirt.isBought = false;
        paddedShirt.isSold = true;
        playerInventory.RemoveItem(new PaddedShirt());
        player.AddCoins(paddedShirt.ItemCost);
    }
    public void BuyMail()
    {
        mail.isBought = true;
        mail.isSold = false;
        playerInventory.AddItem(new Mail());
        player.SubtractCoins(mail.ItemCost);
    }
    public void SellMail()
    {
        mail.isBought = false;
        mail.isSold = true;
        playerInventory.RemoveItem(new Mail());
        player.AddCoins(mail.ItemCost);
    }
    public void BuyLeatherCuirass()
    {
        leatherCuirass.isBought = true;
        leatherCuirass.isSold = false;
        playerInventory.AddItem(new LeatherCuirass());
        player.SubtractCoins(leatherCuirass.ItemCost);
    }
    public void SellLeatherCuirass()
    {
        leatherCuirass.isBought = false;
        leatherCuirass.isSold = true;
        playerInventory.RemoveItem(new LeatherCuirass());
        player.AddCoins(leatherCuirass.ItemCost);
    }
    public void BuyElvenArmour()
    {
        elvenArmour.isBought = true;
        elvenArmour.isSold = false;
        playerInventory.AddItem(new ElvenArmour());
        player.SubtractCoins(elvenArmour.ItemCost);
    }
    public void SellElvenArmour()
    {
        elvenArmour.isBought = false;
        elvenArmour.isSold = true;
        playerInventory.RemoveItem(new ElvenArmour());
        player.AddCoins(elvenArmour.ItemCost);
    }
    public void BuyDarkPrincesDeathShroud()
    {
        darkPrincesDeathShroud.isBought = true;
        darkPrincesDeathShroud.isSold = false;
        playerInventory.AddItem(new DarkPrincesDeathShroud());
        player.SubtractCoins(darkPrincesDeathShroud.ItemCost);
    }
    public void SellDarkPrincesDeathShroud()
    {
        darkPrincesDeathShroud.isBought = false;
        darkPrincesDeathShroud.isSold = true;
        playerInventory.RemoveItem(new DarkPrincesDeathShroud());
        player.AddCoins(darkPrincesDeathShroud.ItemCost);
    }
}
