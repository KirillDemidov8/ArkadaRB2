using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    public int damage;
    Vector3 n;
    void Start()
    {
        Destroy(gameObject, 10);
    }
    public void VectorPosishon(Vector3 v, float sp)
    {
        n = v;
        speed = sp;
    }



    void Update()
    {
        transform.Translate(n * speed * Time.deltaTime);
        
    }
    
    


}
