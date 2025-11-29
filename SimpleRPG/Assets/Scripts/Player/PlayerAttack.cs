using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public WeaponAttack weapon; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            weapon.Attack();
        }
    }

    public void LoadWeapon(WeaponAttack weapon)
    {
        this.weapon = weapon;
    }

    public void UnLoadWeapon()
    {
        this.weapon = null;
    }

}
