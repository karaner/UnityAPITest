//This example shows how the rotation works between two GameObjects. Attach this to a GameObject.
//Make sure to assign the GameObject you would like your GameObject to rotate towards in the Inspector

using UnityEngine;

public class SetFromToRotationExample : MonoBehaviour
{
    //This is the Transform of the second GameObject
    public Transform m_NextPoint;
    Quaternion m_MyQuaternion;
    float m_Speed = 1.0f;

    public bool IsTestStaticMethod = false;

    void Start()
    {
        m_MyQuaternion = new Quaternion();
    }

    void Update()
    {
        if(IsTestStaticMethod)
        {
            //Set the Quaternion rotation from the GameObject's position to the next GameObject's position
            m_MyQuaternion.SetFromToRotation(transform.right, m_NextPoint.position - transform.position);

            //Rotate the GameObject towards the second GameObject
            transform.rotation = m_MyQuaternion * transform.rotation;
        }
        else
        {
            m_MyQuaternion = Quaternion.FromToRotation(transform.right, m_NextPoint.position - transform.position);
            transform.rotation = m_MyQuaternion * transform.rotation;
        }
    }
}