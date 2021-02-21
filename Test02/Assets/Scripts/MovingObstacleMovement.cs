using UnityEngine;

public class MovingObstacleMovement : MonoBehaviour
{    
    // Flag,是否能往左走
    public bool goLeft = true;
    // 移動的速度
    public float moveSpeed = 10f;
    //目標左邊的位置
    public int maxLeftPoint=-7;
    //目標右邊的位置
    public int maxRightPoint=7;

    public void FixedUpdate()
    {
        MovingBetweenLeftRight(maxLeftPoint,maxRightPoint);             
    }

    // 左右間來回移動的函數
    // MaxLeftPoint是目標左邊的位置，MaxRightPoint是目標最右邊的位置
    private void MovingBetweenLeftRight(int MaxLeftPoint, int MaxRightPoint)
    {       
        if (goLeft)
        {
            transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);
            if (transform.position.x < MaxLeftPoint)
                goLeft = false;            
        }
        else
        {
            transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
            if (transform.position.x > MaxRightPoint)
                goLeft = true;            
        }
    }
}
