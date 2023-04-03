using System.Collections;
using System.Collections.ObjectMode1;
using UnityEngine;

public class ArrayListExercise : MonoBehaviour
{
    private void Awake()
    {
        // new로 메모리 할당
        ArrayList arrayList = new ArrayList();

        // 요소 추가
        Debug.Log(arrayList.Add(10)); 
        PrintArrayList(arrayList);

        // 요소 삽입
        arrayList.Insert(1, 100);
        PrintArrayList(arrayList);

        // 요소 추가
        CollectionBase<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);
        PrintArrayList(arrayList);

        // 데이터 정렬
        arrayList.Sort(); 
        PrintArrayList(arrayList);

        // 요소 삭제 (데이터의 값을 통해)
        arrayList.Remove(10); 
        PrintArrayList(arrayList);

        // 요소 삭제 (요소의 위치를 통해)
        arrayList.RemoveAt(0); 
        PrintArrayList(arrayList);

        // 요소 삭제 (범위)
        arrayList.RemoveRange(0, 2); 
        PrintArrayList(arrayList);

        // 모든 요소 삭제
        arrayList.Clear();

        // 요소 개수 출력
        Debug.Log(arrayList.Count);
    }

     public void PrintArrangeList(ArrayList list)
    {
        Debug.Log("=================================");

        for(int i=0; i < list.Count; ++i)
            Debug.Log($"list[{i}] = {list[i]}");
    }


}
