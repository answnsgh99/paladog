using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PCoin : MonoBehaviour
{
    [SerializeField] private TMP_Text coinTxt;
    [SerializeField] private Slider sd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sd.value += Time.deltaTime * 1f;
        coinTxt.text = sd.value.ToString("0");
    }
}
