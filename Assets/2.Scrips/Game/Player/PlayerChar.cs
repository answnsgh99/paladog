using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChar : MonoBehaviour
{
    [SerializeField] private List<Sprite> normalSprites;
    [SerializeField] private List<Sprite> attackSprites;
    [SerializeField] private List<Sprite> hitSprites;
    [SerializeField] private List<Sprite> deadSprites;

    private Enemy e;
    private SpriteAnimation sa;

    protected float speed;
    protected float damage;
    protected int hp { get; set; }

    private bool isMove = true;
    private bool isAttack = false;

    protected virtual void initialize()
    {
        sa = GetComponent<SpriteAnimation>();
    }

    void Update()
    {
        if (isMove == false)
            return;
        Move();
    }
    void Move()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
    void Attack()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isMove = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Enemy")
        {
            isAttack = true;
            sa.SetSprite(attackSprites, 0.5f);

            /*GameObject target = GameObject.Find(collision.gameObject.name);
            target.GetComponent<Enemy>().*/
        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        isAttack = false;
        isMove = true;
        sa.SetSprite(normalSprites, 0.2f);
    }

}
