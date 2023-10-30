using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSquare : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D rayHit = Physics2D.Raycast(clickPos, Vector2.zero);
            if(rayHit.collider != null && rayHit.collider.gameObject == this.gameObject)
            {
                HPManager hPManager = GameObject.Find("Canvas").GetComponent<HPManager>();
                hPManager.Damage();
                Destroy(this.gameObject);
            }
        }
    }
}
