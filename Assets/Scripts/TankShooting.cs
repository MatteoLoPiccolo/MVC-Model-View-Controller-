using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public int player = 1;
    public Rigidbody shell;
    public Transform fireTransform;

    public AudioSource shootingAudio;
    public AudioClip chargingClip;
    public AudioClip fireClip;

    public float minLaunchForce = 15f;
    public float maxLaunchForce = 30f;
    public float maxChargeTime = 0.75f;

    private float currentLaunceForce;
    private float chargeSpeed;
    private bool isFired = false;

    // Start is called before the first frame update
    void Start()
    {
        chargeSpeed = (maxLaunchForce - minLaunchForce) / maxChargeTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLaunceForce >= maxLaunchForce && !isFired)
        {
            currentLaunceForce = maxLaunchForce;
            Fire();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            isFired = false;
            currentLaunceForce = minLaunchForce;

            //shootingAudio.clip = chargingClip;
            //shootingAudio.Play();
        }
        else if (Input.GetKey(KeyCode.Space) && !isFired)
        {
            currentLaunceForce += chargeSpeed * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && !isFired)
        {
            Fire();
        }
    }

    private void Fire()
    {
        isFired = true;

        Rigidbody shellIstance = Instantiate(shell, fireTransform.position, fireTransform.rotation) as Rigidbody;
        shellIstance.velocity = currentLaunceForce * fireTransform.forward;

        //shootingAudio.clip = fireClip;
        //shootingAudio.Play();

        currentLaunceForce = minLaunchForce;
    }
}