using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Examine")]
public class Examine : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        if (CheckItems(controller, controller.player.currentLocation.items, noun))
            return;
        if (CheckItems(controller, controller.player.inventory, noun))
            return;
        controller.currentText.text = "You cant see a " + noun;
    }

    private bool CheckItems(GameContorller contorller, List<Item> items, string noun)
    {
        foreach (Item item in items)
        {
            if(item.itemName == noun)
            {
                if(item.InteractiWith(contorller, "examine"))
                {
                    return true;
                }
                   
                contorller.currentText.text = "You see" + item.description;
                return true;
            }
        }
        return false;
    }
}
