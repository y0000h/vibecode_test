using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 랜덤 숫자 생성을 위한 Random 객체 생성
            Random random = new Random();

            // 1. 1에서 100 사이의 임의의 정수 생성 (1은 포함, 101은 제외)
            int targetNumber = random.Next(1, 101);

            int attempts = 0; // 시도 횟수를 저장할 변수
            bool isCorrect = false; // 정답을 맞췄는지 여부를 저장할 변수

            Console.WriteLine("숫자 맞추기 게임에 오신 것을 환영합니다! (1-100 사이의 숫자를 맞춰보세요)");

            // 4. 사용자가 정답을 맞출 때까지 게임을 계속 진행하기 위한 while 루프
            while (!isCorrect)
            {
                // 2. 사용자로부터 추측값 입력 받기
                Console.Write("숫자를 입력하세요: ");
                string? input = Console.ReadLine();

                if (input == null) return;

                // 5. 오류 처리: 사용자가 숫자가 아닌 값을 입력했을 경우 처리
                // int.TryParse는 변환 성공 여부를 반환하며, 성공 시 guess 변수에 값을 저장함
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Please enter a valid number");
                    continue; // 시도 횟수를 증가시키지 않고 루프의 처음으로 돌아감
                }

                // 유효한 숫자 입력이므로 시도 횟수 증가
                attempts++;

                // 3. 사용자의 추측값과 목표 숫자 비교
                if (guess < targetNumber)
                {
                    // 추측값이 목표 숫자보다 작으면 "Up" 출력
                    Console.WriteLine("Up");
                }
                else if (guess > targetNumber)
                {
                    // 추측값이 목표 숫자보다 크면 "Down" 출력
                    Console.WriteLine("Down");
                }
                else
                {
                    // 추측값이 목표 숫자와 같으면 정답 처리
                    // 정답 메시지와 총 시도 횟수 출력 후 프로그램 종료
                    Console.WriteLine($"Correct! Total attempts: {attempts}");
                    isCorrect = true; // 루프 종료 조건 설정
                }
            }
        }
    }
}
