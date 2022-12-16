using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/TalkTo")]
public class TalkTo : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        if (TalkToItem(controller, controller.player.currentLocation.items, noun))
        {
            return;
        }
        controller.currentText.text = "There is no "+ noun+ " here";
    }

    private bool TalkToItem(GameContorller contorller, List<Item> items, string noun)
    {

            foreach (Item item in items)
            {
                if(item.itemName == noun && item.itemEnabled)
                {
                    if(contorller.player.CanTalkToItem(contorller, item))
                    {
                        if(item.InteractiWith(contorller, "talkto"))
                        {
                            return true;
                        }
                    }

                    
                    contorller.currentText.text = "The " + noun + " doesn't respond";
                    return true;
                }
            }
            return false;
        }
        
}
