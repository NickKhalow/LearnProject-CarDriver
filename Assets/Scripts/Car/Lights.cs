using UnityEngine;

namespace Car
{
    public class Lights : MonoBehaviour
    {
        [SerializeField]
        private GameObject tailLights;
        [SerializeField]
        private Material material;

        public void TailLights(bool on)
        {
            tailLights.SetActive(on);
            if (on)
            {
                material.EnableKeyword("_EMISSION");
            }
            else
            {
                material.DisableKeyword("_EMISSION");
            }
        }
    }
}