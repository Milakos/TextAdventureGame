using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Location currentLocation;
    public List<Item> inventory = new List<Item>();
    public bool ChangeLocation(GameContorller controller, string connectionNoun)
    {
        Connection connection = currentLocation.GetConnection(connectionNoun);

        if(connection != null)
        {
            if(connection.connectionEnabled)
            {
                currentLocation = connection.location;
                return true;
            }
        }
        return false;
    }

    public void Teleport(GameContorller contorller, Location destination)
    {
        currentLocation = destination;
    }

    internal bool CanGiveToItem(GameContorller controller, Item item)
    {
        return item.playerCanGiveTo;
    }

    internal bool CanTalkToItem(GameContorller contorller, Item item)
    {
        return item.playerCanTalkTo;
    }
    internal bool CanReadItem(GameContorller contorller, Item item)
    {
        if(item.targetItem == null)
            return true;
        if(HasItem(item.targetItem))
            return true;
        if(currentLocation.HasItem(item.targetItem))
            return true;
        return false;
    }

    internal bool CanUseItem(GameContorller contorller, Item item)
    {
        if(item.targetItem == null)
            return true;
        
        if(HasItem(item.targetItem))
            return true;
        if(currentLocation.HasItem(item.targetItem))
            return true;
        return false;
    }

    internal bool HasItemByName(string noun)
    {
        foreach (Item item in inventory)
        {
            if(item.itemName.ToLower() == noun.ToLower())
            {
                return true;
            }
        }
        return false;
    }

    private bool HasItem(Item itemToCheck)
    {
        foreach (Item item in inventory)
        {
            if (item == itemToCheck && item.itemEnabled)
                return true;
        }
        return false;
    }
}
