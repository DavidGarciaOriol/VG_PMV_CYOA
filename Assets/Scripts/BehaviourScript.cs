using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BehaviourScript : MonoBehaviour
{

    public BehaviourScript()
    {
        Debug.Log("Constructor");
    }

    ~BehaviourScript()
    {
        Debug.Log("Destructor");
    }

    // Awake
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // On Enable
    private void OnEnable()
    {
        Debug.Log("On Enable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    // FixedUpdate

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // On Disable
    private void OnDisable()
    {
        Debug.Log("On Disable");
    }

    // On Destroy
    private void OnDestroy()
    {
        Debug.Log("On Destroy");
    }

    // On Application Quit
    private void OnApplicationQuit()
    {
        Debug.Log("On Application Quit");
    }

    // On Application Pause
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("On Application Pause");
    }
}
