using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Player
{

    public class PlayerInteract : MonoBehaviour
    {
        /*       private const float USAGE_DISTANCE = 5f;
               private const float DIALOGUE_COOLDOWN = 3f; 

               [SerializeField] private Camera _camera;
               [SerializeField] private GameObject uiTip;
               [SerializeField] private TextMeshProUGUI dialogue;

               internal bool mayUseItem = false;

               private Items.CollectableItem itemToInteract = null;

               private void Awake()
               {
                   mayUseItem = false;
                   itemToInteract = null;
                   uiTip.SetActive(false);
               }

               private void FixedUpdate()
               {
                   Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
                   Ray ray = _camera.ScreenPointToRay(point);
                   RaycastHit hit;

                   if (Physics.Raycast(ray, out hit, USAGE_DISTANCE))
                   {
                       Items.CollectableItem isCollectable = hit.transform.gameObject.GetComponent<Items.CollectableItem>();
                       mayUseItem = isCollectable != null;
                       itemToInteract = isCollectable;
                   }
                   else
                   {
                       mayUseItem = false;
                       itemToInteract = null;
                   }
               }

               private void Update()
               {
                   if (mayUseItem && itemToInteract != null)
                   {
                       if (!uiTip.activeSelf)
                           uiTip.SetActive(true);

                       if (Input.GetKeyDown(KeyCode.E))
                       {
                           itemToInteract.UseItem();
                           mayUseItem = false;
                           itemToInteract = null;
                       }
                   }
                   else if ((!mayUseItem || itemToInteract == null) && uiTip.activeSelf)
                   {
                       uiTip.SetActive(false);
                   }
               }

               internal IEnumerator SaySomething(string text)
               {
                   dialogue.gameObject.SetActive(true);
                   dialogue.text = text;
                   yield return new WaitForSeconds(DIALOGUE_COOLDOWN);
                   dialogue.gameObject.SetActive(false);
               }
         */
    }
}
