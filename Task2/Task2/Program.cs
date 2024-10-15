using System;

class Program{
    static int highscore = 0;
    static string highscorePlayer = "unkown";

    static void Main(string[] args){
        CheckHighscore(100, "ahmed");
        CheckHighscore(150, "omar");
        CheckHighscore(120, "sara");
        CheckHighscore(200, "eman");
    }

    static void CheckHighscore(int score, string playerName){
        if (score > highscore){
            highscore = score;
            highscorePlayer = playerName;
            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New highscore holder is " + playerName);
        }
        else{
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }
    }
}