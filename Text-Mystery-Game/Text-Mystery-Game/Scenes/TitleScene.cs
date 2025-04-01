using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Mystery_Game.Scenes
{
    public class TitleScene : Scene
    {
        //타이틀 화면에서 게임 이름 출력
        public override void Render()
        {
            Console.WriteLine("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
            Console.WriteLine("★             두두의 사건해결 일지             ★");
            Console.WriteLine("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
        }
        //1.게임시작 2.불러오기 3.게임종료 선택
        public override void Choice()
        {
            Console.WriteLine("1. 게임시작 ");
            Console.WriteLine("2. 불러오기 "); //TODO 아직 미구현, 배움이 더 쌓이면 구현해 볼 예정
            Console.WriteLine("3. 게임종료 ");
        }
        public override void Question() { }
        public override void Result() { }
        public override void Wait() { }



        
        public override void Next()
        {
            
        }
    }
}
