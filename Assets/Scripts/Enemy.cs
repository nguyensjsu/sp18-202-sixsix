using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof (NavMeshAgent))]
public class Enemy : LivingEntity {
    public enum State { Idle,Chasing,Attacking};
    State currentState;
	NavMeshAgent pathfinder;
	Transform target;
    float attackDistanceThreshold = 1.5f;
    float timeBetweenAttack = 1;
    float nextAttackTime;
    float myCollisionRadius;
    float targetCollisionRadius;
	protected override void Start () {
		base.Start ();
		pathfinder = GetComponent<NavMeshAgent> ();
        currentState = State.Chasing;
        target = GameObject.FindGameObjectWithTag ("Player").transform;
        myCollisionRadius = GetComponent<CapsuleCollider>().radius;
        targetCollisionRadius = target.GetComponent<CapsuleCollider>().radius;
		StartCoroutine (UpdatePath ());
	}


	void Update () {
        if (Time.time > nextAttackTime)
        {
            float sqrDstToTarget = (target.position - transform.position).sqrMagnitude;
            if (sqrDstToTarget < Mathf.Pow(attackDistanceThreshold, 2))
            {
                nextAttackTime = Time.time + timeBetweenAttack;
                //StartCoroutine(Attack());
            }
        }
	}
    IEnumerator Attack() {
        pathfinder.enabled = false;


        Vector3 originalPosition = transform.position;
        Vector3 attackPosition = target.position;
        float attackSpeed = 3;
        float percent = 0;
        while (percent <= 1) {
            percent += Time.deltaTime * attackSpeed;
            float interpolation = (-percent * percent + percent) * 4;
            transform.position = Vector3.Lerp(originalPosition, attackPosition, interpolation);
        yield return null;
        }
        currentState = State.Chasing;
        pathfinder.enabled = true;

    }
	IEnumerator UpdatePath() {
		float refreshRate = .25f;
		while (target != null) {
            if (currentState == State.Chasing)
            {
                Vector3 dirToTarget = (target.position - transform.position).normalized;

                Vector3 targetPosition = target.position-dirToTarget * (myCollisionRadius + targetCollisionRadius);
                if (!dead)
                {
                    pathfinder.SetDestination(targetPosition);
                }
            }
			yield return new WaitForSeconds(refreshRate);
		}
	}
}
