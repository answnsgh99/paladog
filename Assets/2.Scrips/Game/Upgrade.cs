using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade : MonoBehaviour
{
    
    [SerializeField] private Image[] images;
    [SerializeField] private Sprite[] upSprites;
    private bool isbool;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterUp()
    {
        if (isbool == false)
            return;
        for (int i = 0; i < images.Length; i++)
        {
            images[i].sprite = upSprites[i];
        }
        isbool = false;
    }
}
