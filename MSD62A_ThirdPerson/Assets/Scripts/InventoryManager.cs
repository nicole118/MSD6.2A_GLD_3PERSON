using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InventoryManager : MonoBehaviour
{
    [Tooltip("Number of Items in Inventory")]
    public int numberOfItems = 5;

    [Tooltip("Items Selection Panel")]
    public GameObject itemsSelectionPanel;

    [Tooltip("List Of Items")]
    public List<ItemScriptableObject> itemsAvailable;

    private List<InventoryItem> itemsForPlayer; //items visible to the player during the game

    // Start is called before the first frame update
    void Start()
    {
        itemsForPlayer = new List<InventoryItem>();
        PopulateInventorySpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    ///  This method will generate the inventory items for the player to use during the game. The total number of inventory items cannot exceed
    ///  the number set in the variable numberOfItems.
    /// </summary>
    private void PopulateInventorySpawn()
    {
        for(int i = 0; i < numberOfItems; i++)
        {
            //pick random object form list itemsAvailable
            ItemScriptableObject objItem = itemsAvailable[Random.Range(0, itemsAvailable.Count)];

            //check whether objItem exist in itemsForPlayer. Count how many times an item appears.
                // 1. search inside list itemsForPlayer, where the item is equal to objItem
                // 2. return a list with the amount of times objItem appears
            int countItems = itemsForPlayer.Where(x => x.item == objItem).ToList().Count;

            itemsForPlayer.Add(new InventoryItem()
            {
                item = objItem, quantity = 1
            });

        }

        print("Number of Inventory Items For Player: " + itemsForPlayer.Count);

    }

    public class InventoryItem
    {
        public ItemScriptableObject item { get; set; }
        public int quantity { get; set; }
    }
}
