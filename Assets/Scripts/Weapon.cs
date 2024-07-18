using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Gun[] loadout;
    public Transform weaponParent;

    private GameObject currentWeapon;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Equip(0);
        else if (Input.GetKeyDown(KeyCode.Alpha2)) Equip(1);
        else if (Input.GetKeyDown(KeyCode.Alpha3)) Equip(2);
    }

    void Equip(int p_ind)
    {
        if (currentWeapon != null)
        {
            Destroy(currentWeapon);
        }

        GameObject t_newWeapon = Instantiate(loadout[p_ind].prefab, weaponParent) as GameObject;
        currentWeapon = t_newWeapon;
        currentWeapon.transform.localScale = Vector3.one;
        //currentWeapon.transform.localPosition = Vector3.zero;
        //currentWeapon.transform.localEulerAngles = Vector3.zero;

        player.GetComponent<PlayerMovementAdvanced>().walkSpeed = loadout[p_ind].walkSpeed;
        player.GetComponent<PlayerMovementAdvanced>().sprintSpeed = loadout[p_ind].runSpeed;
        player.GetComponent<PlayerMovementAdvanced>().slideSpeed = loadout[p_ind].slideSpeed;
    }
}
