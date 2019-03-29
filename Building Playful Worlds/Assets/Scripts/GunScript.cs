
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public AudioSource audioSource;
    public AudioClip shotClip;
    public AudioClip hitClip;

    public Image hitCHImage;
    float hitCHDisplayTimer;
    public float hitCHDisplayDelay = 0.2f;
    public bool shotHit = false;
    public float impactForce = 30f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (shotHit == true)
        {
            Timer();
        }

    }

    public void ShotHit()
    {
        shotHit = true;
        hitCHDisplayTimer = hitCHDisplayDelay;
        hitCHImage.gameObject.SetActive(true);
        
    }
    void Shoot()
        {
            muzzleFlash.Play();
            audioSource.PlayOneShot(shotClip);

            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                SpinScript target = hit.collider.transform.GetComponent<SpinScript>();
                if (target != null)
                {
                    audioSource.PlayOneShot(hitClip);
                    target.TakeDamage(damage);
                    ShotHit();
           
                }
            
                if (hit.rigidbody != null)
                {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
                }

                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
        }

    void Timer()
    {
        if (hitCHDisplayTimer > 0)
            hitCHDisplayTimer -= Time.deltaTime;

        else
        {
            hitCHImage.gameObject.SetActive(false);
            shotHit = false;
        }
    }
}
