using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int xp;
    public int damage;
    public float speed;
    List<Vector3> vector3s = new List<Vector3>()
    {
        Vector3.down, Vector3.left , Vector3.down, Vector3.right 
    };
    
    void Update()
    {
        if (xp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        StartCoroutine(MoveEnemy());
    }
    
    private void MoveTranslate(Vector3 v)
    {
       
        transform.Translate(v);
    }
    IEnumerator MoveEnemy()
    {
        

        foreach (var item in vector3s)
        {
           
            MoveTranslate(item);
            yield return new WaitForSeconds(2);
        }


        StartCoroutine(MoveEnemy());

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "PlayerBullet")
        {
            xp--;
            Debug.Log("444");
        }
        
    }

}
