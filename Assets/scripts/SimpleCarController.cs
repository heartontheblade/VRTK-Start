using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;


    public WheelCollider FLw, FRw, BLw, BRw;
    public Transform FL, FR, BL, BR;
    public float maxSteerAngle = 30;
    public float motorForce = 50;

   

    

    void Start()
    {
        
        //设置车的重心，使车更稳定        
        Vector3 centerOfMass = this.GetComponent<Rigidbody>().centerOfMass;
        centerOfMass.y = -1.5f;
        this.GetComponent<Rigidbody>().centerOfMass = centerOfMass;
    }


    void FixedUpdate()
    {
        
        //if (movable)
        //{
           // print("can");
            GetInput();
            Steer();
            Accelerate();
            UpdateWheelPoses();
        //}
    }

    public void Activate()
    {
        //print("activate car");
        //movable = true;
        //print(movable);
        //mo = true;
     
    }

    public void GetInput()
    {
        //print("getinput");
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");

    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        FLw.steerAngle = m_steeringAngle;
        FRw.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        BLw.motorTorque = m_verticalInput * motorForce;
        BRw.motorTorque = m_verticalInput * motorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(FLw, FL);
        UpdateWheelPose(FRw, FR);
        UpdateWheelPose(BLw, BL);
        UpdateWheelPose(BRw, BR);
    }

    private void UpdateWheelPose(WheelCollider _colider, Transform _transform)
    {
        Vector3 _Pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _colider.GetWorldPose(out _Pos, out _quat);

        _transform.position = _Pos;
        _transform.rotation = _quat;
    }

}
