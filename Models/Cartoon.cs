using System;

namespace DBApp.Models
{
    public class Cartoon
    {
        private int _id;
        private String name;
        private String studio;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Studio
        {
            get => studio;
            set => studio = value;
        }
    }
}