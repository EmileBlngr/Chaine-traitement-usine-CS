namespace back
{
    /// <summary>
    /// Classe Usine, managée grâce à l'interface Disposable
    /// </summary>
    public class Usine : IDisposable
    {
        public int NombreMachine {  get; set; }
        public Machine[] ListeMachine {  get; set; }
        public Usine(int nombreMachine, Machine[] listeMachine)
        {
            this.NombreMachine = nombreMachine;
            this.ListeMachine = listeMachine;
        }
        public void AffichageOrdreMachines ()
        {
            for (int i = 0; i < NombreMachine; i++)
            {
                Console.Write($" Machine U{ListeMachine[i].NumeroMachine} ->");
            }
            Console.Write(" Produit Finis\n");
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
