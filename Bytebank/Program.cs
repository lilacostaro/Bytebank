using Bytebank.Contas;
using Bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.Titular = "Andre Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100.0;
//contaDoAndre.Informcoes_conta();

//Console.WriteLine($"O saldo da conta do Andre é: R$ {contaDoAndre.saldo}");

//await Task.Delay(5000);
//contaDoAndre.Depositar(400);
//Console.WriteLine($"Um deposito foi realizado na conta {contaDoAndre.conta}");
//Console.WriteLine($"O novo saldo da conta do Andre é: R$ {contaDoAndre.saldo}");

//await Task.Delay(5000);
//Console.WriteLine($"Tentativa de saque na conta {contaDoAndre.conta}");
//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine($"Saldo realizado com sucesso! " +
//        $"O novo saldo da conta do Andre é: R$ {contaDoAndre.saldo}");
//}
//else
//{
//    Console.WriteLine($"O valor do seu saldo é: R${contaDoAndre.saldo}");
//}


//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.Titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;
//contaDaMaria.Informcoes_conta();

//Console.WriteLine($"O saldo da conta da Maria é: R$ {contaDaMaria.saldo}");

//if (contaDoAndre.Transferir(250, contaDaMaria) == true)
//{
//    Console.WriteLine("Transferencia realizada com sucesso!");
//}
//else
//{
//    Console.WriteLine("Não foi possivel realizar a transferencia.\n Saldo Insuficiente");
//}

//Console.WriteLine($"O novo saldo da conta do Andre é: R$ {contaDoAndre.saldo}");
//Console.WriteLine($"O novo saldo da conta da Maria é: R$ {contaDaMaria.saldo}");

Cliente camila = new Cliente("Camila Rodrigues Costa", "012.345.678-90", "Desenvolvedora");

ContaCorrente contaDaCamila = new ContaCorrente(18, "1010-5", 500, camila);

contaDaCamila.Informcoes_conta();
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Cliente tom = new Cliente("Tom Rodrigues Costa", "987.654.321-00", "Desenvolvedor");

ContaCorrente contaDoTom = new ContaCorrente(185, "1015-5", 500, tom);

contaDoTom.Informcoes_conta();
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente.TotalDeContasCriadas = 100;

Cliente harry = new Cliente("Harry Rodrigues Costa", "987.654.321-00", "Desenvolvedor");

ContaCorrente contaDoHarry = new ContaCorrente(185, "1015-5", 500, harry);

contaDoHarry.Informcoes_conta();
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine(Cliente.TotalDeClientes);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.Titular = new Cliente();
//conta2.Titular.Nome = "Tester";
//conta2.Titular.Profissao = "Desenvolvedor";
//conta2.Titular.Cpf = "987654321";
//conta2.Conta = "1234-5";
//conta2.Numero_agencia = 10;
//conta2.SetSaldo(-10);

//conta2.Informcoes_conta();
//Console.WriteLine(conta2.GetSaldo());
//Console.WriteLine(conta2.Numero_agencia);
