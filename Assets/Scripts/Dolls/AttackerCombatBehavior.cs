﻿using UnityEngine;
using UnityEditor;
using static Utilities;
using System.Collections.Generic;

// Air Unit
public class AttackerCombatBehavior : IDollsCombatBehaviour
{
    Vector3 airBase = new Vector3(-250, 0, 150);
    public Vector3 flyEndCord;
    private DollsCombat context;
    private Queue<Hex> toCancelFog;
    public float airSpeed;
    private long timenow;
    private float time;

    void Start()
    {
        toCancelFog = new Queue<Hex>();
        transform.position = airBase;
    }

    public override void CheckEnemy(DollsCombat context)
    {
        if (context.supportTargetCord != null)
        {
            context.thisUnit.EngineSound.volume = 1f;
            if (firstTime)
            {
                context.Invoke("resetCord", context.resetTime);
                float distance = Vector3.Distance(transform.position, context.supportTargetCord.position);
                time = distance / airSpeed;
                //transform.position = Vector3.Lerp(transform.position, flyEndCord, time);
                firstTime = false;
            }
            transform.position = Vector3.Lerp(transform.position, flyEndCord, Time.deltaTime / time);
            AirRecon(context);
            if (transform.position.x > context.supportTargetCord.position.x - 20)
            {
                for (int i = 0; i < context.enemy.Count; i++)
                {
                    try
                    {
                        if (Find_Distance(transform.gameObject, context.enemy[i].gameObject) <= 50)
                        {
                            if (context.enemy[i].enemy.enemy_visible == true && context.enemy[i].gameObject.activeSelf)
                            {
                                if (context.canFire)
                                {
                                    context.planeVelocity = 0.4f * (flyEndCord - transform.position).normalized;
                                    context.setEnemy = context.enemy[i];
                                    context.counter = 0;
                                    context.Attack();
                                    StartCoroutine(context.FireRate());
                                }
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        else
        {
            context.thisUnit.EngineSound.volume = 0f;
            transform.position = airBase;
        }
    }
    public void AirRecon(DollsCombat context)
    {
        Hex NextTile;
        for (int i = 0; i <= context.map.transform.childCount - 1; i++)
        {
            try
            {
                NextTile = context.map.transform.GetChild(i).GetComponent<Hex>();
                if (Find_Distance(gameObject, NextTile.gameObject) <= 17.5 * context.dolls.dolls_view_range && NextTile.isInFog == 0)
                {
                    if (!NextTile.blockVision)
                    {
                        NextTile.isInFog += 1;
                        toCancelFog.Enqueue(NextTile);
                        Invoke("DeFogOfWarOneAtATime", 10f);
                    }
                }
                NextTile.ChangeTheFog();

            }
            catch
            {
                continue;
            }
        }
    }
    void DeFogOfWarOneAtATime()
    {
        try
        {
            Hex hex = toCancelFog.Dequeue();
            hex.isInFog -= 1;
            hex.ChangeTheFog();
        }
        catch
        {
        }
    }
}