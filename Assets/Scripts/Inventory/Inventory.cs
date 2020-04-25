using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    //Singleton patern. variable with same name as method
    public static Inventory instance;

    //Static: variable shared by all instances of a class. 
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found !");
            return;
        }

        instance = this;
    }
    #endregion

    //Delegate : event methods can subscribe to. 
    public delegate void OnItemChange();
    public OnItemChange onItemChangedCallBack;

    public int space = 20;

    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("No more space");
                return false;
            }
            items.Add(item);

            //trigger event
            if(onItemChangedCallBack != null)
                onItemChangedCallBack.Invoke();
        }
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();
    }


}
