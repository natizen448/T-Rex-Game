using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBase : MonoBehaviour
{
    public float mobSpeed = 0;
    public Vector2 StartPosition;
    void Start()
    {
        
    }

    public void OnEnable()
    {
        transform.position = StartPosition;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-1, 0) * Time.deltaTime * mobSpeed);

        if (transform.position.x < -6)
        {
            gameObject.SetActive(false);
        }
    }
}
