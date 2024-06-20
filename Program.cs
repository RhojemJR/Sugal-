// See https://aka.ms/new-console-template for more information
using System;

namespace Games
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			
			//user interface
		 Console.WriteLine("=====================================");
         Console.WriteLine(" WELCOME TO THE CONSOLE GAME SYSTEM"  );
         Console.WriteLine("=====================================");
		 Console.WriteLine(                                       );
		 Console.Write("Please enter your username:"              );
		 string user1 = Console.ReadLine(                         );
		 Console.WriteLine("Welcome Player1:"+ user1              );
		 Console.WriteLine(                                       );
		 Console.WriteLine("=====================================");
		 Console.WriteLine(                                       );
		
		 //singleplayer/multiplayer
		 Console.WriteLine("SINGLEPLAYER/MULTIPLAYER"                            );
	     Console.Write("Please enter 'singleplayer' or 'multiplayer' to proceed:");
		 string multiplayer = Console.ReadLine().ToLower();
		 string userchoice = "multiplayer";
		 //multiplayer interface
		if (multiplayer == userchoice)
		{
			Console.WriteLine(                                       );
			Console.WriteLine("=====================================");
			Console.WriteLine("             MULTIPLAYER"             );
			Console.WriteLine("=====================================");
			Console.WriteLine(                                       );
			
			Console.Write("Please enter your username:" );
			string user2 = Console.ReadLine(            );
			Console.WriteLine("Welcome Player2:" + user2);
			Console.ReadKey(                            );
			Console.WriteLine(                          );
			
         Console.WriteLine("=====================================");
         Console.WriteLine("              GAME MENU"              );
         Console.WriteLine("=====================================");
         Console.WriteLine("1 - ROCK, PAPER, or SCISSORS."        );
         Console.WriteLine("2 - COLOR GAME."                      );
         Console.WriteLine("3 - HIGHER or LOWER."                 );
         Console.WriteLine("4 - Game 4"                           );
         Console.WriteLine("5 - Game 5"                           );
         Console.Write("Enter a number:"                          );
		 int Multiplayer = Convert.ToByte(Console.ReadLine()      );
		
		 switch (Multiplayer)
		    {
				
		     case 1:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("      ROCK, PAPER, or SCISSORS"       );
		        Console.WriteLine("=====================================");
				game1player();
				break;
			 case 2:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              COLOR GAME"             );
		        Console.WriteLine("=====================================");
				break;
			 case 3:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              HIGHER or LOWER"        );
		        Console.WriteLine("=====================================");
				break;
			 case 4:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              CHESS"                  );
		        Console.WriteLine("=====================================");
				break;
			 case 5:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              GAME "                  );
		        Console.WriteLine("=====================================");
				break;
				
		    } 
		}
		// singleplayer interface
		else 
		{
			Console.WriteLine(                                       );
		    Console.WriteLine("=====================================");
			Console.WriteLine("            SINGLEPLAYER"             );
		    Console.WriteLine("=====================================");
			Console.WriteLine(                                       );
			
			Console.WriteLine(user1 + " VS COMPUTER");
			Console.ReadKey(                        );
			Console.WriteLine(                      );
			
         Console.WriteLine("=====================================");
         Console.WriteLine("              GAME MENU"              );
         Console.WriteLine("=====================================");
         Console.WriteLine("1 - ROCK, PAPER, or SCISSORS."        );
         Console.WriteLine("2 - COLOR GAME."                      );
         Console.WriteLine("3 - HIGHER or LOWER."                 );
         Console.WriteLine("4 - Game 4"                           );
         Console.WriteLine("5 - Game 5"                           );
         Console.Write("Enter a number:"                          );
		 int singleplayer = Convert.ToByte(Console.ReadLine());
		
	        switch (singleplayer)
		    {
		     case 1:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("      ROCK, PAPER, or SCISSORS"       );
		        Console.WriteLine("=====================================");
				game1(); 	
			    break;
			 case 2:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              COLOR GAME"             );
		        Console.WriteLine("=====================================");
				game2();
				break;
			 case 3:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              HIGHER or LOWER"        );
		        Console.WriteLine("=====================================");
				break;
			 case 4:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              CHESS"                  );
		        Console.WriteLine("=====================================");
				break;
			 case 5:
			    Console.WriteLine("=====================================");
	            Console.WriteLine("              GAME "                  );
		        Console.WriteLine("=====================================");
				break;
		    } 
		}
		static void game1()
		{
		 bool playagain = true; 
		 Random random = new Random();
		 string Computer; 
		 string player1;
		    while (playagain)
			{
				 player1 = " ";
				 Computer = " ";
				while (player1 != "ROCK"  && 
				       player1 != "PAPER" && 
					   player1 != "SCISSORS")
				{
					Console.WriteLine();
				    Console.WriteLine("ROCK, PAPER, or SCISSORS");
					Console.Write("Enter:");
				    player1 = Console.ReadLine().ToUpper();	
						
					int randomnum = random.Next(1, 4);
					switch (randomnum)
					{
						case 1:
						Computer = "ROCK";
						break;
						case 2:
						Computer = "PAPER";
						break;
						case 3:
						Computer = "SCISSORS";
						break;
					}
					
				 Console.WriteLine();
				 Console.WriteLine("---------------------------------------");
				 Console.WriteLine("Player   chose:" + player1);
				 Console.WriteLine("Computer chose:" + Computer);
				 string result = GetGame1Result(player1, Computer);
				 Console.WriteLine(result);
				 Console.WriteLine("---------------------------------------");
				 
				}
				
				 Console.WriteLine();
				 Console.Write("Do you want to play again? Y/N:");
				 string response = Console.ReadLine().ToLower();
				if (response == "y") 
				{
					
					playagain = true;
					
				}
				else if (response == "n")
				{
					
					string AI = "COMPUTER";
					Console.WriteLine();
					playagain = false; 
					Console.WriteLine("Thanks for playing!");
					Console.WriteLine();
					Console.WriteLine("Processing...");
					Console.ReadKey();
					Console.WriteLine("=====================================");
	                Console.WriteLine("           LEADERBOARDS"              );
		            Console.WriteLine("=====================================");
					Console.WriteLine("1.........................." + AI     );
					Console.WriteLine("=====================================");
					Console.WriteLine("2............................."       );
					Console.WriteLine("=====================================");
					Console.WriteLine("3............................."       );
				    Console.WriteLine("=====================================");
					
				}
				else
				{
					
					Console.WriteLine("      INVALID INPUT!");
				    Console.WriteLine("      ERROR CODE 404");
					playagain = false;
					
				}
			}
		}
		//return statements
		
		static string GetGame1Result(string player1, string Computer) //GetGame1Result
		{
			
			
			if (player1 == Computer)
			{
				
				return "IT'S A TIE.";
				
			}
			else if (player1 == "ROCK"     && Computer == "SCISSORS" ||
			         player1 == "PAPER"    && Computer == "ROCK"     ||
			         player1 == "SCISSORS" && Computer == "PAPER")
			{
				
				return "YOU WON!";
				
			}
			else if (player1 != "ROCK"  &&
			         player1 != "PAPER" &&
			         player1 != "SCISSORS")
			{
				
				return "INVALID! Choose ROCK PAPER or SCISSORS";
				
			}
			else
			{
				
				return "YOU LOST!";
				
			}
		}
		 //game1 vs PLAYER
		static void game1player()
		{
	     bool playagain = true; 
	     string player2; 
		 string player1;
		    while (playagain)
			{
				 player1 = " ";
				 player2 = " ";
				while (player1 != "ROCK" && 
				       player1 != "PAPER" && 
					   player1 != "SCISSORS")
				{
				
				 Console.WriteLine();
				 Console.WriteLine("ROCK, PAPER, or SCISSORS");
		         Console.Write("Enter Player1:");
			     Console.ForegroundColor = ConsoleColor.Black;
                 player1 = Console.ReadLine().ToUpper();
				 Console.ResetColor();
						
				
				
					   while (player2 != "ROCK" && 
				              player2  != "PAPER" && 
					          player2  != "SCISSORS")
					    {
						   
						   Console.WriteLine();
				           Console.WriteLine("ROCK, PAPER, or SCISSORS");
					       Console.Write("Enter Player2:");
				           player2 = Console.ReadLine().ToUpper();
						   
					    }
					 Console.WriteLine();
				     Console.WriteLine("---------------------------------------");
				     Console.WriteLine("Player1 chose:" + player1);
			         Console.WriteLine("Player2 chose:" + player2);
				     string result2 = GetGame2Result(player1, player2);
				     Console.WriteLine(result2);
				     Console.WriteLine("---------------------------------------");
					 
				}
				
				 Console.WriteLine();
				 Console.Write("Do you want to play again? Y/N:");
				 string response = Console.ReadLine().ToLower();
	
				if (response == "y") 
				{
					
					playagain = true;
					
				}
				else if (response == "n")
				{
					
					Console.WriteLine();
					playagain = false; 
					Console.WriteLine("Thanks for playing!");
					Console.WriteLine();
					Console.WriteLine("Processing...");
					Console.ReadKey();
					Console.WriteLine("=====================================");
	                Console.WriteLine("           LEADERBOARDS"              );
		            Console.WriteLine("=====================================");
					Console.WriteLine("1.........................." + player1);
					Console.WriteLine("=====================================");
					Console.WriteLine("2............................."       );
					Console.WriteLine("=====================================");
					Console.WriteLine("3............................."       );
				    Console.WriteLine("=====================================");
				}
				else
				{
					
					Console.WriteLine("      INVALID INPUT!");
				    Console.WriteLine("      ERROR CODE 404");
					playagain = false;
					
				}
			}
		}
		//return statements
	    static string GetGame2Result(string player1, string player2) //GetGame2Result
		{
			 if (player1 == player2)
			{
				
				return "IT'S A TIE.";
				
			}
			else if (player1 == "ROCK"     && player2 == "SCISSORS" ||
			        player1  == "PAPER"    && player2 == "ROCK"     ||
			        player1  == "SCISSORS" && player2 == "PAPER")
			{
				
				return "YOU WON!";
				
			}
			else if (player1  != "ROCK" &&
			         player1  != "PAPER" &&
			         player1  != "SCISSORS")
			{
				
				return "INVALID! Choose ROCK PAPER or SCISSORS";
				
			}
			else
			{
				
				return "YOU LOST!";
				
			}
		}
		
		static void game2()
		{
			bool playagain1 = true;
			while(playagain1)
			{
			     bool playagain = true; 
			     Console.WriteLine(); 
			     string[] Colors = {"RED", "YELLOW", "GREEN", "WHITE", "BLUE", "PINK"};
			     Console.Write("Enter number of bets:"                               );
			     List<int> allbets = new List<int>(                                  );
			     List<string> allchosenColors = new List<string>(                    );
				 
			     int NumofBets  = Convert.ToInt16(Console.ReadLine()                 );
			     int[] bets = new int              [NumofBets];
			     string[] chosenColors = new string[NumofBets];
			     int maxCounter = 6;
			     int i;
			     while(playagain)
			    {
					allbets.Clear();
					allchosenColors.Clear();
			 
			        if(NumofBets < 0) 
			        {
					
			  	     Console.WriteLine();
					 Console.WriteLine("Try again.");
					 break;
	                   
			        }
				    else if (NumofBets > maxCounter)
				    {
					
				     Console.WriteLine("Maximum limit exceeded!");
					 Console.WriteLine("Try again.");
				     break;
				 
				    }
				
		             for(i = 0; i < NumofBets; i++)
				    {
			            while(true)
			            {
				
				         Console.WriteLine();
				         Console.Write($"Enter bet {i + 1} ($0 - $250):$");
				         int bet = Convert.ToInt16(Console.ReadLine());
					        if (bet >= 0 && bet <= 250)
					        {
					         bets[i] = bet;
						     allbets.Add(bet);
					         break;
					        }
					        else
					        {
					         Console.WriteLine("Invalid input! $0 - $250.");
					        }
					    }
					
				         bool Valid = false;
			             while (!Valid)
			     	    {
					     Console.WriteLine("------------------------------------");
					     Console.WriteLine("|      RED       |      PINK       |");
					     Console.WriteLine("------------------------------------");
					     Console.WriteLine("|      BLUE      |      GREEN      |");
					     Console.WriteLine("------------------------------------");
					     Console.WriteLine("|      WHITE     |      YELLOW     |");
					     Console.WriteLine("------------------------------------");
					
				      	 Console.Write($"Choose a color {i + 1}:");
				    	 string Colorchoice = Console.ReadLine().ToUpper();
					
					         foreach (string ValidColors in Colors)
					        {
						        if (Colorchoice == ValidColors)
						        {
									
							     chosenColors[i] = Colorchoice;
							     allchosenColors.Add(Colorchoice);
							     Valid = true;
						         break;
						        }
					        }
					        if (!Valid)
					        {
					         Console.WriteLine("Invalid input!");			  
					        }
				        }   
				
				     Console.WriteLine("------------------------------------");
				     Console.WriteLine("       Bets:       |      Colors:   ");
				     Console.WriteLine("------------------------------------");
			         Console.WriteLine($"Sugalero bets{i + 1}:${bets[i]}  : Color:{chosenColors[i]}");
				     Console.WriteLine("------------------------------------");
				     Console.ReadKey(                                        );
			 
				    }
				 Console.WriteLine();
			     Console.WriteLine("=====================================");
		         Console.WriteLine("================BETS=================");
			     Console.WriteLine("=====================================");
		        for (i = 0; i < allbets.Count; i++)
			    {
				
			     Console.WriteLine($"Bet {i + 1}:${allbets[i]}"           );
                 
		        }
			     Console.WriteLine("=====================================");
		         Console.WriteLine("===============COLORS================");
		         Console.WriteLine("=====================================");
		        for (i = 0; i < allchosenColors.Count; i++)
	     		{		
		
		    	 Console.WriteLine($"Color {i + 1}:{allchosenColors[i]}"  );
				 Console.WriteLine();

		    	}
			
		         Console.WriteLine("------------------------------------");
	             Console.Write("1 - Continue / 2 - Restart bets?:"       );
		         string response = Console.ReadLine(                     );
			     Console.WriteLine("------------------------------------");	
			    if (response != "1")
			    { 
			     
			     Console.WriteLine("resetting game..."               );
				 Console.ReadKey(                                    );
			     playagain1 = true;
				 
				}
				    else if(response == "1")
			     	{
					 
				     Console.WriteLine();
				     Console.WriteLine("ROLLING...");
				     Console.ReadKey(              );
				     Console.WriteLine(            );
				     playagain = false;
				     Random random = new Random();
			         int randomnum = random.Next(1, 5);
				     int randomindex1, randomindex2, randomindex3;
				     int randombets1, randombets2, randombets3;
				     randomindex1 = random.Next(0, Colors.Length);
                     randomindex2 = random.Next(0, Colors.Length);
				     randomindex3 = random.Next(0, Colors.Length);
				     randombets1 = random.Next(Byte.MaxValue);
				     randombets2 = random.Next(Byte.MaxValue);
				     randombets3 = random.Next(randombets2 % randombets1);
					 string Computer = " ";
				        switch (randomnum)
				        {
					     case 1:
				         Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex3]}");
						 Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex2]}");
					     Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex1]}");
					     Console.WriteLine("------------------------------------"     );
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets1}");
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets2}");
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets3}");
					     Console.WriteLine(                                           );
					     break;
					   
					     case 2:
				         Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex1]}");
						 Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex2]}");
					     Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex3]}");
					     Console.WriteLine("------------------------------------"     );
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets1}");
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets2}");
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets3}");
					     Console.WriteLine(                                           );
					     break;
					   
					     case 3:
				         Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex3]}");
						 Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex2]}");
					     Console.WriteLine("------------------------------------"     );
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets2}");
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets3}");
					     Console.WriteLine(                                           );
					     break;
					   
					     case 4:
					     Console.WriteLine(Computer = $"COMPUTER picked: {Colors[randomindex3]}");
					     Console.WriteLine("------------------------------------"     );
					     Console.WriteLine(Computer = $"COMPUTER bets:$ {randombets1}");
						 break;

				        }
				        switch (randomnum) //randomize
				        {   
					     case 1:
						 Console.WriteLine("=====================================");
						 Console.WriteLine("            WINNING COLOR            ");
					     Console.WriteLine("=====================================");			   
					     Console.WriteLine(":" + Colors[randomindex1]             );
					     Console.WriteLine(":" + Colors[randomindex2]             );
					     Console.WriteLine(":" + Colors[randomindex3]             );
					     Console.WriteLine("=====================================");
						 break;
						 
					     case 2:
						 Console.WriteLine("=====================================");
						 Console.WriteLine("            WINNING COLOR            ");
					     Console.WriteLine("=====================================");			   
					     Console.WriteLine(":" + Colors[randomindex3]             );
					     Console.WriteLine(":" + Colors[randomindex2]             );
					     Console.WriteLine(":" + Colors[randomindex1]             );
					     Console.WriteLine("=====================================");
					     break;
					   
					     case 3:
						 Console.WriteLine("=====================================");
						 Console.WriteLine("            WINNING COLOR            ");
					     Console.WriteLine("=====================================");			   
				         Console.WriteLine(":" + Colors[randomindex1]             );
					     Console.WriteLine(":" + Colors[randomindex1]             );
					     Console.WriteLine(":" + Colors[randomindex3]             );
					     Console.WriteLine("=====================================");
					     break;
					   
					     case 4:
						 Console.WriteLine("=====================================");
						 Console.WriteLine("            WINNING COLOR            ");
					     Console.WriteLine("=====================================");			   
				         Console.WriteLine(":" + Colors[randomindex3]             );
					     Console.WriteLine(":" + Colors[randomindex3]             );
					     Console.WriteLine(":" + Colors[randomindex3]             );
					     Console.WriteLine("=====================================");
					     break;   
						}
						
						 //getgame1result
				         Console.WriteLine("---------------------------------------");
						 Console.WriteLine("              GAME RESULT              ");
				         Console.WriteLine("---------------------------------------");
						 int result = Getgame1Result(randomindex1, randomindex2, randomindex3, randombets1, randombets2, randombets3); //return method
				         Console.WriteLine($"COMPUTER bets:{result}");
						 Console.WriteLine($"COMPUTER total winnings:");
						 Console.WriteLine($"Player1 Bets:");
						 Console.WriteLine($"Player1 total winningss:");
				         Console.WriteLine("---------------------------------------");
						 
				 
				     Console.WriteLine();
				     Console.Write("Do you want to play again? Y/N:");
				     string answer = Console.ReadLine().ToUpper(); 
				        if (answer == "Y")
				        {

					     playagain1 = true;
					      
				        }
				     
				        else if (answer == "N")
				        {
					
			     		 Console.WriteLine();
			    		 playagain1 = false; 
				    	 Console.WriteLine("Thanks for playing!");
					     Console.WriteLine();
					     Console.WriteLine("Processing...");
					     Console.ReadKey();
					     Console.WriteLine("=====================================");
	                     Console.WriteLine("           LEADERBOARDS"              );
		                 Console.WriteLine("=====================================");
					     Console.WriteLine("1.........................."          );
					     Console.WriteLine("=====================================");
					     Console.WriteLine("2............................."       );
					     Console.WriteLine("=====================================");
					     Console.WriteLine("3............................."       );
				         Console.WriteLine("=====================================");
						}
				    
				         else
				        {
					
			     		 Console.WriteLine("      INVALID INPUT!");
				         Console.WriteLine("      ERROR CODE 404");
					     playagain1 = false;
						 break;
						 
						}
					}					
				}
			}
		}
		
		static int Getgame1Result(int randomindex1, int randomindex2, int randomindex3, int randombets1, int randombets2, int randombets3)
		{
		   int totalBets = 0;
		   int aiMatches = 0;
		    if (randomindex1 == randomindex1 && 
			    randomindex2 == randomindex2 &&
				randomindex3 == randomindex3)
		    {
				
			   aiMatches = 3;
			   
		    }
		    else if (randomindex1 == randomindex2 || randomindex1 == randomindex3 || randomindex2 == randomindex3)
		    {
				
			   aiMatches = 2; 
			   
		    }
		    else if (randomindex1 == randomindex2 || randomindex1 == randomindex3 || randomindex2 == randomindex3)
		    {
				
			   aiMatches = 1;
			   
		    }
		    if (aiMatches == 3)
		    {
				
			   totalBets = randombets1 + randombets2 + randombets3 * 3;
			   
		    }
		    else if (aiMatches == 2)
		    {
				
			    totalBets = randombets1 + randombets2 * 2;
				
		    }
		    else if (aiMatches == 1)
		    {
			    if (randomindex1 == randomindex2)
			    {
				
				   totalBets = randombets1 + randombets2;
				   
			    }
			    else if (randomindex1 == randomindex3) 
			    {
					
				   totalBets = randombets1 + randombets3;
				   
			    }
			    else if (randomindex2 == randomindex3) 
			    {
					
				    totalBets = randombets2 + randombets3;
					
			    }
		    }
			else 
			{
				
				totalBets = 0;
				
			}
			
			return totalBets;
		}
	} 
}}
