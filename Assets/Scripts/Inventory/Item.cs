using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")] // �������� ������� � ����������

public class Item : ScriptableObject
{
    public string title = "Name";
    public string description = "Description";
    public string properties = "Properties";
    public Sprite icon = null;
}
