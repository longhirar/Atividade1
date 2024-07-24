

class HelloWorld
{
    public static void Escreve()
    {
        Console.WriteLine("_|                  _|  _|                                                              _|        _|  _|\r\n_|_|_|      _|_|    _|  _|    _|_|              _|      _|      _|    _|_|    _|  _|_|  _|    _|_|_|  _|\r\n_|    _|  _|_|_|_|  _|  _|  _|    _|            _|      _|      _|  _|    _|  _|_|      _|  _|    _|  _|\r\n_|    _|  _|        _|  _|  _|    _|              _|  _|  _|  _|    _|    _|  _|        _|  _|    _|\r\n_|    _|    _|_|_|  _|  _|    _|_|      _|          _|      _|        _|_|    _|        _|    _|_|_|  _|\r\n                                      _|\r\n\r\n");
    }
}

class Calculadora
{

}

class Program
{
    public static bool deve_sair = false;

    public static void Main(string[] args)
    {
        while (!deve_sair)
        {
            Console.WriteLine("Escolha um Programa:\n" +
                "1) Hello World\n" +
                "2) Calculadora\n" +
                "3) Par ou Ímpar\n" +
                "4) Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    HelloWorld.Escreve();
                    break;
                case "2":

                    break;
                case "3":

                case "4":
                    deve_sair = true;
                    break;
            }
        }
    }

}