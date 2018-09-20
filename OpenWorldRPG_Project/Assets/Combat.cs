﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    public Animator animator;
    public HitBox weaponHitBoxScript;
    public AnimationEvent animationEvent;
    public BoxCollider hitBox;

    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();

        hitBox.enabled = false;

        weaponHitBoxScript.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {

        Attack();

    }

    void Attack()
    {
        hitBox.enabled = true;

        weaponHitBoxScript.enabled = true;

        animator.SetBool("IsIdle", false);
        animator.SetBool("IsWalk", false);
        animator.SetBool("IsAttack", true);
    }

    public void StopDamage(string StopDamage)
    {
        animator.SetBool("meleeAttack", false);

        weaponHitBoxScript.enabled = false;

        Health health = hitBox.GetComponent<Health>();

        hitBox.enabled = false;
        Debug.Log("HitBox disabled");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            weaponHitBoxScript.enabled = false;
        }
    }
}
