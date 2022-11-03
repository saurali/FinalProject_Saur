using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //ADD WHAT ROOM YOURE IN WHEN ASKING WHAT THEY WANT TO DO!!! DO THIS TOMMORROW 10/21
    public static void Main(string[] args)
    {
        
        int room = 1; //This keeps track of what room the player is in. 
        string response = ""; //This keeps track of what the player wants to do
        bool gameFinished = false; // keeps track of game status
        bool snakeBite = false; //keeps track of snake bite status
        bool treasureChest = false; //keeps track if you have the treasure chest
        bool keyFound = false; //keeps track if you have the key
        bool antiVenom = false; //keeps track if you have the antivenom

        //This tells the player what is in the room they just entered and goes to the function involving that room
        while (gameFinished == false)
        {

            if (room == 1)
            {
                RoomOne();
            }
            if (room == 2)
            {
                RoomTwo();
            }
            if (room == 3)
            {
                RoomThree();
            }
            if (room == 4)
            {
                RoomFour();
            }
            if (room == 5)
            {
                RoomFive();
            }
            if (room == 6)
            {
                RoomSix();
            }
            
        }

        

        // this is what happens in room 1 (main)
        void RoomOne()
        {
            Console.WriteLine("What would you like to do in room one (plain white)? look, go left, or go right. You can also type open or drink in any room.");
            response = Console.ReadLine();
            if (response == "look")
            {
                Console.WriteLine("You are in a plain white room. It is empty expect for 2 doors.");
            }
            if (response == "go left")
            {
                room = 2;
            }
            if (response == "go right")
            {
                room = 3;
            }
            if (response == "open")
            {
                if (treasureChest == true && keyFound == true)
                {
                    Console.WriteLine("You put the key in the treasure chest and turn it until you here a click. The lid opens and you see a small vile of liquid.");
                    antiVenom = true;
                }
                else
                {
                    Console.WriteLine("You don't have all the necessary things to open this.");
                }
            }
            if (response == "drink")
            {
                if (snakeBite == true && antiVenom == true)
                {
                    Console.WriteLine("You drink the vile, hoping it is the solution to your problem. After a few minutes, you are feeling much better. It worked!");
                    snakeBite = false;
                }
                else
                {
                    Console.WriteLine("You can not drink it at this time.");
                }
            }

        }

        //This is the function that tells what happens in room 2 (mountain)
        void RoomTwo()
        {
            Console.WriteLine("What would you like to do in room 2 (mountain); look, go left, go right, check goat, go back? You can also type open or drink in any room.");
            response = Console.ReadLine();
            if (response == "look")
            {
                Console.WriteLine("You are standing on a large mountain, there are two doors carved into the mountain. There is also a mountain goat. There is a small rusty key tied off a nail stuck in the stone. You put it in your pocket.");
                keyFound = true;
            }
            if (response == "go left")
            {
                room = 4;
            }
            if (response == "go right")
            {
                room = 5;
            }
            if (response == "go back")
            {
                room = 1;
            }
            if (response == "check goat")
            {
                Console.WriteLine("You slowly approach the mountain goat and it charges at you, you are able to run towards the doors. You might want to leave.");
                RoomTwo();
            }
            if (response == "open")
            {
                if (treasureChest == true && keyFound == true)
                {
                    Console.WriteLine("You put the key in the treasure chest and turn it until you here a click. The lid opens and you see a small vile of liquid.");
                    antiVenom = true;
                }
                else
                {
                    Console.WriteLine("You don't have all the necessary things to open this.");
                }
            }
            if (response == "drink")
            {
                if (snakeBite == true && antiVenom == true)
                {
                    Console.WriteLine("You drink the vile, hoping it is the solution to your problem. After a few minutes, you are feeling much better. It worked!");
                    snakeBite = false;
                }
                else
                {
                    Console.WriteLine("You can not drink it at this time.");
                }
            }
        }

        //This is the function that tells what happens in room 3 (beach)
        void RoomThree()
        {
            Console.WriteLine("What would you like to do in room 3 (beach); look, go left, check crab, go back? You can also type open or drink in any room.");
            response = Console.ReadLine();
            if (response == "look")
            {
                Console.WriteLine("You are now on a beach, there is one door. There is a small crab near the water. There is also a small treasure chest, you pick it up and try to open it, it is locked. You should find the key.");
                treasureChest = true;
            }
            if (response == "go left")
            {
                room = 6;
            }
            if (response == "go back")
            {
                room = 1; 
            }
            if (response == "check crab")
            {
                Console.WriteLine("You walk towards the crab and it runs into the water.");
                RoomThree();
            }
            if (response == "open")
            {
                if (treasureChest == true && keyFound == true)
                {
                    Console.WriteLine("You put the key in the treasure chest and turn it until you here a click. The lid opens and you see a small vile of liquid.");
                    antiVenom = true;
                }
                else
                {
                    Console.WriteLine("You don't have all the necessary things to open this.");
                }
            }
            if (response == "drink")
            {
                if (snakeBite == true && antiVenom == true)
                {
                    Console.WriteLine("You drink the vile, hoping it is the solution to your problem. After a few minutes, you are feeling much better. It worked!");
                    snakeBite = false;
                }
                else
                {
                    Console.WriteLine("You can not drink it at this time.");
                }
            }
        }

        //This is the function that tells what happens in room 4 (desert)
        void RoomFour()
        {
            Console.WriteLine("What would you like to do in room 4 (desert)? look, check snake, or go back? You can also type open or drink in any room.");
            response = Console.ReadLine();
            if (response == "look")
            {
                Console.WriteLine("You entered a desert. It is very warm and sandy, but there is no way out other than the door you just came from. There is a snake slithering near a cactus."); 
            }
            if (response == "go back")
            {
                room = 2;
            }
            if (response == "check snake")
            {
                Console.WriteLine("You walk up to the snake and it bites your ankle. Ouch! It seems to be poisonous, you may want to find the cure.");
                snakeBite = true;
                RoomFour();
            }
            if (response == "open")
            {
                if (treasureChest == true && keyFound == true)
                {
                    Console.WriteLine("You put the key in the treasure chest and turn it until you here a click. The lid opens and you see a small vile of liquid.");
                    antiVenom = true;
                }
                else
                {
                    Console.WriteLine("You don't have all the necessary things to open this.");
                }
            }
            if (response == "drink")
            {
                if (snakeBite == true && antiVenom == true)
                {
                    Console.WriteLine("You drink the vile, hoping it is the solution to your problem. After a few minutes, you are feeling much better. It worked!");
                    snakeBite = false;
                }
                else
                {
                    Console.WriteLine("You can not drink it at this time.");
                }
            }
        }


        //This is the function that tells what happens in room 5 (flower field / exit)
        void RoomFive()
        {
            Console.WriteLine("What would you like to do in room five (flower field): look, check door, check horse, or go back? You can also type open or drink in any room.");
            response = Console.ReadLine();
            if (response == "look")
            {
                Console.WriteLine("You are now in a large flower field. It seems mostly empty besides what looks to be a door in the distance and a grazing horse.");
            }
            if (response == "check horse")
            {
                Console.WriteLine("You slowly walk up to the horse, surprisingly it doesn't run away. You give it a little pat. Aweee that was cute.");
                RoomFive();
            }
            if (response == "go back")
            {
                room = 2;
            }
            if (response == "check door")
            {
                Console.WriteLine("You walk over to the door, it is much larger than is seemed from the otherside of the field. It is made out of a dark wood except for an out of place keypad.");
                Console.WriteLine("The code seems to be three digits. Enter a code.");
                response = Console.ReadLine();

                if (response == "687" && snakeBite == false)
                {
                    GameFinished();
                }
                else if (response == "687" && snakeBite == true)
                {
                    Console.WriteLine("You won't be able to get the necessary treatment for that snake bite if you leave now.");
                }
                else
                {
                    Console.WriteLine("Nothing happened.");
                    RoomFive();
                }
            }
            if (response == "open")
            {
                if (treasureChest == true && keyFound == true)
                {
                    Console.WriteLine("You put the key in the treasure chest and turn it until you here a click. The lid opens and you see a small vile of liquid.");
                    antiVenom = true;
                }
                else
                {
                    Console.WriteLine("You don't have all the necessary things to open this.");
                }
            }
            if (response == "drink")
            {
                if (snakeBite == true && antiVenom == true)
                {
                    Console.WriteLine("You drink the vile, hoping it is the solution to your problem. After a few minutes, you are feeling much better. It worked!");
                    snakeBite = false;
                }
                else
                {
                    Console.WriteLine("You can not drink it at this time.");
                }
            }
        }

        //this tells what happens when the game is done
        void GameFinished()
        {
            gameFinished = true;
            Console.WriteLine("Congrats! You escaped! Thank you for playing.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("YAY!");
            }
        }

        //This is the function that tells what happens in room 6 (woods)
        void RoomSix()
        {
            Console.WriteLine("What would you like to do in room 6 (woods)? look, check fox, or go back? You can also type open or drink in any room.");
            response = Console.ReadLine();
            if (response == "look")
            {
                Console.WriteLine("You are standing in a dark forest. It is heavily wooded, cold, and there is not another door. There is a fox running around.");
            }
            if (response == "check fox")
            {
                Console.WriteLine("The fox moves toward you. You notice an unusual marking on it's side. Once it get close enough, you see that it is numbers. 687");
                RoomSix();
            }
            if (response == "go back")
            {
                room = 3;
            }
            if (response == "open")
            {
                if (treasureChest == true && keyFound == true)
                {
                    Console.WriteLine("You put the key in the treasure chest and turn it until you here a click. The lid opens and you see a small vile of liquid.");
                    antiVenom = true;
                }
                else
                {
                    Console.WriteLine("You don't have all the necessary things to open this.");
                }
            }
            if (response == "drink")
            {
                if (snakeBite == true && antiVenom == true)
                {
                    Console.WriteLine("You drink the vile, hoping it is the solution to your problem. After a few minutes, you are feeling much better. It worked!");
                    snakeBite = false;
                }
                else
                {
                    Console.WriteLine("You can not drink it at this time.");
                }
            }
        }

    }

}
