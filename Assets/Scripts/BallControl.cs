using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    Rigidbody2D Ball_Rigidbody;
    SpriteRenderer Ball_SpriteRenderer;
    SpriteRenderer Edge_SpriteRenderer;

    [SerializeField]
    private float JumpForce;

    [SerializeField]
    private Color []Ball_Color;

    float Highest_Point;

    void Start()
    {
        Ball_Rigidbody = GetComponent<Rigidbody2D>();
        Ball_SpriteRenderer = GetComponent<SpriteRenderer>();

        Ball_SpriteRenderer.color = Ball_Color[0];
        Highest_Point = PlayerPrefs.GetFloat("Highest_Point");
    }

    void Update()
    {
        
    }

    void Jump()
    {
        Ball_Rigidbody.velocity = new Vector2(0, JumpForce);
    }

    void BallColor_Change()
    {
        int number = Random.Range(0, Ball_Color.Length);
        Ball_SpriteRenderer.color = Ball_Color[number];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Edge")
        {         
            Edge_SpriteRenderer = other.gameObject.GetComponent<SpriteRenderer>();
            if (Edge_SpriteRenderer.color == Ball_SpriteRenderer.color)
            {
                Jump();
                BallColor_Change();
                GameManager.instance.point++;
                if (GameManager.instance.point > Highest_Point)
                {
                    Highest_Point = GameManager.instance.point;
                    PlayerPrefs.SetFloat("Highest_Point", Highest_Point);
                }
            }
        }

        if (other.tag == "DieEdge")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
