namespace _09._Collection_Hierarchy.Controllers
{
    using Interfaces;
    using Models;
    using System;
    using System.Text;

    public class Engine
    {
        private IAddCollection<string> addCollection;
        private IAddRemoveCollection<string> addRemoveCollection;
        private IMyList<string> myList;
        private StringBuilder stringBuilder;

        public Engine()
        {
            this.addCollection = new AddCollection<string>();
            this.addRemoveCollection = new AddRemoveCollection<string>();
            this.myList = new MyList<string>();
            this.stringBuilder = new StringBuilder();
        }

        internal void Run()
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            this.FillCollection(ref input, this.addCollection);
            this.FillCollection(ref input, this.addRemoveCollection);
            this.FillCollection(ref input, this.myList);

            var n = int.Parse(Console.ReadLine());

            this.Remove(n, this.addRemoveCollection);
            this.Remove(n, this.myList);

            Console.WriteLine(this.stringBuilder.ToString().Trim());
        }

        private void Remove<T>(int n, IAddRemoveCollection<T> collection)
        {
            for (int i = 0; i < n; i++)
            {
                var removedElement = collection.Remove();
                this.stringBuilder.Append($"{removedElement} ");
            }

            this.stringBuilder
                .Remove(this.stringBuilder.Length - 1, 1)
                .AppendLine();
        }

        private void FillCollection(ref string[] input, IAddCollection<string> collection)
        {
            foreach (var str in input)
            {
                var index = collection.Add(str);
                this.stringBuilder.Append($"{index} ");
            }

            this.stringBuilder
                .Remove(this.stringBuilder.Length - 1, 1)
                .AppendLine();
        }
    }
}