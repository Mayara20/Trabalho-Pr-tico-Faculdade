using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
	class Program
	{
		static string jogador1, jogador2;
		static string a1 = "1", a2 = "2", a3 = "3", a4 = "4", a5 = "5", a6 = "6", a7 = "7", a8 = "8", a9 = "9";
		static string jogador = jogador1;
		static int partida = 1;

		static void Main(string[] args)
		{

			Console.WriteLine("Nome do Jogador 1: ");
			jogador1 = Console.ReadLine();
			Console.WriteLine("Nome do jogador 2: ");
			jogador2 = Console.ReadLine();
			Console.WriteLine();


			while (partida <= 9)
			{

				Console.WriteLine("       |       |       ");
				Console.WriteLine("    " + a1 + "  |   " + a2 + "   |   " + a3);
				Console.WriteLine("-------|-------|-------");
				Console.WriteLine("    " + a4 + "  |   " + a5 + "   |   " + a6);
				Console.WriteLine("-------|-------|-------");
				Console.WriteLine("    " + a7 + "  |   " + a8 + "   |   " + a9);
				Console.WriteLine("       |       |       ");

				Console.WriteLine();

				jogadorDaVez(jogador1, jogador2);
				Console.WriteLine();
				Console.WriteLine(jogador + " escolha uma posição: ");
				int pose = int.Parse(Console.ReadLine());
				posicoesValidas(pose);
				GanhadorDaRodada(jogador1, jogador2);

				partida++;
				Console.Clear();
			}
		}
		
		static void jogadorDaVez(string jogador1, string jogador2)
		{

			if (jogador == jogador1)
			{
				jogador = jogador2;
				Console.WriteLine("Sua vez Jogador " + jogador2);
			}
			else
			{
				jogador = jogador1;
				Console.WriteLine("Sua vez Jogador " + jogador1);

			}
		}

		static void posicoesValidas(int pose)
		{


			if (pose == 1)
			{
				if (!(a1 == "X" || a1 == "O"))
				{
					if (jogador == jogador1)
					{
						a1 = "X";
					}
					else
					{
						a1 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 2)
			{
				if (!(a2 == "X" || a2 == "O"))
				{
					if (jogador == jogador1)
					{
						a2 = "X";
					}
					else
					{
						a2 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 3)
			{
				if (!(a3 == "X" || a3 == "O"))
				{
					if (jogador == jogador1)
					{
						a3 = "X";
					}
					else
					{
						a3 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 4)
			{
				if (!(a4 == "X" || a4 == "O"))
				{
					if (jogador == jogador1)
					{
						a4 = "X";
					}
					else
					{
						a4 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 5)
			{
				if (!(a5 == "X" || a5 == "O"))
				{
					if (jogador == jogador1)
					{
						a5 = "X";
					}
					else
					{
						a5 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 6)
			{
				if (!(a6 == "X" || a6 == "O"))
				{
					if (jogador == jogador1)
					{
						a6 = "X";
					}
					else
					{
						a6 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 7)
			{
				if (!(a7 == "X" || a7 == "O"))
				{
					if (jogador == jogador1)
					{
						a7 = "X";
					}
					else
					{
						a7 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 8)
			{
				if (!(a8 == "X" || a8 == "O"))
				{
					if (jogador == jogador1)
					{
						a8 = "X";
					}
					else
					{
						a8 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else if (pose == 9)
			{
				if (!(a9 == "X" || a9 == "O"))
				{
					if (jogador == jogador1)
					{
						a9 = "X";
					}
					else
					{
						a9 = "O";
					}
				}
				else
				{
					invalidas(pose);
				}
			}
			else
			{
				invalidas(pose);
			}

		}
		static void invalidas(int pos)
		{
			string jogadorAnterior = jogador;

			if(pos != 1 || pos != 2 || pos != 3
		    || pos != 4 || pos != 5 || pos != 6
		    || pos != 7 || pos != 8 || pos != 9)
			{
				Console.WriteLine("POSIÇÃO INVÁLIDA. POR FAVOR VERIFIQUE AS ALTERNATIVAS.");
				partida = partida - 1;	
				if(jogadorAnterior == jogador1)
				{
					jogador = jogador1;
					Console.WriteLine(jogador + " escolha uma posição: ");
					int pose = int.Parse(Console.ReadLine());
					posicoesValidas(pose);
				}
				else
				{
					jogador = jogador2;
					Console.WriteLine(jogador + " escolha uma posição: ");
					int pose = int.Parse(Console.ReadLine());
					posicoesValidas(pose);
				}
			}
		}

		static void GanhadorDaRodada(string jogador1, string jogador2)
		{
			if (a1 == "X" && a2 == "X" && a3 == "X"
			|| a1 == "X" && a5 == "X" && a9 == "X"
			|| a1 == "X" && a4 == "X" && a7 == "X"
			|| a2 == "X" && a5 == "X" && a8 == "X"
			|| a3 == "X" && a6 == "X" && a9 == "X"
			|| a3 == "X" && a5 == "X" && a7 == "X"
			|| a4 == "X" && a5 == "X" && a6 == "X"
			|| a7 == "X" && a8 == "X" && a9 == "X")
			{
				partida = 9;
				Console.WriteLine("\n Parabéns Ganhador: " + jogador1 + "\n");
				partidaFinalizada();
			}
			else if (a1 == "O" && a2 == "O" && a3 == "O"
				  || a1 == "O" && a5 == "O" && a9 == "O"
				  || a1 == "O" && a4 == "O" && a7 == "O"
				  || a2 == "O" && a5 == "O" && a8 == "O"
				  || a3 == "O" && a6 == "O" && a9 == "O"
				  || a3 == "O" && a5 == "O" && a7 == "O"
				  || a4 == "O" && a5 == "O" && a6 == "O"
				  || a7 == "O" && a8 == "O" && a9 == "O")
			{
				partida = 9;
				Console.WriteLine("\n Parabéns Ganhador: " + jogador2 + "\n");
				Console.WriteLine();
				partidaFinalizada();
			}
			else if(a1 != "1" && a2 != "2" && a3 != "3" 
				 && a4 != "4" && a5 != "5" && a6 != "6" 
				 && a7 != "7" && a8 != "8" && a9 != "9")
			{
				Console.WriteLine("Empate! Parabéns a(o) jogador(a) " + jogador1 + " e a(o) jogador(a) " + jogador2 + "\n");
				partida = 9;
				partidaFinalizada();
			}
			else
			{
				partidaFinalizada();
			}
		}
		static void partidaFinalizada()
		{
			char resp;
			
			if (partida == 9 )
			{
				Console.WriteLine("Deseja iniciar outra partida? S/N");
				resp = char.Parse(Console.ReadLine());

				if (resp == 'S' || resp == 's')
				{
					a1 = "1";
					a2 = "2";
					a3 = "3";
					a4 = "4";
					a5 = "5";
					a6 = "6";
					a7 = "7";
					a8 = "8";
					a9 = "9";
					partida = 0;
					jogador = jogador2;
					
				}
				else if (resp == 'N' || resp == 'n')
				{
					partida = 9;
				}
				else
				{
					Console.WriteLine("RESPOSTA INVÁLIDA. JOGO FINALIZADO.");
					partida = 9;
					Console.Read();
				}
			}
		}
	}
}

