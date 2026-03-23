using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquares : MonoBehaviour
{
    public GameObject squarePrefab; 
    public float spawnRate=1f;
    public int maxSquares = 10; 
    public Vector2 minBounds= new Vector2(-9f,-4f);
    public Vector2 maxBounds= new Vector2(9f,4f);
    private float spawnTimer=0f;

    // Update is called once per frame
    void Update()
    { 
        spawnTimer+=Time.deltaTime;
    if (spawnTimer>= spawnRate && maxSquares> 0){
        maxSquares--;
        spawnTimer=0f;
        SpawnSquare();
    }
        
    }
    private void SpawnSquare(){
        Vector2 randomPos =new Vector2(
            Random.Range(minBounds.x, maxBounds.x),
            Random.Range(minBounds.y, maxBounds.y)
        );
        GameObject square=Instantiate(squarePrefab,randomPos,Quaternion.identity);
    }
}
