using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Mystery_Game.Scenes;

namespace Text_Mystery_Game
{
    public static class Game
    {
        //게임에 필요한 정보
        private static bool gameOver; //이 클래스 안에서만 쓸 수 있는 bool 변수 선언
        
        private static Dictionary<string,Scene> sceneDic; // 이 클래스 안에서만 쓸 수있는 Scene 클래스에 대한 자료구조
        private static Scene cutScene; // 이 클래스 안에서만 쓸 수 있는 Scene 클래스에 대한 변수선언

        
        
        //게임 시작시 필요한 기능
        public static void GameStart()
        {
            //게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string,Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("SelectScene", new SelectScene());
            sceneDic.Add("QuestionScene1", new QuestionScene1());
            sceneDic.Add("QuestionScene2", new QuestionScene2());
            sceneDic.Add("QuestionScene3", new QuestionScene3());
            sceneDic.Add("QuestionScene4", new QuestionScene4());
            sceneDic.Add("QuestionScene5", new QuestionScene5());

            //처음으로 보일 타이틀 씬 선정
            cutScene = sceneDic["Title"];
        }

        //게임 진행시 필요한 기능
        public static void GameProgress()
        {
            while(gameOver != true)
            {
                Console.Clear();
                cutScene.Render();
                Console.WriteLine();
                cutScene.Choice();
                cutScene.Input();
                Console.WriteLine();
                cutScene.Result();
                Console.WriteLine();
                cutScene.Wait();
                cutScene.Next();
