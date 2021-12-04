using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    Transform initial_t;
    public GameObject go;

    void Start()
    {
        initial_t=gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy(){
        Debug.Log("OnDestroy1");
        Instantiate(go,initial_t);
    }
}
