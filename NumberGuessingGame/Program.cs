using System;
using System.Text;

// 한글 깨짐 방지 설정
Console.OutputEncoding = Encoding.UTF8;

Random random = new Random();
int targetNumber = random.Next(1, 101);

int attempts = 0; 
bool isCorrect = false; 

Console.WriteLine("숫자 맞추기 게임에 오신 것을 환영합니다! (1-100 사이의 숫자를 맞춰보세요)");

while (!isCorrect)
{
    Console.Write("숫자를 입력하세요: ");
    
    string input = Console.ReadLine();

    if (input == null) break;

    int guess;

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("숫자만 입력해 주세요.");
        continue; 
    }

    attempts++;

    if (guess < targetNumber)
    {
        Console.WriteLine("Up (더 큰 숫자입니다)");
    }
    else if (guess > targetNumber)
    {
        Console.WriteLine("Down (더 작은 숫자입니다)");
    }
    else
    {
        Console.WriteLine($"정답입니다! 총 시도 횟수: {attempts}");
        isCorrect = true; 
    }
}