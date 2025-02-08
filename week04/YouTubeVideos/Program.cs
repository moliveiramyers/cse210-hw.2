using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Comments comment1 = new Comments("maria j.", "Uau, esse video e fixe!");
        Comments comment2 = new Comments("Tonio", "Surpreso");
        Comments comment3 = new Comments("Godness Pink", "E a terceira vez que vejo. Nao consigo parar.");
        Videos video1 = new Videos("Voi Che Sappete", "Joana Ribeiro", 225);
        video1.AddComments(comment1);
        video1.AddComments(comment2);
        video1.AddComments(comment3);
        video1.AddVideos(video1);

        Videos vidoe2 = new Videos("Whats is encapsulation", "Yun Sun", 300);
        Comments comment4 = new Comments("Maria", "very explanatory");
        Comments comment5= new Comments("joan", "top");
        Comments comment6= new Comments("Prdro","Thanks, guy");
        vidoe2.AddComments(comment4);
        vidoe2.AddComments(comment5);
        vidoe2.AddComments(comment6);
        vidoe2.AddVideos(vidoe2);

        Videos video3 = new Videos("How to make a lasagna","Pauola Signorine",600);
        Comments comment7= new Comments("Ana", "Grazie");
        Comments comment8= new Comments("john","It was very simple");
        Comments comment9= new Comments("Miguel", "It looks yammy");
        video3.AddComments(comment7);
        video3.AddComments(comment8);
        video3.AddComments(comment9);
        video3.AddVideos(video3);

        video1.Display();
        Console.WriteLine();
        vidoe2.Display();
        Console.WriteLine();
        video3.Display();



    }
}