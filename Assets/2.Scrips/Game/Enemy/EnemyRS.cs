using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRS : Enemy
{

    void Start()
    {
        initialize();
    }
    protected override void initialize()
    {
        base.initialize();
        speed = 1f;
        hp = 10;
        damage = 2;
    }

    

    
    
}
