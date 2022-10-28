using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] float thrustForce = 10f;
    [SerializeField] float tiltingForce = 10f;

    Rigidbody rb;
    bool boost = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.GetAxis("Horizontal"); // Pijltjes input
        boost = Input.GetKey(KeyCode.Space); // Space input
        transform.Rotate(new Vector3(0, 0, tilt * tiltingForce * Time.deltaTime)); // Rotation met de tiltingwaarde die user ingeeft


    }

    private void FixedUpdate()
    {

        if (boost) // als de boost knop wordt in gedrukt!
        {
        
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime * 100); // de relative force houd rekening met de rotatie van object (gebruik je normale force dan zal je object gwn enkel recht naar boven gaan)

        }
    }




}
