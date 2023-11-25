using back;
using static back.Machine;

//Déclaration Objet Usine et du nombre de machines de la ligne
Usine usine; 
int nombreMachine;
//Déclaration d'un tableau d'objets Machines
Machine[] listeMachines;
TraitementDelegate traitementDelegate = null;
//Demande à l'utilisateur le nombre de machine
Console.WriteLine("Combien de machines ajouter à la ligne de traitement : ");
nombreMachine = int.Parse(Console.ReadLine()); 

// Instanciation du tableau d'objets Machine de taille le nombre de machine
listeMachines = new Machine[nombreMachine];
// Cette boucle ajoute au tableau les machines de numéro choisis par l'utilisateur
for (int i = 0; i < listeMachines.Length; i++)
{
    Console.WriteLine($"Numéro de l'unité de traitement en position {i + 1} : ");
    string inputNumeroMachine = Console.ReadLine();
    if (int.TryParse(inputNumeroMachine, out int numeroMachine))
    {
        listeMachines[i] = new Machine(numeroMachine);
        traitementDelegate += listeMachines[i].Traitement;
    }
    else
    {
        // Si le numéro n'est pas un entier, l'utilisateur réessaie.
        Console.WriteLine("Erreur de saisie pour le numéro de machine.");
        i--;
    }
}
// Instanciation de l'usine qui contient la liste des machines et affichage de l'ordre
usine = new Usine(nombreMachine, listeMachines);
usine.AffichageOrdreMachines();

// Lancement de la ligne de production avec le délégué
Console.WriteLine("Lancement du processus...");
traitementDelegate.Invoke();