using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("14 999656555","Yz34","789456123321654",16);
Iphone iphone1 = new Iphone("14 99965653","12ProMax","123456789987654",16);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");
iphone1.InformacoesDoAparelho();

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Instagram");
nokia1.InformacoesDoAparelho();



