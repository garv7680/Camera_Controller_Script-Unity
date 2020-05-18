using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public float SensX = 3;
    public float SensY = 3;
    
    private float pitch;
    private float yaw;

    private float offsetY = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetCamPos();
        CameraMovement();
    }
    void SetCamPos()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offsetY, player.transform.position.z);
    }
    void CameraMovement()
    {
        pitch += SensY * Input.GetAxis("Mouse Y");
        yaw += SensX * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(-pitch, yaw, 0);
    }
}
