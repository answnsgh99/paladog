using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBS : PlayerChar
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
        hp = 10;
        damage = 2;

    }
}
