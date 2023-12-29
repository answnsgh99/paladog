using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{
    [SerializeField] private GameObject ob;
    [SerializeField] private Transform parent;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instantiatechar()
    {
        
        Slider pcoin = GetComponent<PCoin>().sd;
        if (pcoin.value < 3)
            return;

        Instantiate(ob, parent);
        pcoin.value -= 3;
        

    }
}
