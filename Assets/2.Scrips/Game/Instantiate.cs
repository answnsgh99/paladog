using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{
    [SerializeField] private GameObject ob;
    [SerializeField] private Transform parent;
    [SerializeField] private Slider pcoin;

    private float delay = 1.1f;
    private float delaytimer = float.MaxValue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delaytimer += Time.deltaTime;

    }

    public void Instantiatechar(int cost)
    {
        
        if (pcoin.value < cost || delaytimer < delay)
            return;
        delaytimer = 0;
        Instantiate(ob, parent);
        pcoin.value -= cost;
        

    }
}
