using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField] SpriteRenderer[] tiles;
    [SerializeField] Sprite[] groundImg;
    [SerializeField] float speed;

    SpriteRenderer temp;
    private void Start()
    {
        temp = tiles[0];
    }
    private void Update()
    {
        if (GameManager.isGameStart)
        {
            Ground();
        }
    }

    void Ground()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if(-5 >= tiles[i].transform.position.x )
            {
                for(int q = 0; q < tiles.Length; q++)
                {
                    if(temp.transform.position.x < tiles[q].transform.position.x)
                    {
                        temp = tiles[q];
                    }
                }
                tiles[i].transform.position = new Vector2(temp.transform.position.x + 1, -0.3f);
                tiles[i].sprite = groundImg[Random.Range(0, groundImg.Length)];
            }
        }
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed);
        }
    }
}
