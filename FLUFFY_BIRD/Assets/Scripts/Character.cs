using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    GameObject character;

    void Start()
    {
        
    }

    void Update()
    {
        if((Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("¹öÆ° ´©¸§");
            character.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            character.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 300);
        }

        if(character.GetComponent<Transform>().position.y <= -3.03f)
        {
            Debug.Log("¶¥¿¡ ´ê¾Æ Áê±Ý");
        }
    }
}
