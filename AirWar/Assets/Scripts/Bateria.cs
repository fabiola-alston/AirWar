using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject currentBullet;
    private float speed = 10.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentBullet == null)
        {
            Debug.Log("Space bar pressed. Position: " + transform.position);
            currentBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }

        if (currentBullet != null)
        {
            BulletMove();
        }
    }

    private void BulletMove()
    {
        currentBullet.transform.position += Vector3.up * speed * Time.deltaTime;
        
        if (!IsOnScreen(currentBullet))
        {
            Destroy(currentBullet);
            currentBullet = null;   
        }
    }

    private bool IsOnScreen(GameObject gameObj)
    {
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(gameObj.transform.position);
        return screenPoint.y >= 0 && screenPoint.y <= 1 && screenPoint.x >= 0 && screenPoint.x <= 1;
    }

}
