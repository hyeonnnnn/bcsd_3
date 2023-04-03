using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }

        // 저장된 요소의 개수
        Debug.Log($"Stack Count : {stack.Count}");

        // 최상위 요소를 삭제하지 않고 반환만
        Debug.Log($"마지막에 추가된 요소 : {stack.Peek()}");
        Debug.Log($"Stack Count : {stack.Count}");

        // 최상위 요소를 삭제하고 반환
        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");
        Debug.Log($"Stack Count : {stack.Count}");

        // 모든 요소 삭제
        stack.Clear();
        Debug.Log($"Stack Count : {stack.Count}");

    }

}