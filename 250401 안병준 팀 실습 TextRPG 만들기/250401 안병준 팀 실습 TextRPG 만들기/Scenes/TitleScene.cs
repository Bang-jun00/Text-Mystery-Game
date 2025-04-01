using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250401_안병준_팀_실습_TextRPG_만들기.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
            Console.WriteLine("★        탐정 스미스의 사건해결         ★");
            Console.WriteLine("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");

        }
        public override void Result() { }                            
        public override void Choice()
        {
            Console.WriteLine("1. 게임시작 ");
            Console.WriteLine("2. 세이브파일 불러오기(미구현)"); //TODO 시간내서 구현 한번 해보자
            Console.WriteLine("3. 게임종료 ");
        }
        public override void Wait() { }        
        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
}
