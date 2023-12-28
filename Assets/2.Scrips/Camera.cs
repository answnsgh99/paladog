using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(x, 0f, 0f) * speed);

        Vector3 localPosition = new Vector3(Mathf.Clamp(transform.position.x, 0, 12.2f), 0f, -10f);
        transform.localPosition = localPosition;
    }
}
