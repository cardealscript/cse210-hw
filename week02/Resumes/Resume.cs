using System;
using System.Collections.Generic;

namespace Resumes
{
    public class Resume
    {
        // Nome da pessoa
        public string _name;

        // Lista de empregos
        public List<Job> _jobs = new List<Job>();

        // Método para exibir o currículo
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}
