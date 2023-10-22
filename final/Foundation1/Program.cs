using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        List<Video> listaDeVideos = new List<Video>();

        Video v1 = new Video("Hola mundo", "Open AI", 300);
        v1.AddComment(new Comment("Moisés Cano H", "No entendí nada."));
        v1.AddComment(new Comment("Abraham Manzano S", "Great Video!"));
        v1.AddComment(new Comment("Amali Rojas G", "w_w"));
        listaDeVideos.Add(v1);

        Video v2 = new Video("OOP C#", "MoyCano", 50000);
        v2.AddComment(new Comment("Flor S. Cano H.", "Could someone give me a summary?"));
        v2.AddComment(new Comment("Jacob Cano Rojas", "Min 1:11 SOLID Principles, thank me later"));
        v2.AddComment(new Comment("Amali Cano Rojas", "I need to understand this video and there are only 10 minutes left before my exam."));
        v2.AddComment(new Comment("Anastasia Cano Rojas", "No creo que tenga una hija que se llame Anastasia"));
        listaDeVideos.Add(v2);

        Video v3 = new Video("The Best Of YIRUMA Yiruma's Greatest Hits ~ Best Piano", "Yiruma", 5616);
        v3.AddComment(new Comment("Luis Alberto", "Cuộc sống thật áp lực nên chúc các bạn thư giãn với video này để có tinh thần ngày mai chúng ta lại phải chiến đâu tiếp."));
        v3.AddComment(new Comment("Uki Nunutzi", "Most beautiful piano music"));
        v3.AddComment(new Comment("Daniel ", "Currently listening to this while completing some assignments. Just need something relaxing and not too distracting. This is amazing :)"));
        v3.AddComment(new Comment("Aura Luque", "I wanna just sit down one of that chair and just be there listening to music and rain. Watching this is the closest I can get to that"));
        listaDeVideos.Add(v3);

        foreach (Video video in listaDeVideos)
        {
            Console.WriteLine(video.DisplayVideoDetail());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayCommentsDetail());
            }
            Console.WriteLine("--------------");
        }

    }
}