using System;

namespace Game
{	
	#region 클래스
			// 사용자 정의 유형으로 속성과 함수가 포함되어 있으며, 클래스를 통해 객체를 생성하여 접근하고 사용할 수 있는 집합체

	public class Monster
	{
		int health;


	}
	#endregion
	class Program
	{
		static void Main(string[] args)
		{
			

			#region 배열
			int[] array = new int[3];
					// 같은 자료형의 변수들로 이루어진 유한 집합
			array[0] = 10;
			array[1] = 20;
			array[2] = 30;
			// 배열은 원하는 원소에 값을 저장 할 수 있으며 배열의 크기는 컴파일이 되는 시점부터 고정된 메모리 공간을 가지게 된다

			#endregion


			#region 박싱과 언박싱
			////박싱 : 값 형식을 참조 형식으로 변환하는 작업

			//int x = 100;         //값 타임

			//object obj = x;     //참조 타임




			////언박싱 : 참조 형식을 값 형식으로 변환하는 작업
			//int result = (int)obj;

			//Console.WriteLine(result);




			#endregion

			#region 클래스의 선언

			Monster monster = new Monster();
			Console.WriteLine(monster);
			#endregion

		}
	}
}