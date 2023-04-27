using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")] // Создание менюшки в инспекторе

public class Item : ScriptableObject
{
    public string Name = "Name";
    public string Description = "Description";
    public Sprite icon = null;
}
