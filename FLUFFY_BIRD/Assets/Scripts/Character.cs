using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    GameObject character;

    Rigidbody2D chaRigidbody2D;
    Animator chaAnimator;

    private void Awake()
    {
        chaRigidbody2D = character.GetComponent<Rigidbody2D>();
        chaAnimator = character.GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log(chaRigidbody2D.velocity.y);
        chaAnimator.SetFloat("Velocity", chaRigidbody2D.velocity.y);

        if((Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("¹öÆ° ´©¸§");
            chaRigidbody2D.velocity = Vector3.zero;
            chaRigidbody2D.AddForce(Vector3.up * 300);
        }

        if(character.GetComponent<Transform>().position.y <= -3.03f)
        {
            Debug.Log("¶¥¿¡ ´ê¾Æ Áê±Ý");
        }
    }
}
