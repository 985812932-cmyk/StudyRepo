using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    public float zoomSpeed = 2f;
    public float minDistance = 5f;
    public float maxDistance = 20f;
    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player");
       offSet = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offSet; //保持相机对于玩家位置不变

        Vector2 scrollDelta = Mouse.current.scroll.ReadValue(); //获取鼠标滚轮的滚动值
        if (scrollDelta.y != 0)
        {
            float currentDistance = offSet.magnitude; //获取当前相机与玩家的直线距离
            float newDistance = currentDistance - scrollDelta.y * zoomSpeed * 0.005f; //计算新的距离，zoomspeed是缩放倍率，0.005f使缩放更平滑
            newDistance = Mathf.Clamp(newDistance, minDistance, maxDistance); //限制新的距离在最小和最大值之间
            offSet = offSet.normalized * newDistance; //根据新的距离调整偏移量的大小，但保持方向不变
        }
    }
}
