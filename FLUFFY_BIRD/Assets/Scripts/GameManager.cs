using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject prefabObstacle;

    [SerializeField]
    Transform parentGameObject;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
            Instantiate(prefabObstacle, parentGameObject);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
