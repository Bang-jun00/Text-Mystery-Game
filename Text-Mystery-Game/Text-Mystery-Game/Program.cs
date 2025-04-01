namespace Text_Mystery_Game
{
    internal class Program
    {
        // Text 추리게임
        // 정답을 선택해야하고, 오답시 3번까지는 재도전 가능
        // 3번을 초과하면 Game Over
        // 1~6까지 주사위 굴려서 힌트갯수 랜덤
        // 힌트를 담을 수 있는 배열
        // 힌트 사용시 힌트 나오게 출력
        static void Main(string[] args)
        {
            Game.GameStart();
            Game.GameProgress();
            Game.GameStop(); 
        }
    }
}
