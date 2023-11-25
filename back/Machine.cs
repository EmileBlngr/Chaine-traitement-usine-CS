namespace back
{
    public class Machine
    {
        public int NumeroMachine {  get; set; }
        public Machine(int numeroMachine) 
        {
            this.NumeroMachine = numeroMachine;
        }
        public delegate void TraitementDelegate();
        public void Traitement()
        {
            Console.WriteLine($"Traitement de la machine numéro {NumeroMachine}");
        }
    }
}
