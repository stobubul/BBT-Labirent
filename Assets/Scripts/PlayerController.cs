using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public GameObject winText;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue =
            Input.GetAxis("Horizontal"); // Dikey Hareket horizontalValue günceller (sağ ok=1, sol ok= -1)
        float verticalValue = Input.GetAxis("Vertical"); // Dikey Hareket verticalValue günceller (üst ok=1, alt ok= -1)

        Vector3 direction = new Vector3(horizontalValue, 0, verticalValue);
        rb.AddForce(direction * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
            winText.SetActive(true);
    }
}