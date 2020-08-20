using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Tooltip("Shooting rate of the player")]
    public float ShootingRate;

    [Tooltip("Damage on enemy on each hit")]
    public int ShootingDamage;

    [Tooltip("Damage speed with contact with enemy")]
    public int DamageRate;

    [Tooltip("Starting health of the enemy")]
    public int HealthPoint;

    [Tooltip("Starting ammo of the enemy")]
    public int AmmoCount;

    [Tooltip("Shooting sound effect")]
    public AudioClip ShootingAudioClip;

    private Rigidbody rb = null;
    private Vector3 moveDirection = Vector3.zero;
    private bool canShoot;
    private bool canDamage;
    private AudioSource audioSource;
    private GameObject camera = null;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        canShoot = true;
        canDamage = true;
        audioSource.clip = ShootingAudioClip;
        camera = GameObject.FindGameObjectWithTag("MainCamera");

    }

    // Update is called once per frame
    void Update()
    {
        //if (GameManager.Instance.isGameOver)
            return;

       // Shoot();
    }

 
    private void Dead()
    {
        Destroy(gameObject);
    }

   
}
