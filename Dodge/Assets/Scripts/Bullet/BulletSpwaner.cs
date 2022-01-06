using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpwaner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float MinSpawnRate = 0.5f;
    public float MaxSpawnRate = 3f;
    public Transform Target;    //�ܺο��� Ÿ�������� �����ϰ� �ϱ� ���ؼ� public���� �����

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

            GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);  //��ġ�� ȸ���� �����ϰ� �����Ǳ� ������ 2,3��° ���ڰ� �ʿ���
            bullet.transform.LookAt(Target);

            _spawnRate = getRandomSpawnRate();
        }
    }

    private float getRandomSpawnRate() => Random.Range(MinSpawnRate, MaxSpawnRate);
    //{
    //    return Random.Range(MinSpawnRate, MaxSpawnRate);
    //}
}
