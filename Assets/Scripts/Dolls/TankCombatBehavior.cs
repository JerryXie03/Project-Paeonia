using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utilities;

public class TankCombatBehavior : IDollsCombatBehaviour
{
    private DollsCombat context;
    private Queue<Hex> toCancelFog;

    void Start()
    {
        toCancelFog = new Queue<Hex>();
    }

    public override void CheckEnemy(DollsCombat context)
    {
        for (int j = 0; j < context.enemyList.Count; j++)
        {
            if (context.enemyList[j] == null)
            {
                context.enemyList.RemoveAt(j);
                j = 0;
            }
        }
        if (context.canFire)
        {
            for (int i = 0; i < context.enemyList.Count; i++)
            {
                if (context.enemyList[i] != null)
                {
                    if (context.enemyList[i].enemy.enemy_visible == true && context.enemyList[i].gameObject.activeSelf)
                    {
                        if (FindDistance(transform.gameObject, context.enemyList[i].gameObject) <= 17.32 * (context.dolls.dolls_range + context.rangeBuff))
                        {
                            context.setEnemy = context.enemyList[i];
                            context.counter = 0;
                            context.Attack();
                            StartCoroutine(context.FireRate());
                        }
                    }
                }
            }
        }
    }
}
