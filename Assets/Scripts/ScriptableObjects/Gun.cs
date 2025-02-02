using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public string name;
    public GameObject prefab;

    public float walkSpeed;
    public float runSpeed;
    public float slideSpeed;

    public float firerate;
}
