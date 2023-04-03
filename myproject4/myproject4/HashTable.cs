﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        // new로 메모리를 할당
        Hashtable hash = new Hashtable();

        // 컬렉션 자료구조는 object 타입을 저장하기 때문에 클래스 인스턴스도 저장 가능
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        // 요소 추가 ( [] 연산자 )
        hash["Goblin"] = goblin;

        // 요소 추가 ( Add 메소드 )
        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요. 고박사입니다.", "문자열");

        // Hashtable, Dictionary 등과 같이 기존의 for문을 활용해
        // 순차적으로 데이터 탐색이 불가능할 때 사용하는 반복문
        // foreach ( 데이터타입 변수명 in 배열 등 데이터 집합)
        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        // "Slime" 키를 가지는 요소가 있는지 탐색
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime 키 존재");
        }

        // "goblin" 값를 가지는 요소가 있는지 탐색
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        // 매개변수에 입력된 "Slime"을 키로 가지는 요소 삭제
        hash.Remove("Slame");

        // 저장된 요소의 개수
        Debug.Log($"Hashtable Count : {hash.Count}");

        // 모든 요소 삭제
        hash.Clear();

        // 저장된 요소의 개수
        Debug.Log($"Hashtable Count : {hash.Count}");

    }
}

public class Goblin { }
public class Slime { }