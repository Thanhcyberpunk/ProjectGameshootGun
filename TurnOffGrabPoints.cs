using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;


namespace SniperDemo
{
    public class TurnOffGrabPoints : MonoBehaviour
    {
        public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;

        //public GameObject grabPoint1;
        //public GameObject grabPoint2;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CheckIfGrabbedBySocket()
        {
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

            var childrenCount = objName?.transform.childCount;
            for (int i = 0; i < childrenCount; i++)
            {
                var child = objName.transform.GetChild(i);
                if (child.name.Contains("Second Grab Point"))
                {
                    child.gameObject.SetActive(false);

                }
            }

        }
    }
}