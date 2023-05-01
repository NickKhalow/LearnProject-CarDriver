using System;
using UnityEngine;

namespace Car
{
    public class SimpleCar : MonoBehaviour
    {
        [Header("Steer")]
        [SerializeField]
        private float maxSteer = 45;
        [SerializeField]
        private Wheel[] steerWheels = Array.Empty<Wheel>();
        [Header("Power")]
        [SerializeField]
        private float power = 10;
        [SerializeField]
        private Wheel[] powerWheels = Array.Empty<Wheel>();
        [Space]
        [SerializeField]
        private Lights lights;


        private void Update()
        {
            Turning();
            Powering();
            Lights();
        }

        private void Turning()
        {
            foreach (var wheelCollider in steerWheels)
            {
                wheelCollider.Steer(
                    Input.GetAxis("Horizontal")
                    * maxSteer
                );
            }
        }

        private void Powering()
        {
            foreach (var powerWheel in powerWheels)
            {
                powerWheel.Torque(
                    Input.GetAxis("Vertical")
                    * power
                    * Time.deltaTime
                );
            }
        }

        private void Lights()
        {
            lights.TailLights(Input.GetAxis("Vertical") < 0);
        }
    }
}