using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChar : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private List<Sprite> attacksprites;
    [SerializeField] private GameObject en;
    

    private bool isMove = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (isMove == true)
        {
            Move();
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isMove = false;
        GetComponent<SpriteAnimation>().SetSprite(attacksprites, 0.5f);
    }

    public void Distance()
    {
        float distance = Vector2.Distance(transform.position, en.transform.position);
        if (distance <= 2)
        {
            isMove = false;
            GetComponent<SpriteAnimation>().SetSprite(attacksprites, 0.5f);
        }
        
    }

    public void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}
