using System;

namespace IntenseWizardy
{
	class MainClass
	{
		static int hasClub = 0;
		static int hasCoinPurse = 0;
		static string age;

		public static void Main (string[] args)
		{
			Console.Title = "Intense Wizardy";
			Console.WriteLine("\n \n \n \n \n \n \n \n                     Intense Wizardy! - A Text Adventure Game! \n\n                   : Created by Sips and written by Puddleduck :         \n\n                             Press enter to begin!\n\n\n\n\n\n\n\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			showNotes();
		}

		public static void showNotes()
		{
			Console.WriteLine ("\nWelcome to Intense Wizardy! \n\nNotes:\nThis is my first complete game, so forgive any bugs and hopefully they aren't\ntoo game breaking. This game will parse your text to the best of my ability,\nbut it may not understand what you mean.\nTry and keep any imput short and sweet, and please listen to what it tells you\nto do!\n\n                             Press enter to continue!\n\n\n\n\n\n\n\n\n\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			showIntro ();
		}

		public static void showIntro()
		{
			Console.WriteLine ("\nYou wake in a cabin, you notice you are wearing blue robes.\nThis is unusual.\nYou do not usually wear blue robes.\nYou rub your eyes to try and see more in the dark cabin.\nYour hands feel dry yet soft against your face.\nYou clamber to your feet and search the walls of the cabin for an opening.\nThe walls of the cabin are cold, they feel like stone.\nI lied, you are not in a cabin. You are in a cave.\nA mystical cave.\nIn the darkness, you find what you think is an opening.\n\n                             Press enter to continue!\n\n\n\n\n\n\n\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			exitCave ();
		}

		public static void exitCave()
		{
			string checkOpen;

			Console.WriteLine ("\nDo you go through the opening?\n(Type your answer and then press enter!)\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

			do {
				Console.Write("Answer: ");

				checkOpen = Console.ReadLine ();

				if (checkOpen != null) {
					Console.Write ("Answer: " + checkOpen);

					if (checkOpen == "yes" || checkOpen == "Yes" || checkOpen == "y" || checkOpen == "Y" || checkOpen == "YES") {
						Console.Clear ();
						System.Threading.Thread.Sleep(500);
						openOut ();
					}
					else if (checkOpen == "no" || checkOpen == "No" || checkOpen == "n" || checkOpen == "N" || checkOpen == "NO")
					{
						Console.Clear ();
						System.Threading.Thread.Sleep(500);
						openIn ();
					}
					else {
						Console.WriteLine (" is an invalid input, try again!\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
						System.Threading.Thread.Sleep(2500);
						exitCave ();
					}
				}

			} while(checkOpen != null);
		}

		public static void openOut()
		{
			Console.WriteLine ("\nYou scramble through the opening into another dark chamber.\nThis room is slightly warmer than the previous one.\nYou see a tiny strip of light coming from one of the walls.\nYou walk over and investigate.\nStaring at the strip of light, you can see that it is a crack in the wall.\nThrough the crack you can see a room, with a fireplace.\nYou search the chamber for a way through to the room.\n\n                             Press enter to continue!\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			searchChamber ();
		}

		public static void openIn()
		{
			Console.WriteLine ("\nYou continue to explore the dark room.\nYou walk to the other side of the cave and discover a pot on the ground.\nYou reach into the pot.\nYou cry out in pain as you feel the fangs of a snake clamp down on your hand.\nYou fall back, the snake still attatched to your hand, hissing loudly.\nYou feel your life draining from you.\nYou die.\n\nDue to the fact that this is a game, you are allowed to return to your previous decision. Try and pick an option that doesn't get you killed this time.\n\n                             Press enter to continue!\n\n\n\n\n\n\n\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			exitCave ();
		}

		public static void searchChamber()
		{

			string puddleOrRock;

			Console.WriteLine ("\nYou see a rock and a puddle, which do you investigate first?\n\n(Type your answer and then press enter!)\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

			do {
				Console.Write("Answer: ");

				puddleOrRock = Console.ReadLine ();

				if (puddleOrRock != null) {

					Console.Write ("Answer: " + puddleOrRock);

					if (puddleOrRock == "rock" || puddleOrRock == "Rock" || puddleOrRock == "ROCK" || puddleOrRock == "the rock") {
						Console.Clear ();
						System.Threading.Thread.Sleep(500);
						examineRock ();
					}else if(puddleOrRock == "puddle" || puddleOrRock == "Puddle" || puddleOrRock == "PUDDLE" || puddleOrRock == "the puddle")
					{
						Console.Clear ();
						System.Threading.Thread.Sleep(500);
						examinePuddle ();
					}else{
						Console.WriteLine (" is an invalid input, try again!\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
						System.Threading.Thread.Sleep(2500);
						searchChamber ();
					}
				}

			} while(puddleOrRock != null);
		}

		public static void examineRock()
		{
			Console.WriteLine ("\nYou place your hands on the rock and instantly feel it give way.\nThe wall crumbles away revealing a passage behind.\nYou make your way into the passage, the light getting a little brighter.\nYou emerge from the passage into a hallway, and you see a wooden club.\nYou also see an open door, with from which you can hear a crackling fire.\n\n                             Press enter to continue!\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			hallwayChoice ();
		}

		public static void examinePuddle()
		{
			Console.WriteLine ("\nYou kneel down and look into the puddle.\nBy the dim light you are able to make out a figure in the reflection.\nYou look at the puddle in horror, you are an old man, with a beard!\nYou recoil in horror, this isn't how you are supposed to look!\nYou scramble back towards rock to sit and rest.\nAfter all, you are now an old man. You need your rest.\nYou lean back against the rock and instantly feel it give way.\nThe wall crumbles away revealing a passage behind.\nYou make your way into the passage, the light getting a little brighter.\nYou emerge from the passage into a hallway, and you see a wooden club.\nYou also see an open door, with from which you can hear a crackling fire.\n\n                             Press enter to continue!\n\n\n\n\n\n\n\n\n");
			Console.ReadLine();
			Console.Clear();
			hallwayChoice ();

			string age = "old";
		}

		public static void hallwayChoice()
		{
			Console.WriteLine ("\nWhat do you do? Do you pick up the club or go for the door?\n\n(Type your answer and then press enter, try and keep it pretty simple!)\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

			string hallway;

			do {
				Console.Write("Answer: ");

				hallway = Console.ReadLine ();

				if (hallway != null) {

					Console.Write ("Answer: " + hallway);

					if (hallway.Contains ("pick up") || hallway.Contains ("club")) {
						Console.Clear ();
						hasClub = 1;
						System.Threading.Thread.Sleep(500);
						hallWithClub ();
					} else if (hallway.Contains ("door") || hallway.Contains ("go to")) {
						Console.Clear ();
						hasClub = 0;
						System.Threading.Thread.Sleep(500);
						hallNoClub ();
					}else{
						Console.WriteLine (" is an invalid input, try again!\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
						System.Threading.Thread.Sleep(2500);
						searchChamber ();
					}
				}

			} while(hallway != null);
		}

		public static void hallWithClub()
		{
			Console.WriteLine ();
			Console.WriteLine ("You picked up the club, that could prove useful soon!");
			Console.WriteLine ("Armed with your newly obtained club, you advance towards the door.");
			Console.WriteLine ();
			Console.WriteLine ("                             Press enter to continue!");
			Console.ReadLine();
			Console.Clear();
			enterRoom ();
		}

		public static void hallNoClub()
		{
			Console.WriteLine ();
			Console.WriteLine ("You choose to ignore the club, and go straight towards the door.");
			Console.WriteLine ();
			Console.WriteLine ("                             Press enter to continue!");
			Console.ReadLine();
			Console.Clear();
			enterRoom ();

		}

		public static void enterRoom()
		{
			Console.WriteLine ();
			Console.WriteLine ("You enter the room and take in your surroundings.");
			Console.WriteLine ("There is a troll standing in one corner, you spot each other.");
			Console.WriteLine ("The troll pounces on you.");
			if (hasClub == 0) {
				Console.WriteLine ();
				Console.WriteLine ("You are defenceless, the troll grabs your butt hard and throws you back out the room.");
				Console.WriteLine ();
				Console.WriteLine ("                             Press enter to continue!");
				Console.ReadLine();
				Console.Clear();
				outRoomHallway ();
			} else if (hasClub == 1) {
				Console.WriteLine ();
				Console.WriteLine ("You swing your club and hit the troll on the back of the head.");
				Console.WriteLine ("The troll dies.");
				Console.WriteLine ("The troll drops a bag of gold coins.");
				Console.WriteLine ();
				Console.WriteLine ("                             Press enter to continue!");
				Console.ReadLine();
				Console.Clear();
				coinChoice ();
			} else {
				Console.WriteLine ("Something has gone terribly wrong, please contact the developer!");
			}
		}

		public static void outRoomHallway()
		{
			Console.WriteLine ();
			Console.WriteLine ("You fly out the room into the hallway, and you see the wooden club.");
			Console.WriteLine ("The door is still open, and the troll is still inside.");
			Console.WriteLine ();
			Console.WriteLine ("                             Press enter to continue!");
			Console.ReadLine();
			Console.Clear();
			hallwayChoice ();
		}

		public static void coinChoice()
		{
			Console.WriteLine ();
			Console.WriteLine ("Do you pick up the coin purse?");
			Console.WriteLine ("(Type your answer and then press enter)");
			Console.WriteLine ();

			string coinPurse = Console.ReadLine ();

			if (coinPurse == "yes" || coinPurse == "Yes" || coinPurse == "y" || coinPurse == "Y" || coinPurse == "YES") {
				Console.Clear ();
				hasCoinPurse = 1;
				System.Threading.Thread.Sleep(500);
				afterTroll ();
			}
			else if (coinPurse == "no" || coinPurse == "No" || coinPurse == "n" || coinPurse == "N" || coinPurse == "NO")
			{
				Console.Clear ();
				hasCoinPurse = 0;
				System.Threading.Thread.Sleep(500);
				afterTroll ();
			}
			else {
				Console.WriteLine ("Invalid input, try again!");
				coinChoice ();
			}
		}

		public static void afterTroll()
		{
			Console.WriteLine ();
            Console.WriteLine ("You climb over the dead troll's body and move to the other side of the room.");
            Console.WriteLine ("You glace to your left and catch a full view of yourself in a mirror.");
            Console.WriteLine ("You take a moment to take in what you see.");
            Console.WriteLine ("Standing on the mirror is a hunch-backed old man wearing blue velvet robes.");
            Console.WriteLine ("The robes have silver moons & stars on them, stereotypical wizard shit really...");
            Console.WriteLine ("You notice that you have a long grey beard.");
            Console.WriteLine ("This information is useless really, but it is handy to know!");
            Console.WriteLine();
            Console.WriteLine("                             Press enter to continue!");
            Console.ReadLine();
            Console.Clear();
            exploreRoom();
		}

        public static void exploreRoom()
        {
            Console.WriteLine ();
            Console.WriteLine ("You look carefully at the fireplace.");
            Console.WriteLine("You notice the remains of some papers in the embers.");
            Console.WriteLine("You wonder what they could be.");
            Console.WriteLine();
            Console.WriteLine("                             Press enter to continue!");
            Console.ReadLine();
            Console.Clear();
            examineFire();
        }

        public static void examineFire()
        {
            Console.WriteLine ();
            Console.WriteLine ("Do you examine the fire?");
            Console.WriteLine ("Perhaps you could get a better look at the scraps of paper.");
            Console.WriteLine ();

            string hot = Console.ReadLine();

            if (hot == "yes" || hot == "Yes" || hot == "y" || hot == "Y" || hot == "YES")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Why did you think that would be a good idea?");
                Console.WriteLine("Now you are dead.");
                Console.WriteLine("Good job."); 
                Console.WriteLine();
                Console.WriteLine("                             Press enter to continue!");
                Console.ReadLine();
                Console.Clear();
                exploreRoom();
                
            }
            else if (hot == "no" || hot == "No" || hot == "n" || hot == "N" || hot == "NO")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Good choice, the other option was certain death.");
                Console.WriteLine("You continue to explore the room.");
                Console.WriteLine("You find a note on a table in one corner of the room.");
                Console.WriteLine("You read the note.");
                Console.WriteLine("The note reads: \n Milk \n Eggs \n Teabags \n Bread \n Newspaper.");
                Console.WriteLine();
                Console.WriteLine("                             Press enter to continue!");
                Console.ReadLine();
                Console.Clear();
                exploreRoom();
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
                examineFire();
            }
        }


	}
}
