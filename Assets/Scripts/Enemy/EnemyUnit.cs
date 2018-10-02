using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour {

	//적 유닛 상태 변수
	public enum State { Move, Attack, Dead };
	
	//적 유닛 스피드
	private float enemyUnitSpeed = 0.5f;

	//기본 상태는 이동
	public State state = State.Move;

	//public Transform playerUnit;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		switch (state)
		{
			case State.Move:
				UnitMove();
				break;
			case State.Attack:
				break;
			case State.Dead:
				break;
			default:
				break;
		}
	}
	//적 유닛 이동
	void UnitMove()
	{
		transform.Translate(Vector2.left * enemyUnitSpeed * Time.deltaTime);
	}

	void UnitAttackRange()
	{
		//플레이어가 범위가 1이면
		state = State.Attack;
	}
}
