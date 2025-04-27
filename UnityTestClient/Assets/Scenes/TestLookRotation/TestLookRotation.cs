using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//参考 https://blog.csdn.net/weixin_44962938/article/details/121655174
public class TestLookRotation : MonoBehaviour
{
    public Transform Sphere;
    public Transform Cone;

    //测试LookRotation1个还是2个参数的方法
    public bool OneParam = false;

    void Update()
    {
        if(!OneParam)
        {
            Vector3 dir = Sphere.position - transform.position;
            Quaternion ang = Quaternion.LookRotation(dir, Cone.up);  //传入第二个参数为cone.up
            transform.rotation = ang;

            Debug.DrawRay(transform.position, transform.forward * 100, Color.blue);
            Debug.DrawRay(transform.position, dir, Color.green);
            Debug.DrawRay(transform.position, ang.eulerAngles, Color.red);
            Debug.DrawRay(Cone.position, Cone.up, Color.green);  //绘制cone.up方向的绿射线
            Debug.DrawRay(Cone.position, Vector3.Cross(Cone.up, transform.forward), Color.red);  //绘制圆锥up方向与正方体forward方向的叉乘方向的红射线
        }
        else
        {
            Vector3 dir = Sphere.position - transform.position;  //正方体指向球体的向量dir = 球体坐标 - 正方体坐标
            Quaternion ang = Quaternion.LookRotation(dir);  //创建一个 使正方体朝向球体的旋转角
            transform.rotation = ang;  //使正方体朝向球体

            Debug.DrawRay(transform.position, transform.forward * 100, Color.blue);  //绘制正方体forward
            Debug.DrawRay(transform.position, dir, Color.green);  //绘制向量dir
            Debug.DrawRay(transform.position, ang.eulerAngles, Color.red);
        }
    }

    // void OnDrawGizmos()
    // {
    //     Vector3 dir = Sphere.position - transform.position;
    //     Quaternion ang = Quaternion.LookRotation(dir, Cone.up);  //传入第二个参数为cone.up
    //     transform.rotation = ang;
    //      Debug.DrawRay(transform.position, transform.forward * 100, Color.blue);
    //     Debug.DrawRay(transform.position, dir, Color.green);
    //     Debug.DrawRay(transform.position, ang.eulerAngles, Color.red);
	// 	Debug.DrawRay(Cone.position, Cone.up, Color.green);  //绘制cone.up方向的绿射线
	// 	Debug.DrawRay(Cone.position, Vector3.Cross(Cone.up, transform.forward), Color.red);  //绘制圆锥up方向与正方体forward方向的叉乘方向的红射线
    // }
}
