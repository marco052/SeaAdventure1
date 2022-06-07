using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnAreaHard : MonoBehaviour
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
            Vector3 enemyPosition2 = new Vector3(Random.Range(-x2, x2), gameObject.transform.position.y, gameObject.transform.position.z);
            Vector3 enemyPosition3 = new Vector3(Random.Range(-x2, x2), gameObject.transform.position.y, gameObject.transform.position.z);
            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);
            GameObject newEnemy2 = Instantiate(enemy, enemyPosition2, Quaternion.identity);
            GameObject newEnemy3 = Instantiate(enemy, enemyPosition3, Quaternion.identity);
            enemy.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Prior");
            Destroy(gameObject);
        }

    }
}
