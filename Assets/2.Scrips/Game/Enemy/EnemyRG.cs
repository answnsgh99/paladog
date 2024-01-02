using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRG : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }
    protected override void initialize()
    {
        base.initialize();
        speed = 1f;
        hp = 30;
        damage = 1;

    }
}
