using System;

namespace BlazorSIGA.Server.Entidades
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }
    }
}

