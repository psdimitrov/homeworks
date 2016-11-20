namespace Blobs.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;

    public class Engine : IRunnable
    {
        private readonly IBlobFactory blobFactory;
        private readonly IBlobsData data;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        public Engine(IBlobFactory unitFactory, IBlobsData data, IInputReader reader, IOutputWriter writer)
        {
            this.blobFactory = unitFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public virtual void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBlobs();
            }

        }
        
        // Method is protected and virtual to allow extensions

        protected virtual void ExecuteCommand(string[] input)
        {
            switch (input[0])
            {
                case "create":
                    this.ExecuteCreateCommand(input);
                    break;
                case "attack":
                    this.ExecuteAttackCommand(input);
                    break;
                case "pass":
                    break;
                case "status":
                    this.ExecuteStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;                                     
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder sb = new StringBuilder();
            

            foreach (IBlob blob in this.data.Blobs)
            {
                sb.AppendLine(blob.ToString());
            }

            this.writer.PrintLine(sb.ToString().Trim());
        }

        private void ExecuteAttackCommand(string[] inputParams)
        {
            string attacker = inputParams[1];
            string target = inputParams[2];

            IBlob attackerBlob = this.data.Blobs.FirstOrDefault(blob => blob.Name == attacker);
            IBlob targetBlob = this.data.Blobs.FirstOrDefault(blob => blob.Name == target);

            if (attackerBlob == null)
            {
                throw new ArgumentException("The name of the attacker don't exist");
            }
            if (targetBlob == null)
            {
                throw new ArgumentException("The name of the target doesn't exist.");
            }
            if (attackerBlob.Dead || targetBlob.Dead)
            {
                return;
            }
            attackerBlob.AttackEnemy(targetBlob, attackerBlob.Attack);
        }

        private void ExecuteCreateCommand(string[] inputParams)
        {
            string name = inputParams[1];
            int health = int.Parse(inputParams[2]);
            int damage = int.Parse(inputParams[3]);
            string behavior = inputParams[4];
            string attack = inputParams[5];
            IBlob blob = this.blobFactory.CreateBlob(name, health, damage, behavior, attack);

            this.data.AddBlob(blob);
        }

        private void UpdateBlobs()
        {
            foreach (IBlob blob in this.data.Blobs)
            {
                blob.Update();
            }
        }

    }
}
