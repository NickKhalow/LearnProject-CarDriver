using System;
using UnityEngine;

namespace Car
{
    public class Wheel : MonoBehaviour
    {
        [SerializeField]
        private WheelCollider wheelCollider;
        [SerializeField]
        private Transform visual;
        [SerializeField]
        private Vector3 baseVisual = Vector3.up;

        private void Update()
        {
            wheelCollider.GetWorldPose(out _, out var quaternion);
            visual.rotation = quaternion;
            visual.Rotate(baseVisual);
        }

        public void Steer(float angle)
        {
            wheelCollider.steerAngle = angle;
        }

        public void Torque(float power)
        {
            wheelCollider.motorTorque = power;
        }
    }
}