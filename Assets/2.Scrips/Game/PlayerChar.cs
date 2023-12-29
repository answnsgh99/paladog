using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChar : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private List<Sprite> attacksprites;
    //[SerializeField] private GameObject en;
    

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

    

    public void Attack()
    {
        /*if (isMove == false)
            return;
        if (transform.position.x - en.transform.position.x > -0.7f) 
        {
            isMove = false;
            GetComponent<SpriteAnimation>().SetSprite(attacksprites, 0.5f); 
        }*/

    }

    public void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }
}
