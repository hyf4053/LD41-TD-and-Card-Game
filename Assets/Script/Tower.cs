using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    private Transform target;

    [Header("Attriibutes")]
    public float range = 300f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    private int attackDamage = 1;

    EnemyHealth enemyHealth;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";


    public GameObject bullet;
    public Transform firePoint;

    // Use this for initialization
    void Start () {
        InvokeRepeating("UpdateTarget",0f,0.5f);
	}
	
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

                if(distanceToEnemy  < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if(nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            enemyHealth = target.GetComponent<EnemyHealth>();
        }

    }
	// Update is called once per frame
	void Update () {
        if (target == null)
        {
            Debug.Log("Target is null");
            return;
        }

        if(fireCountdown <= 0f)
        {
            Shoot();
            Attack();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
	}

    void Attack()
    {
        if (enemyHealth.currentHealth > 0)
        {
            enemyHealth.TakeDamage(attackDamage);
        }
    }


    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bullet, firePoint.position, firePoint.rotation);
        Bullet bulle = bulletGO.GetComponent<Bullet>();

        if(bullet != null)
        {
            bulle.Seek(target);
        }
    }

}
