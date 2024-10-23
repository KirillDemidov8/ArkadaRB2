using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public float speed = 0.5f;
    public int xp;
    private Vector2 moveVector;
    [SerializeField] private GameObject gameOver;

    [SerializeField] private GameObject prefabBullet;
    public float speedBullet = 0.5f;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject clon = Instantiate(prefabBullet, transform.position, Quaternion.identity);
            clon.GetComponent<Bullet>().VectorPosishon(Vector3.up, 5);
            clon.name = "PlayerBullet";
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.name == "EnemyBullet")
        {
            Destroy(gameObject);
            gameOver.SetActive(true);
            Debug.Log("444");
        }
       
    }





}
