using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Mystery_Game.Scenes
{
    //추상클래스로 부모클래스 만들어서 나중에 만들 자식클래스에서 구현할거임
    public abstract class Scene
    {
        protected ConsoleKey input;

        //문제 1~5부터 선택지
        //어떤 문제를 풀건지 콘솔 키 눌러 선택
        public abstract void Render();
        
        public void InputQuestionChoice()
        {
            input = Console.ReadKey(true).Key;
        }

        

        //문제 출제 및 객관식 작성
        public abstract void Question();
        
        public void InputCorrect()
        {
            input = Console.ReadKey(true).Key;
        }

        //여기서 콘솔 키 이용하여 답 선택
        public abstract void Choice();

        //선택한 답을 기준으로 결과 출력
        public abstract void Result();

        //결과를 본 후 기다리는 기능 구현
        public abstract void Wait();

        //다음으로 넘어갈 씬 또는 게임오버를 구현
        public abstract void Next();
        

    }
}
