using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteAnimation : MonoBehaviour
{
    private SpriteRenderer sr;
    private List<Sprite> sprites;
    private UnityAction action;

    private int index;
    private float delay;
    private float delayTimer;
    private bool loop;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sprites == null || sprites.Count == 0)
            return;

        delayTimer += Time.deltaTime;

        if (delayTimer >= delay)
        {
            delayTimer = 0;

            sr.sprite = sprites[index];
            index++;

            if (index >= sprites.Count)
            {
                if (loop)
                    index = 0;
                else
                {
                    sprites = null;
                    if (action != null)
                    {
                        action();
                        action = null;
                    }

                }

            }

        }

    }

    void SetData(List<Sprite> sprites, float delay, bool loop)
    {
        action = null;
        index = 0;
        delayTimer = float.MaxValue;
        this.delay = delay;
        this.sprites = sprites.ToList();
        this.loop = loop;
    }

    public void SetSprite(List<Sprite> sprites, float delay, bool loop = true)
    {
        SetData(sprites, delay, loop);
    }

    public void SetSprite(List<Sprite> sprites, float delay, UnityAction action, bool loop = true)
    {
        SetData(sprites, delay, loop);
        this.action = action;
    }
}
