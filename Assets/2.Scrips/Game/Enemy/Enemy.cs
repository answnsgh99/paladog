using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Enemy : MonoBehaviour
{
    [SerializeField] private List<Sprite> normalSprites;
    [SerializeField] private List<Sprite> attackSprites;
    [SerializeField] private List<Sprite> hitSprites;
    [SerializeField] private List<Sprite> deadSprites;

    private SpriteAnimation sa;

    protected float speed;
    protected float damage;
    protected int hp { get; set; }

    private bool isMove = true;

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
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

   /* void Attack()
    {

        if (transform.position.x - en.transform.position.x > -0.7f)
        {
            if (isMove == false)
                return;
            isMove = false;
            GetComponent<SpriteAnimation>().SetSprite(attackSprites, 0.5f);
        }
        else if (transform.position.x - en.transform.position.x < -0.7f)
            isMove = true;
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isMove = false;
            sa.SetSprite(attackSprites, 0.5f);
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
