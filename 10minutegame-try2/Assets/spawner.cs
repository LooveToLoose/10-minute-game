using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject goSpawn;
    public float fDifficulty = 40f;
    float fSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        fSpawn += fDifficulty * Time.deltaTime;
        fDifficulty += 4f * Time.deltaTime;
        while (fSpawn > 0)
        {
            fSpawn -= 1;
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40 - 20f, 0, Random.value * 40 - 20f);
            Quaternion qRot = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            Vector3 v3Scale = new Vector3(Random.value + 0.1f, 10f, Random.value + 0.1f);
            GameObject goCreated = Instantiate(goSpawn, v3Pos, qRot);
            goCreated.transform.localScale = v3Scale;
        }
	}
}
