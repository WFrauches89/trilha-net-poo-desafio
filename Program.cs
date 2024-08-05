using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia newNokia = new Nokia("22999999999", "Ultra", "Mobile - xc897", 64);

newNokia.Ligar();
newNokia.ReceberLigacao();
newNokia.InstalarAplicativo("Snake Game");

Iphone newIphone = new Iphone("2211111111", "16 Pro Max", "Mobile - Iphone csrs4", 32);

newIphone.Ligar();
newIphone.ReceberLigacao();
newIphone.InstalarAplicativo("Snake Game");

