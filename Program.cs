using System.Globalization;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes

string opecoa = null;
do {
    List<Pessoa> hospedes = new List<Pessoa>();

    Console.WriteLine("Digite Opeções: ");
    Console.WriteLine("Cadastrar No Hotel - 1");
    Console.WriteLine("Enter paara sair :");

    opecoa = Console.ReadLine();
    


    if (opecoa == "1")
    {   
        try
        {   
            Console.Clear();
            Console.WriteLine("Digite capacidade da Suite");
            int capacidade = Convert.ToInt32(Console.ReadLine());

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: capacidade, valorDiaria: 30);

            Console.WriteLine("Digite numero de Hopedes");
            int numeroHospedes = Convert.ToInt32(Console.ReadLine());
            
            for(int contador = 1; contador <= numeroHospedes; contador ++)
            {   
                Console.WriteLine("Digite seu nome:");
                string nomeHospede = Console.ReadLine();
                
                Pessoa p = new Pessoa(nome: nomeHospede);
                hospedes.Add(p);
            }

        
            // Cria uma nova reserva, passando a suíte e os hóspedes
            Console.WriteLine("Dias Reservados :");
            int diasReservados = Convert.ToInt32(Console.ReadLine());

            Reserva reserva = new Reserva(diasReservados: diasReservados);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            string format = $"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            Console.WriteLine(format);
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            Console.WriteLine(format);
        }
        catch (Exception ex)
        {
           Console.WriteLine($"Erro {ex.Message}");
        }
    }


} while (opecoa != "");