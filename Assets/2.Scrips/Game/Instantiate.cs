using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{
    [SerializeField] private GameObject ob;
    [SerializeField] private Transform parent;
    [SerializeField] private Slider pcoin;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instantiatechar(int cost)
    {
        
        if (pcoin.value < cost)
            return;

        Instantiate(ob, parent);
        pcoin.value -= cost;
        

    }
}
