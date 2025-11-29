using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon_Scythe : WeaponAttack
{
    private Animator animator;
    public const string ANIM_PARM_ISATTACK = "IsAttack";
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    //private void Update()
    //{
    //    if (Keyboard.current.spaceKey.wasPressedThisFrame)
    //    {
    //        Attack();
    //    }
    //}

    public override void Attack()
    {
       animator.SetTrigger(ANIM_PARM_ISATTACK);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //TODO
            Debug.Log("Trriger With" + other.name);
        }
    }
}
