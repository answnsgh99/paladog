using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBA : PlayerChar
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
        hp = 5;
        damage = 2;

    }
}
