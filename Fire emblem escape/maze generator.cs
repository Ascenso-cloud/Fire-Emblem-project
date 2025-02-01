using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using Microsoft.VisualBasic;

namespace project
{
  public class Maze
  {
    public int row;

    public int col;

    Lord Player1;

    Lord Player2;

    Cell[,] board;
    public Maze(int a, int b)
    {
      board = new Cell[a, b];
      row = a;
      col = b;
      generator(0, 0);
    }
    public void renderer()
    {
      int turnos = 0;
      while (true)
      {
        Console.WriteLine("Escoja a su personaje primer jugador");
        Console.WriteLine("1-👑​Marth");
        Console.WriteLine("ataque vida defensa");
        Console.WriteLine(" 15     70    10");
        Console.WriteLine("Habilidad : Presencia del Rey Heroico");
        Console.WriteLine("Los enemigos no opondran resistencia a su ataque");
        Console.WriteLine();
        Console.WriteLine("2-🤺​Roy");
        Console.WriteLine("ataque vida defensa");
        Console.WriteLine(" 20     100    5");
        Console.WriteLine("Habilidad : Maestro del estoque");
        Console.WriteLine("Su ataque se duplica e ignora las defensas");
        Console.WriteLine();
        Console.WriteLine("3-🪓​Hector");
        Console.WriteLine("ataque vida defensa");
        Console.WriteLine(" 35     80    10");
        Console.WriteLine("Habilidad : Robustez de guerrero");
        Console.WriteLine("Es capaz de desafiar la muerte en una oportunidad");
        Console.WriteLine();
        Console.WriteLine("4-🏇​Sigurd");
        Console.WriteLine("ataque vida defensa");
        Console.WriteLine(" 30     90    10");
        Console.WriteLine("Habilidad : Jinete supremo");
        Console.WriteLine("Puede desplazarse una casilla mas");
        Console.WriteLine();
        Console.WriteLine("5-🤴​​Chrom");
        Console.WriteLine("ataque vida defensa");
        Console.WriteLine(" 25     110    5 ");
        Console.WriteLine("Habilidad : Bendicion del destino");
        Console.WriteLine("Recupera 10 de vida en cada turno");
        Console.WriteLine();
        Player1.row = 1;
        Player1.col = 1;


        string choice = Console.ReadLine();
        if (choice == "1")
        {
          Player1.sprite​ = "👑​";
          Player1.attack = 15;
          Player1.HP = 70;
          Player1.life = 70;
          Player1.defense = 10;
          Player1.name = "Marth";
          Player1.Marth = true;
          break;
        }
        if (choice == "2")
        {
          Player1.sprite = "🤺";
          Player1.attack = 20;
          Player1.HP = 100;
          Player1.life = 100;
          Player1.defense = 5;
          Player1.Roy = true;
          Player1.name = "Roy";
          break;
        }
        if (choice == "3")
        {
          Player1.sprite = "🪓";
          Player1.attack = 35;
          Player1.HP = 80;
          Player1.life = 80;
          Player1.defense = 10;
          Player1.Hector = true;
          Player1.name = "Hector";
          break;
        }
        if (choice == "4")
        {
          Player1.sprite = "🏇";
          Player1.Sigurd = true;
          Player1.attack = 30;
          Player1.HP = 90;
          Player1.life = 90;
          Player1.defense = 10;
          Player1.name = "Sigurd";
          break;
        }
        if (choice == "5")
        {
          Player1.sprite = "🤴​";
          Player1.attack = 25;
          Player1.HP = 110;
          Player1.life = 110;
          Player1.defense = 5;
          Player1.Chrom = true;
          Player1.name = "Chrom";
          break;
        }
        Console.Clear();
      }
      Console.Clear();
      Console.WriteLine("Escoja a su personaje segundo jugador");
      Console.WriteLine("1-👑​Marth");
      Console.WriteLine("ataque vida defensa");
      Console.WriteLine(" 15     70    10");
      Console.WriteLine("Habilidad : Presencia del Rey Heroico");
      Console.WriteLine("Los enemigos no opondran resistencia a su ataque");
      Console.WriteLine();
      Console.WriteLine("2-🤺​Roy");
      Console.WriteLine("ataque vida defensa");
      Console.WriteLine(" 20     100    5");
      Console.WriteLine("Habilidad : Maestro del estoque");
      Console.WriteLine("Su ataque se duplica e ignora las defensas");
      Console.WriteLine();
      Console.WriteLine("3-🪓​Hector");
      Console.WriteLine("ataque vida defensa");
      Console.WriteLine(" 35     80    10");
      Console.WriteLine("Habilidad : Robustez de guerrero");
      Console.WriteLine("Es capaz de desafiar la muerte en una oportunidad");
      Console.WriteLine();
      Console.WriteLine("4-🏇​Sigurd");
      Console.WriteLine("ataque vida defensa");
      Console.WriteLine(" 30     90    10");
      Console.WriteLine("Habilidad : Jinete supremo");
      Console.WriteLine("Puede desplazarse una casilla mas");
      Console.WriteLine();
      Console.WriteLine("5-🤴​​Chrom");
      Console.WriteLine("ataque vida defensa");
      Console.WriteLine(" 25     110    5 ");
      Console.WriteLine("Habilidad : Bendicion del destino");
      Console.WriteLine("Recupera 10 de vida en cada turno");
      Console.WriteLine();
      Player1.row = 1;
      Player1.col = 1;
      Player2.row = 1;
      Player2.col = 2 * col - 1;

      while (true)
      {
        string choice = Console.ReadLine();
        if (choice == "1")
        {
          Player2.sprite​ = "👑​";
          Player2.attack = 15;
          Player2.HP = 70;
          Player2.life = 70;
          Player2.defense = 10;
          Player2.Marth = true;
          Player2.name = "Marth";
          break;
        }
        if (choice == "2")
        {
          Player2.sprite = "🤺";
          Player2.attack = 20;
          Player2.HP = 100;
          Player2.life = 100;
          Player2.Roy = true;
          Player2.defense = 5;
          Player2.name = "Roy";
          break;
        }
        if (choice == "3")
        {
          Player2.sprite = "🪓";
          Player2.attack = 35;
          Player2.HP = 80;
          Player2.life = 80;
          Player2.defense = 10;
          Player2.Hector = true;
          Player2.name = "Hector";
          break;
        }
        if (choice == "4")
        {
          Player2.sprite = "🏇";
          Player2.Sigurd = true;
          Player2.attack = 30;
          Player2.HP = 90;
          Player2.life = 90;
          Player2.defense = 10;
          Player2.name = "Sigurd";
          break;
        }
        if (choice == "5")
        {
          Player2.sprite = "🤴​";
          Player2.attack = 25;
          Player2.HP = 110;
          Player2.life = 110;
          Player2.defense = 5;
          Player2.name = "Chrom";
          Player2.Chrom = true;
          break;
        }
        Console.Clear();
      }
      Console.Clear();
      for (int i = 0; i < board.GetLength(0); i++)
      {
        for (int j = 0; j < board.GetLength(1); j++)
        {
          Random rand = new Random();
          int obsgenerator = rand.Next() % 100;
          if (obsgenerator < 5)
          {
            board[i, j].guard = true;
          }
          else if (obsgenerator < 10 && obsgenerator >= 5)
          {
            board[i, j].dragon = true;
          }
          else if (obsgenerator < 15 && obsgenerator >= 10)
          {
            board[i, j].fire = true;
          }
          else if (obsgenerator < 20 && obsgenerator >= 15)
          {
            board[i, j].tree = true;
          }
        }
      }
      board[row / 2, col / 2].Finish = true;
      Cell[,] visual = new Cell[(2 * row + 1), (2 * col + 1)];
      if (Player1.Roy)
      {
        Player1.attack = 2 * Player1.attack + Player2.defense;
      }
      if (Player2.Roy)
      {
        Player2.attack = 2 * Player2.attack + Player1.defense;
      }
      while (true)
      {
        for (int i = 0; i < (2 * row + 1); i++)
        {
          for (int j = 0; j < (2 * col + 1); j++)
          {
            visual[i, j].sprite = "🧱​";
          }
        }
        for (int i = 0; i < row; i++)
        {
          for (int j = 0; j < col; j++)
          {
            visual[2 * i + 1, 2 * j + 1].sprite = "⬛​";
            if (board[i, j].david4)
            {
              visual[2 * i + 1, 2 * j + 2].sprite = "⬛​";
              if (board[i, j].guard == true)
              {
                if (!visual[2 * i + 1, 2 * j + 2].death)
                {
                  visual[2 * i + 1, 2 * j + 2].sprite = "💂​";
                }
                if (turnos == 0)
                {
                  visual[2 * i + 1, 2 * j + 2].solid = true;
                  visual[2 * i + 1, 2 * j + 2].life = 30;
                  visual[2 * i + 1, 2 * j + 2].damage = 30;
                }
              }
              if (board[i, j].fire == true)
              {
                visual[2 * i + 1, 2 * j + 2].sprite = "🔥​";
                visual[2 * i + 1, 2 * j + 2].fire = true;
              }
              if (board[i, j].dragon == true)
              {
                if (!visual[2 * i + 1, 2 * j + 2].death)
                {
                  visual[2 * i + 1, 2 * j + 2].sprite = "​🐲​​";
                }
                if (turnos == 0)
                {
                  visual[2 * i + 1, 2 * j + 2].solid = true;
                  visual[2 * i + 1, 2 * j + 2].life = 70;
                  visual[2 * i + 1, 2 * j + 2].damage = 30;
                }
              }
              if (board[i, j].tree == true)
              {
                visual[2 * i + 1, 2 * j + 2].sprite = "​🌳​​";
                visual[2 * i + 1, 2 * j + 2].tree = true;
              }
            }
            if (board[i, j].david2)
            {
              visual[2 * i + 2, 2 * j + 1].sprite = "⬛​";
              if (board[i, j].guard == true)
              {
                if (!visual[2 * i + 2, 2 * j + 1].death)
                {
                  visual[2 * i + 2, 2 * j + 1].sprite = "💂​";
                }
                if (turnos == 0)
                {
                  visual[2 * i + 2, 2 * j + 1].solid = true;
                  visual[2 * i + 2, 2 * j + 1].life = 30;
                  visual[2 * i + 2, 2 * j + 1].damage = 30;
                }
              }
              if (board[i, j].fire == true)
              {
                visual[2 * i + 2, 2 * j + 1].sprite = "🔥​";
                visual[2 * i + 2, 2 * j + 1].fire = true;
              }
              if (board[i, j].dragon == true)
              {
                if (!visual[2 * i + 2, 2 * j + 1].death)
                {
                  visual[2 * i + 2, 2 * j + 1].sprite = "​🐲​​";
                }
                if (turnos == 0)
                {
                  visual[2 * i + 2, 2 * j + 1].solid = true;
                  visual[2 * i + 2, 2 * j + 1].life = 70;
                  visual[2 * i + 2, 2 * j + 1].damage = 30;
                }
              }
              if (board[i, j].tree == true)
              {
                visual[2 * i + 2, 2 * j + 1].sprite = "​🌳​​";
                visual[2 * i + 2, 2 * j + 1].tree = true;
              }
            }
          }
        }
        visual[row, col].sprite = "​🏯​";
        visual[Player1.row, Player1.col].sprite = Player1.sprite;
        visual[Player2.row, Player2.col].sprite = Player2.sprite;
        for (int i = 0; i < 2 * row + 1; i++)
        {
          for (int j = 0; j < 2 * col + 1; j++)
          {
            Console.Write(visual[i, j].sprite);
          }
          Console.WriteLine();
        }
        if ((turnos / 3) % 2 == 0)
        {
          Console.WriteLine("turno del jugador 1");
          Console.Write(Player1.name + " HP: " + Player1.life + " ");
          for (int i = 0; i < Player1.life / 2; i++)
          {
            Console.Write("|");
          }
          Console.WriteLine();
          Console.Write(Player2.name + " HP: " + Player2.life + " ");
          for (int i = 0; i < Player2.life / 2; i++)
          {
            Console.Write("|");
          }
          Console.WriteLine();
        }
        else
        {
          Console.WriteLine("Turno del jugador 2");
          Console.Write(Player1.name + " HP: " + Player1.life + " ");
          for (int i = 0; i < Player1.life / 2; i++)
          {
            Console.Write("|");
          }
          Console.WriteLine();
          Console.Write(Player2.name + " HP: " + Player2.life + " ");
          for (int i = 0; i < Player2.life / 2; i++)
          {
            Console.Write("|");
          }
          Console.WriteLine();
        }
        var action = Console.ReadKey(true).Key;
        if ((turnos / 3) % 2 == 0)
        {
          if (action == ConsoleKey.W)
          {
            if (visual[Player1.row - 1, Player1.col].sprite != "🧱​" && !visual[Player1.row - 1, Player1.col].solid)
            {
              Player1.row = Player1.row - 1;
              turnos++;
              if (Player1.Sigurd == true)
              {
                turnos--;
                Player1.Sigurd = false;
              }
            }
          }
          if (action == ConsoleKey.S)
          {
            if (visual[Player1.row + 1, Player1.col].sprite != "🧱​" && !visual[Player1.row + 1, Player1.col].solid)
            {
              Player1.row = Player1.row + 1;
              turnos++;
              if (Player1.Sigurd == true)
              {
                turnos--;
                Player1.Sigurd = false;
              }
            }
          }
          if (action == ConsoleKey.A)
          {
            if (visual[Player1.row, Player1.col - 1].sprite != "🧱​" && !visual[Player1.row, Player1.col - 1].solid)
            {
              Player1.col = Player1.col - 1;
              turnos++;
              if (Player1.Sigurd == true)
              {
                turnos--;
                Player1.Sigurd = false;
              }
            }
          }
          if (action == ConsoleKey.D)
          {
            if (visual[Player1.row, Player1.col + 1].sprite != "🧱​" && !visual[Player1.row, Player1.col + 1].solid)
            {
              Player1.col = Player1.col + 1;
              turnos++;
              if (Player1.Sigurd == true)
              {
                turnos--;
                Player1.Sigurd = false;
              }
            }
          }
          if (visual[Player1.row - 1, Player1.col].sprite == "💂​" || visual[Player1.row - 1, Player1.col].sprite == "​🐲​​" || (Player1.row - 1 == Player2.row && Player1.col == Player2.col)
          || visual[Player1.row + 1, Player1.col].sprite == "💂​" || visual[Player1.row + 1, Player1.col].sprite == "​🐲​​" || (Player1.row + 1 == Player2.row && Player1.col == Player2.col)
          || visual[Player1.row, Player1.col - 1].sprite == "💂​" || visual[Player1.row, Player1.col - 1].sprite == "​🐲​​" || (Player1.row == Player2.row && Player1.col - 1 == Player2.col)
          || visual[Player1.row, Player1.col + 1].sprite == "💂​" || visual[Player1.row, Player1.col + 1].sprite == "​🐲​​" || (Player1.row == Player2.row && Player1.col + 1 == Player2.col))
          {
            if (action == ConsoleKey.E)
            {
              Console.WriteLine("Decide a donde atacar");
              var direction = Console.ReadKey(true).Key;
              if (direction == ConsoleKey.W)
              {
                if (visual[Player1.row - 1, Player1.col].sprite == "💂​" || visual[Player1.row - 1, Player1.col].sprite == "​🐲​​")
                {
                  visual[Player1.row - 1, Player1.col].life = visual[Player1.row - 1, Player1.col].life - Player1.attack;
                  if (visual[Player1.row - 1, Player1.col].life <= 0)
                  {
                    visual[Player1.row - 1, Player1.col].solid = false;
                    visual[Player1.row - 1, Player1.col].death = true;
                  }
                  if (!Player1.Marth)
                  {
                    Player1.life = Player1.life - visual[Player1.row - 1, Player1.col].damage;
                  }
                  if (visual[Player1.row - 1, Player1.col].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player1.row - 1, Player1.col].life);
                    Console.ReadKey();
                  }
                }
                if (Player1.row - 1 == Player2.row && Player1.col == Player2.col)
                {
                  Player2.life = Player2.life - Player1.attack;
                  Console.WriteLine(Player1.name + " ha atacado con fiereza a " + Player2.name);
                  Console.ReadKey();
                }
                turnos++;
              }
              if (direction == ConsoleKey.S)
              {
                if (visual[Player1.row + 1, Player1.col].sprite == "💂​" || visual[Player1.row + 1, Player1.col].sprite == "​🐲​​")
                {
                  visual[Player1.row + 1, Player1.col].life = visual[Player1.row + 1, Player1.col].life - Player1.attack;
                  if (visual[Player1.row + 1, Player1.col].life <= 0)
                  {
                    visual[Player1.row + 1, Player1.col].solid = false;
                    visual[Player1.row + 1, Player1.col].death = true;
                  }
                  if (!Player1.Marth)
                  {
                    Player1.life = Player1.life - visual[Player1.row + 1, Player1.col].damage;
                  }
                  if (visual[Player1.row + 1, Player1.col].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player1.row + 1, Player1.col].life);
                    Console.ReadKey();
                  }
                }
                if (Player1.row + 1 == Player2.row && Player1.col == Player2.col)
                {
                  Player2.life = Player2.life - Player1.attack;
                  Console.WriteLine(Player1.name + " ha atacado con fiereza a " + Player2.name);
                  Console.ReadKey();
                }
                turnos++;
              }
              if (direction == ConsoleKey.A)
              {
                if (visual[Player1.row, Player1.col - 1].sprite == "💂​" || visual[Player1.row, Player1.col - 1].sprite == "​🐲​​")
                {
                  visual[Player1.row, Player1.col - 1].life = visual[Player1.row, Player1.col - 1].life - Player1.attack;
                  if (visual[Player1.row, Player1.col - 1].life <= 0)
                  {
                    visual[Player1.row, Player1.col - 1].solid = false;
                    visual[Player1.row, Player1.col - 1].death = true;
                  }
                  if (!Player1.Marth)
                  {
                    Player1.life = Player1.life - visual[Player1.row, Player1.col - 1].damage;
                  }
                  if (visual[Player1.row, Player1.col - 1].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player1.row, Player1.col - 1].life);
                    Console.ReadKey();
                  }
                }
                if (Player1.row == Player2.row && Player1.col - 1 == Player2.col)
                {
                  Player2.life = Player2.life - Player1.attack;
                  Console.WriteLine(Player1.name + " ha atacado con fiereza a " + Player2.name);
                  Console.ReadKey();
                }
                turnos++;
              }
              if (direction == ConsoleKey.D)
              {
                if (visual[Player1.row, Player1.col + 1].sprite == "💂​" || visual[Player1.row, Player1.col + 1].sprite == "​🐲​​")
                {
                  visual[Player1.row, Player1.col + 1].life = visual[Player1.row, Player1.col + 1].life - Player1.attack;
                  if (visual[Player1.row, Player1.col + 1].life <= 0)
                  {
                    visual[Player1.row, Player1.col + 1].solid = false;
                    visual[Player1.row, Player1.col + 1].death = true;
                  }
                  if (!Player1.Marth)
                  {
                    Player1.life = Player1.life - visual[Player1.row, Player1.col + 1].damage;
                  }
                  if (visual[Player1.row, Player1.col + 1].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player1.row, Player1.col + 1].life);
                    Console.ReadKey();
                  }
                }
                if (Player1.row == Player2.row && Player1.col + 1 == Player2.col)
                {
                  Player2.life = Player2.life - Player1.attack;
                  Console.WriteLine(Player1.name + " ha atacado con fiereza a " + Player2.name);
                  Console.ReadKey();
                }
                turnos++;
              }
            }
          }
          if ((turnos / 3) % 2 == 1)
          {
            if (Player1.sprite == "🏇")
            {
              Player1.Sigurd = true;
            }
            if (Player1.HP == 110)
            {
              Player1.Chrom = true;
            }
          }
        }
        else
        {
          if (Player1.Chrom)
          {
            if (Player1.life <= Player1.HP)
            {
              Player1.life = Player1.life + 10;
              Player1.Chrom = false;
            }
            else
            {
              Player1.life = Player1.HP;
              Player1.Chrom = false;
            }
          }
          if (action == ConsoleKey.W)
          {
            if (visual[Player2.row - 1, Player2.col].sprite != "🧱​" && !visual[Player2.row - 1, Player2.col].solid)
            {
              Player2.row = Player2.row - 1;
              turnos++;
              if (Player2.Sigurd == true)
              {
                turnos--;
                Player2.Sigurd = false;
              }
            }
          }
          if (action == ConsoleKey.S)
          {
            if (visual[Player2.row + 1, Player2.col].sprite != "🧱​" && !visual[Player2.row + 1, Player2.col].solid)
            {
              Player2.row = Player2.row + 1;
              turnos++;
              if (Player2.Sigurd == true)
              {
                turnos--;
                Player2.Sigurd = false;
              }
            }
          }
          if (action == ConsoleKey.A)
          {
            if (visual[Player2.row, Player2.col - 1].sprite != "🧱​" && !visual[Player2.row, Player2.col - 1].solid)
            {
              Player2.col = Player2.col - 1;
              turnos++;
              if (Player2.Sigurd == true)
              {
                turnos--;
                Player2.Sigurd = false;
              }
            }
          }
          if (action == ConsoleKey.D)
          {
            if (visual[Player2.row, Player2.col + 1].sprite != "🧱​" && !visual[Player2.row, Player2.col + 1].solid)
            {
              Player2.col = Player2.col + 1;
              turnos++;
              if (Player2.Sigurd == true)
              {
                turnos--;
                Player2.Sigurd = false;
              }
            }
          }
          if (visual[Player2.row - 1, Player2.col].sprite == "💂​" || visual[Player2.row - 1, Player2.col].sprite == "​🐲​​" || (Player2.row - 1 == Player1.row && Player2.col == Player1.col)
         || visual[Player2.row + 1, Player2.col].sprite == "💂​" || visual[Player2.row + 1, Player2.col].sprite == "​🐲​​" || (Player2.row + 1 == Player1.row && Player2.col == Player1.col)
         || visual[Player2.row, Player2.col - 1].sprite == "💂​" || visual[Player2.row, Player2.col - 1].sprite == "​🐲​​" || (Player2.row == Player1.row && Player2.col - 1 == Player1.col)
         || visual[Player2.row, Player2.col + 1].sprite == "💂​" || visual[Player2.row, Player2.col + 1].sprite == "​🐲​​" || (Player2.row == Player1.row && Player2.col + 1 == Player1.col))
          {
            if (action == ConsoleKey.E)
            {
              Console.WriteLine("Decide a donde atacar");
              var direction = Console.ReadKey(true).Key;
              if (direction == ConsoleKey.W)
              {
                if (visual[Player2.row - 1, Player2.col].sprite == "💂​" || visual[Player2.row - 1, Player2.col].sprite == "​🐲​​")
                {
                  visual[Player2.row - 1, Player2.col].life = visual[Player2.row - 1, Player2.col].life - Player2.attack;
                  if (visual[Player2.row - 1, Player2.col].life <= 0)
                  {
                    visual[Player2.row - 1, Player2.col].solid = false;
                    visual[Player2.row - 1, Player2.col].death = true;
                  }
                  if (!Player2.Marth)
                  {
                    Player2.life = Player2.life - visual[Player2.row - 1, Player2.col].damage;
                  }
                  if (visual[Player2.row - 1, Player2.col].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player2.row - 1, Player2.col].life);
                    Console.ReadKey();
                  }
                }
                if (Player2.row - 1 == Player1.row && Player2.col == Player1.col)
                {
                  Player1.life = Player1.life - Player2.attack;
                  Console.WriteLine(Player2.name + " ha atacado con fiereza a " + Player1.name);
                  Console.ReadKey();
                }
                turnos++;
              }
              if (direction == ConsoleKey.S)
              {
                if (visual[Player2.row + 1, Player2.col].sprite == "💂​" || visual[Player2.row + 1, Player2.col].sprite == "​🐲​​")
                {
                  visual[Player2.row + 1, Player2.col].life = visual[Player2.row + 1, Player2.col].life - Player2.attack;
                  if (visual[Player2.row + 1, Player2.col].life <= 0)
                  {
                    visual[Player2.row + 1, Player2.col].solid = false;
                    visual[Player2.row + 1, Player2.col].death = true;
                  }
                  if (!Player2.Marth)
                  {
                    Player2.life = Player2.life - visual[Player2.row + 1, Player2.col].damage;
                  }
                  if (visual[Player2.row + 1, Player2.col].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player2.row + 1, Player2.col].life);
                    Console.ReadKey();
                  }
                }
                if (Player2.row + 1 == Player2.row && Player1.col == Player2.col)
                {
                  Player1.life = Player1.life - Player2.attack;
                  Console.WriteLine(Player2.name + " ha atacado con fiereza a " + Player1.name);
                  Console.ReadKey();
                }
                turnos++;
              }
              if (direction == ConsoleKey.A)
              {
                if (visual[Player2.row, Player2.col - 1].sprite == "💂​" || visual[Player2.row, Player2.col - 1].sprite == "​🐲​​")
                {
                  visual[Player2.row, Player2.col - 1].life = visual[Player2.row, Player2.col - 1].life - Player2.attack;
                  if (visual[Player2.row, Player2.col - 1].life <= 0)
                  {
                    visual[Player2.row, Player2.col - 1].solid = false;
                    visual[Player2.row, Player2.col - 1].death = true;
                  }
                  if (!Player2.Marth)
                  {
                    Player2.life = Player2.life - visual[Player2.row, Player2.col - 1].damage;
                  }
                  if (visual[Player2.row, Player2.col - 1].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player2.row, Player2.col - 1].life);
                    Console.ReadKey();
                  }
                }
                if (Player2.row == Player1.row && Player2.col - 1 == Player1.col)
                {
                  Player1.life = Player1.life - Player2.attack;
                  Console.WriteLine(Player2.name + " ha atacado con fiereza a " + Player1.name);
                  Console.ReadKey();
                }
                turnos++;
              }
              if (direction == ConsoleKey.D)
              {
                if (visual[Player2.row, Player2.col + 1].sprite == "💂​" || visual[Player2.row, Player2.col + 1].sprite == "​🐲​​")
                {
                  visual[Player2.row, Player2.col + 1].life = visual[Player2.row, Player2.col + 1].life - Player2.attack;
                  if (visual[Player2.row, Player2.col + 1].life <= 0)
                  {
                    visual[Player2.row, Player2.col + 1].solid = false;
                    visual[Player2.row, Player2.col + 1].death = true;
                  }
                  if (!Player2.Marth)
                  {
                    Player2.life = Player2.life - visual[Player2.row, Player2.col + 1].damage;
                  }
                  if (visual[Player1.row, Player1.col + 1].life <= 0)
                  {
                    Console.WriteLine("El enemigo ha muerto");
                    Console.ReadKey();
                  }
                  else
                  {
                    Console.WriteLine("Vida restante del enemigo = " + visual[Player2.row, Player2.col + 1].life);
                    Console.ReadKey();
                  }
                }
                if (Player2.row == Player1.row && Player2.col + 1 == Player1.col)
                {
                  Player1.life = Player1.life - Player2.attack;
                  Console.WriteLine(Player2.name + " ha atacado con fiereza a " + Player1.name);
                  Console.ReadKey();
                }
                turnos++;
              }
            }
          }
        }
        if ((turnos / 3) % 2 == 0)
        {
          if (Player2.sprite == "🏇")
          {
            Player2.Sigurd = true;
          }
          if (Player2.HP == 110)
          {
            Player2.Chrom = true;
          }
        }
        else
        {
          if (Player2.Chrom)
          {
            if (Player2.life <= Player2.HP)
            {
              Player2.life = Player2.life + 10;
              Player2.Chrom = false;
            }
            else
            {
              Player2.life = Player2.HP;
              Player2.Chrom = false;
            }
          }
        }
        if (visual[Player1.row, Player1.col].fire)
        {
          if ((turnos / 3) % 2 == 0)
          {
            Player1.life = Player1.life - 10;
            Console.WriteLine(Player1.name + " se ha quemado profundamente");
            Console.ReadKey();
          }
        }
        if (visual[Player2.row, Player2.col].fire)
        {
          if ((turnos / 3) % 2 == 1)
          {
            Player2.life = Player2.life - 10;
            Console.WriteLine(Player2.name + " se ha quemado profundamente");
            Console.ReadKey();
          }
        }
        if (visual[Player1.row, Player1.col].tree)
        {
          if ((turnos / 3) % 2 == 0)
          {
            if (Player1.life <= Player1.HP - 10)
            {
              Player1.life = Player1.life + 10;
            }
            else
            {
              Player1.life = Player1.HP;
            }
            Console.WriteLine(Player1.name + " se ha puesto a resguardo en el bosque");
            Console.WriteLine();
            Console.WriteLine("Recupera 10 de vida");
            Console.ReadKey();
          }
        }
        else
        {
          Player1.defense = Player1.armor;
        }
        if (visual[Player2.row, Player2.col].tree)
        {
          if ((turnos / 3) % 2 == 1)
          {
            if (Player2.life <= Player2.HP - 10)
            {
              Player2.life = Player2.life + 10;
            }
            else
            {
              Player2.life = Player2.HP;
            }
            Console.WriteLine(Player2.name + " se ha puesto a resguardo en el bosque");
            Console.WriteLine();
            Console.WriteLine("Recupera 10 de vida");
            Console.ReadKey();
          }
        }
        if (Player1.life <= 0)
        {
          Console.Clear();
          if (!Player1.Hector)
          {
            Console.WriteLine(Player1.name + " ha muerto");
            Console.ReadKey();
            Player1.row = 1;
            Player1.col = 1;
            Player1.life = Player1.HP;
          }
          else
          {
            Console.WriteLine("Hector ha desafiado la muerte una vez mas");
            Console.ReadKey();
            Player1.life = Player1.HP;
            Player1.Hector = false;
          }
        }
        if (Player2.life <= 0)
        {
          Console.Clear();
          if (!Player2.Hector)
          {
            Console.WriteLine(Player2.name + " ha muerto");
            Console.ReadKey();
            Player2.row = 1;
            Player2.col = 2 * col + 1;
            Player2.life = Player2.HP;
          }
          else
          {
            Console.WriteLine("Hector ha desafiado la muerte una vez mas");
            Console.ReadKey();
            Player2.life = Player2.HP;
            Player2.Hector = false;
          }
        }
        Console.Clear();
        if (Player1.row == row && Player1.col == col)
        {
          Console.WriteLine(Player1.name + " ha logrado regresar a su reino y poner a salvo su realidad");
          break;
        }
        if (Player2.row == row && Player2.col == col)
        {
          Console.WriteLine(Player2.name + " ha logrado regresar a su reino y poner a salvo su realidad");
          break;
        }
      }
      Console.ReadKey();
      Console.Clear();
      Console.WriteLine("Gracias por jugar");
    }

    public void generator(int x, int y)
    {
      board[x, y].visited = true;
      int[] L = new int[4];
      for (int i = 0; i < 4; i++)
      {
        L[i] = i + 1;
      }
      for (int i = 0; i < 4; i++)
      {
        Random rand = new Random();
        int t = rand.Next() % 4;
        int k = L[t];
        L[t] = L[3 - i];
        L[3 - i] = k;
      }
      for (int i = 0; i < 4; i++)
      {
        switch (L[i])
        {
          case 1:
            if (x != 0)
            {
              if (!board[x - 1, y].visited)
              {
                board[x, y].david1 = true;
                board[x - 1, y].david2 = true;
                generator(x - 1, y);
              }
            }
            break;
          case 2:
            if (x != row - 1)
            {
              if (!board[x + 1, y].visited)
              {
                board[x, y].david2 = true;
                board[x + 1, y].david1 = true;
                generator(x + 1, y);
              }
            }
            break;
          case 3:
            if (y != 0)
            {
              if (!board[x, y - 1].visited)
              {
                board[x, y].david3 = true;
                board[x, y - 1].david4 = true;
                generator(x, y - 1);
              }
            }
            break;
          case 4:
            if (y != col - 1)
            {
              if (!board[x, y + 1].visited)
              {
                board[x, y].david4 = true;
                board[x, y + 1].david3 = true;
                generator(x, y + 1);
              }
            }
            break;
        }
      }
      return;
    }
  }

}

