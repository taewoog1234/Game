using System;

namespace Game
{
	class Program
	{
		static void Main(string[] args) //	static void Main( ) : 프로그램이 실행되는 진입점 
		{

			//Console.WriteLine("Hello World!");   // Console.WriteLine() : 특정한 문자열을 출력하는 함수(기능)


			#region 변수
			/*
			// 데이터를 저장할 수 있는 메모리 공강을 생성 하는것

			// 자료형이란? 데이터 저장하기 위한 데이터의 형태를 저장해 주는 것



			//		[정수형]
			// short <- 2 byte
			// int <- 4 byte
			int attack = 10;
			Console.WriteLine("정수형 = "+attack);
			
			//		[실수형]
			// float <- 4 byte
			// double <- 8 byte
			float exp = 99.5f;       // float 할 때는 0,00f 해주기 'f'
			Console.WriteLine("실수형 = "+exp);
			
			//		[문자열형]						 
			string name = "Goblin";// string <- 16 byte
			Console.WriteLine("문자열형 = "+name);
			
			//		[etc.. 기타 형]
			//bool <- 1 byte	"참 와 거짓 나타냄"
			bool data = false;     
			Console.WriteLine("etc 기타형 = "+data);

			//		[문자형]
			// char <- 1 byte
			char alphaber = 'a';
			Console.WriteLine("문자형 = "+alphaber); 
			*/

			#endregion

			#region 변수의 이름 규칙

			// 1. 변수의 이름은 숫자로 시작이 불가능 하다  ex)  {5a = 'x'} But {a5 = 'O'}

			// 2. 변수위 이름에 공백이 포함될 수 없다 ex) {int level up = "X"}

			// 3. 변수의 이름은 대문자 소문자 구분

			// 4. 변수의 이름으로 예약어를 사용할 수 없습니다.	ex) {int int =10 (불가능)}

			// 5. 변수의 이름으로 특수 기호는 "_"만 사용 가능합니다 ex) {int level_up = 1; => 'O'} But {int level* % ^ !up = 1; => 'X'}

			#endregion

			#region 상수
			
			/*
			// 프로그램이 생행되는 동안 더 이상 변경할 수 없는 메모리 공간이다.
			// 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며 한번 저장된 값은 변경 할 수 없다.
			// const 사용시 상수로 변함 ex) const int data =10 {const + 변수 + 변수명} 

			int a = 0;
			a = 100;

			const float pi = 3.141592f;
			// 심볼릭 상수란? 메모리 공간은 가지고 있는 상수
			
			// 리터럴 상수란? 메모리를 가지고 있지 않응 상수
			Console.WriteLine(pi);*/
			#endregion
		}
	}
}

