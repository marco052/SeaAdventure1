using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnArea : MonoBehaviour
{
    public GameObject enemy;
    private float x1, x2, y1;
    // Start is called before the first frame update
    void Start()
    {
        x1 =gameObject.transform.localScale.x;
        x2 = x1/2;

        if(enemy != null){
            Vector3 enemyPosition = new Vector3(Random.Range(-x2, x2), gameObject.transform.position.y, gameObject.transform.position.z);
            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);
            enemy.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Prior");
            Destroy(gameObject);
        }

    }
}
