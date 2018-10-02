using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUnitSpwan : MonoBehaviour
{
	public GameObject[] enemyUnits;

	// Use this for initialization
	void Start()
	{
		StartCoroutine("RandomUnitCreate");
	}

	// Update is called once per frame
	void Update()
	{

	}

	IEnumerator RandomUnitCreate()
	{
		int randomRange = Random.Range(1, 4);

		Instantiate(enemyUnits[randomRange], transform.position, Quaternion.identity);

		yield return new WaitForSeconds(12f);

		StartCoroutine("RandomUnitCreate");
	}
}
