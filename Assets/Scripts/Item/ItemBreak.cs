using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBreak : Interactable
{

    public Item item;
    public List<Item> drops;

    public override void Interact()
    {
        base.Interact();

        Break();

        //TODO : drop logs
        if(drops.Count > 0)
        {
            DropItems(drops);
        }
    }

    void Break()
    {
        Debug.Log("Picking up item" + item.name);

        Destroy(gameObject);
    }

    void DropItems(List<Item> to_drops)
    {
        for (int i = 0; i < to_drops.Count; i++)
        {
            Debug.Log("droping : " + drops[i].name);
        }
    }
}
