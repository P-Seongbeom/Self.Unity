using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float MinSpawnRate = 0.5f;
    public float MaxSpawnRate = 3f;
    public Transform Target;    //외부에서 타겟지정을 유연하게 하기 위해서 public으로 열어둠

    private float _elapsedTime = 0f;
    private float _spawnRate = 0f;


    void Start()
    {
        _spawnRate = getRandomSpawnRate();

        //Target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _spawnRate)
        {
            _elapsedTime = 0f;

            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);  //위치랑 회전이 랜덤하게 생성되기 때문에 2,3번째 인자가 필요함
            bullet.transform.LookAt(Target);

            _spawnRate = getRandomSpawnRate();
        }
    }

    private float getRandomSpawnRate() => Random.Range(MinSpawnRate, MaxSpawnRate);
    //{
    //    return Random.Range(MinSpawnRate, MaxSpawnRate);
    //}
}
