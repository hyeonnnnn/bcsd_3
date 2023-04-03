using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {

        // new로 메모리를 할당
        Queue queue = new Queue();

        // 새로운 요소 추가
        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(i);
        }

        // 저장된 요수의 개수
        Debug.Log($"Queue Count : {queue.Count}");

        // 요소를 삭제하지 않고 반환만
        Debug.Log($"Queue Count : {queue.Count}");

        // 요소를 삭제하고 반환
        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");
        Debug.Log($"Queue Count : {queue.Count}");

        // 모든 요소 삭제
        queue.Clear();
        Debug.Log($"Queue Count : {queue.Count}");

    }
}