namespace DesafioPOO.Models

{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Você instalou o Aplicativo {nomeApp} com sucesso!");
        }

    }
}