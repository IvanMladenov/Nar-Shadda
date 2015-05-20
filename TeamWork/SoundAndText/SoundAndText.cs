using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;

namespace BitBuilderNew
{
    class BitBuilderNew
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TimeSpan interval = new TimeSpan(0, 0, 0, 0, 100);
            string textPath = @"E:\Fundamentials\TeamWork\text.txt";
            string[] text = File.ReadAllLines(textPath);

            string soundPath = @"E:\Fundamentials\TeamWork\typewriter-1.wav";
            SoundPlayer typewriter = new SoundPlayer(soundPath);

            string logoPath = @"E:\Fundamentials\TeamWork\logo.txt";
            string[] logo = File.ReadAllLines(logoPath);
            Console.WriteLine();
            foreach (string item in logo)
            {
                Console.Write(new string(' ', (Console.WindowWidth - item.Length) / 2));
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }
            Thread.Sleep(5000);
            Console.Clear();
            
            //string backGround = @"E:\Fundamentials\TeamWork\Candyman_-_It_Was_Always_You_Helen.wav";            
            //SoundPlayer backGroundsong = new SoundPlayer(backGround);
            //backGroundsong.LoadAsync();
            //backGroundsong.Play();            
            //typewriter.LoadAsync();
            typewriter.LoadAsync();
            foreach (string item in text)
            {
                typewriter.Play();
                foreach (char ch in item)
                {
                    Thread.Sleep(interval);
                    Console.Write(ch);
                }
                typewriter.Stop();
                Thread.Sleep(1000);
                Console.Clear();
            }
            typewriter.Dispose();
        }
    }
}
