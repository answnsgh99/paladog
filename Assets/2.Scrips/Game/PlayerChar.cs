using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChar : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private List<Sprite> attacksprites;
    

    private bool isMove = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (isMove)
        {
            Move();
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isMove = false;
        GetComponent<SpriteAnimation>().SetSprite(attacksprites, 0.5f);
    }

    public void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}
