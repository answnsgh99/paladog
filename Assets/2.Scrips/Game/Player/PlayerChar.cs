using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChar : MonoBehaviour
{
    [SerializeField] private List<Sprite> normalSprites;
    [SerializeField] private List<Sprite> attackSprites;
    [SerializeField] private List<Sprite> hitSprites;
    [SerializeField] private List<Sprite> deadSprites;

    private SpriteAnimation sa;
    private Enemy e;

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
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    void Stop(Enemy e)
    {

        if (transform.position.x - e.transform.position.x < 0.7f)
        {
            isMove = false;
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isMove = false;
            sa.SetSprite(hitSprites, 0.2f);
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
