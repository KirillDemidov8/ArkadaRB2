using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAttac : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    float speed = 1f;

    private void Start()
    {
        Attak();
    }
    public void Attak()
    {
        Debug.Log(555);
        GameObject clon = Instantiate(prefabBullet, transform.position, Quaternion.identity);
        clon.GetComponent<Bullet>().VectorPosishon(Vector3.down,speed);
        clon.name = "EnemyBullet";
    }
}
