using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Player
{

    [RequireComponent(typeof(Camera))]
    public class PlayerInteract : MonoBehaviour
    {
        internal const float USAGE_DISTANCE = 5f;
        internal bool mayUseItem = false;

        [SerializeField] private GameObject _uiTip;

        private Camera _camera;
        private Interaction.MovableItem _itemToInteract = null;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
            mayUseItem = false;
            _itemToInteract = null;
            _uiTip.SetActive(false);
        }

        private void FixedUpdate()
        {
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, USAGE_DISTANCE))
            {
                Interaction.MovableItem isMovable = hit.transform.gameObject.GetComponent<Interaction.MovableItem>();
                mayUseItem = isMovable != null;
                _itemToInteract = isMovable;
            }
            else
            {
                mayUseItem = false;
                _itemToInteract = null;
            }
        }

        private void Update()
        {
            if (mayUseItem && _itemToInteract != null)
            {
                if (!_uiTip.activeSelf)
                    _uiTip.SetActive(true);

                if (Input.GetMouseButtonDown(0))
                {
                    _itemToInteract.transform.parent = this.transform;
                    mayUseItem = false;
                    _itemToInteract = null;
                }
            }

            else if ((!mayUseItem || _itemToInteract == null) && _uiTip.activeSelf)
                _uiTip.SetActive(false);
            
        }
    }
}
