using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed);
    }


}
